Imports ClasesBLL
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class FrmProduccionAdd

    Dim obj As New Prod_Produccion
    Dim db As New db_Prod_Produccion

    Dim obj_dtl As New Prod_ProduccionDetalle
    Dim db_dtl As New db_Prod_ProduccionDetalle

    Dim obj_dev As New Prod_ProduccionDevoluciones
    Dim db_dev As New db_Prod_ProduccionDevoluciones

    Public IdProduccion As Integer = 0
    Dim DT As DataTable, DT_DEV As DataTable
    Dim AgregarOtroProd As Boolean = False

    Private Sub FrmProduccionAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            DatosProducto()
            AgregarOtroProd = True
        End If
    End Sub

    Private Sub FrmFormula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        CargarCombos()
        '
        If IdProduccion <> 0 Then
            obj = db_Prod_Produccion.Detalles(IdProduccion)

            If Not obj Is Nothing Then
                Numero.Text = obj.NumeroProduccion
                dFecha.DateTime = obj.FechaProduccion
                cbFormula.EditValue = obj.IdSysFormula
                cbEstado.EditValue = obj.IdSysEstadoPRoduccion
                TxtAProducir.EditValue = obj.CantidadProducir
                txtNoDocumento.Text = obj.NoDocumento
                txtObservaciones.Text = obj.Observaciones
                cbBodega.EditValue = obj.Bodega
                cbFormula.Properties.ReadOnly = True

                DatosProducto()
                BackColorEstado()
            End If
        Else
            dFecha.DateTime = Now.Date
            Numero.Text = db_Prod_Produccion.GetNumero()

            Dim db_Estado As New db_Prod_EstadoProduccion
            cbEstado.EditValue = db_Estado.GetTipoEstadoOrden(1)
            BackColorEstado()
        End If
        '
        'Cargar Detalle de la formula
        DT = db_Prod_ProduccionDetalle.Listar(IdProduccion)
        iGrid.DataSource = DT
        iVista.PopulateColumns()
        FormatoGrid2(iVista, 6, 0, False, True, False)

        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
        Next

        iVista.Columns("Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("Total").SummaryItem.DisplayFormat = "{0:n6}"

        iVista.Columns("Base Producir").OptionsColumn.AllowEdit = True
        iVista.Columns("A Producir").OptionsColumn.AllowEdit = True
        iVista.Columns("Tipo Producto").OptionsColumn.AllowEdit = True
        'iVista.Columns("Bodega").OptionsColumn.AllowEdit = True
        '
        iVista.Columns("IdDetalle").Visible = False
        iVista.Columns("IdFormula").Visible = False
        iVista.Columns("IdProduccion").Visible = False
        iVista.Columns("Tipo").Visible = False
        iVista.Columns("Existencia").Visible = False
        iVista.Columns("Presentacion").Visible = False
        iVista.Columns("Cantidad").Visible = False
        iVista.Columns("Costo").Visible = False
        iVista.Columns("Total").Visible = False

        iVista.Columns("Producto").ColumnEdit = cbItems
        iVista.Columns("Tipo Producto").ColumnEdit = TipoProducto
        iVista.Columns("Bodega").ColumnEdit = Bodega
        iVista.Columns("Cantidad").ColumnEdit = txtCantidad
        iVista.Columns("Cantidad Base").ColumnEdit = txtCantidad
        iVista.Columns("Base Producir").ColumnEdit = txtCantidad
        iVista.Columns("A Producir").ColumnEdit = txtCantidad
        iVista.Columns("Costo").ColumnEdit = txtCantidad
        iVista.Columns("Total").ColumnEdit = txtCantidad
        'iVista.Columns("Producto").Width = 250
        iVista.BestFitColumns()

        'Cargar Devoluciones
        DT_DEV = db_Prod_ProduccionDevoluciones.Listar(IdProduccion)
        iGridDev.DataSource = DT_DEV
        iVistaDev.PopulateColumns()
        FormatoGrid(iVistaDev, 6, 0, False, True, False)

        For i As Integer = 0 To iVistaDev.Columns.Count - 1
            iVistaDev.Columns(i).OptionsColumn.AllowEdit = False
        Next
        '
        iVista.Columns("Costo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.None

        iVistaDev.Columns("IdDetalle").Visible = False
        iVistaDev.Columns("IdProduccion").Visible = False
        iVistaDev.Columns("Tipo").Visible = False
        iVistaDev.Columns("Presentacion").Visible = False
        iVistaDev.Columns("Costo").Visible = False
        iVistaDev.Columns("Total").Visible = False

        iVistaDev.Columns("Producto").OptionsColumn.AllowEdit = True
        iVistaDev.Columns("Cantidad").OptionsColumn.AllowEdit = True
        iVistaDev.Columns("Tipo Producto").OptionsColumn.AllowEdit = True
        iVistaDev.Columns("Bodega").OptionsColumn.AllowEdit = True

        iVistaDev.Columns("Producto").ColumnEdit = cbItems
        iVistaDev.Columns("Tipo Producto").ColumnEdit = TipoProducto
        iVistaDev.Columns("Bodega").ColumnEdit = Bodega
        iVistaDev.Columns("Cantidad").ColumnEdit = txtCantidad
        iVistaDev.Columns("Costo").ColumnEdit = txtCantidad
        iVistaDev.Columns("Total").ColumnEdit = txtCantidad

        TotalCosto()
        TotalBase()
    End Sub

    Sub CargarCombos()
        'Dim DT_PROD As DataTable = ObtieneDatos("SP_ArticulosGetAll", "P", EmpresaActual)
        Dim DT_PROD As DataTable = ObtieneDatos("sp_GetProductos_Forumlas", EmpresaActual, 0)
        RepositorySearchLook(cbItems, DT_PROD, "Nombre", "Codigo", 2, 3)

        SearchLookUp(cbFormula, db_Prod_CatMaestroFormula.Listar(0), "Descripción", "IdSysFormula", 0, 6, 7)
        Combo(TipoProducto, db_Prod_TipoProductos.Listar(0))
        Combo(cbEstado, db_Prod_EstadoProduccion.Listar(0))
        GetBodegasxUsuario(cbBodega, 0)
        GetBodegasxUsuario(Bodega, 0)
    End Sub

    Sub BackColorEstado()
        Try
            cbEstado.Properties.AppearanceReadOnly.BackColor = System.Drawing.ColorTranslator.FromHtml(cbEstado.GetColumnValue("Etiqueta"))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        'If Not DxValidationProvider1.Validate() Then Exit Sub

        If iVista.DataRowCount = 0 Then
            XtraMsg("Debe ingresar al menos 1 producto para crear esta formula.")
            Exit Sub
        End If
        '

        obj.IdSysProduccion = IdProduccion
        obj.Empresa = EmpresaActual
        obj.IdSysEstadoPRoduccion = IIf(cbEstado.EditValue Is Nothing, 1, cbEstado.EditValue)
        obj.FechaProduccion = dFecha.DateTime.Date
        obj.NumeroProduccion = IIf(IdProduccion = 0, db_Prod_Produccion.GetNumero(), Numero.Text)
        obj.IdSysFormula = cbFormula.EditValue
        obj.CantidadProducir = TxtAProducir.EditValue
        obj.CantidadRealProducida = TxtAProducir.EditValue
        obj.CostoProduccion = CDbl(iVista.Columns("Total").SummaryItem.SummaryValue)
        obj.Observaciones = txtObservaciones.Text
        obj.NoDocumento = txtNoDocumento.Text
        obj.Bodega = cbBodega.EditValue
        '

        '
        If IdProduccion = 0 Then
            ShowSplash("Guardando...")

            IdProduccion = db.Insertar(obj)

            ''********** Guardar Detalle    *****************************
            Dim _DT As DataTable = DT.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Unchanged)

            If Not _DT Is Nothing Then
                For i As Integer = 0 To _DT.Rows.Count - 1
                    obj_dtl.IdSysProduccion = IdProduccion
                    obj_dtl.IdSysArticulosFormula = cbFormula.EditValue
                    obj_dtl.EMPRESA = EmpresaActual
                    obj_dtl.TIPO = _DT.Rows.Item(i)("Tipo")
                    obj_dtl.CODIGO_ARTICULO = _DT.Rows.Item(i)("Producto")
                    obj_dtl.Unidad = IsNull(_DT.Rows.Item(i)("Und. Materia"), "")
                    obj_dtl.Presentacion = IsNull(_DT.Rows.Item(i)("Presentacion"), "")
                    obj_dtl.Cantidad = _DT.Rows.Item(i)("Cantidad")
                    obj_dtl.CantidadProduccion = _DT.Rows.Item(i)("A Producir")
                    obj_dtl.COSTO = _DT.Rows.Item(i)("Costo")
                    obj_dtl.CodTipoProd = IsNull(_DT.Rows.Item(i)("Tipo Producto"), 0)
                    obj_dtl.CODIGO_BODEGA = _DT.Rows.Item(i)("Bodega")
                    obj_dtl.Factor = _DT.Rows.Item(i)("Factor")
                    obj_dtl.Cantidad_Unidad = _DT.Rows.Item(i)("Base Producir")
                    obj_dtl.Unidad_Factor = IsNull(_DT.Rows.Item(i)("Unidad Base"), "")

                    db_dtl.Insertar(obj_dtl)
                Next
            End If
            '
            'Borrar Detalle de la Devolución
            obj_dev.IdProduccion = IdProduccion
            db_dev.Borrar(obj_dev)
            'Guardar Detalle de las Devoluciones
            Dim _DT_DEV As DataTable = DT_DEV.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Unchanged)
            If Not _DT_DEV Is Nothing Then
                For i As Integer = 0 To _DT_DEV.Rows.Count - 1
                    obj_dev.Tipo = _DT_DEV.Rows.Item(i)("Tipo")
                    obj_dev.Producto = _DT_DEV.Rows.Item(i)("Producto")
                    obj_dev.IdTipoProducto = IsNull(_DT_DEV.Rows.Item(i)("Tipo Producto"), 0)
                    obj_dev.Unidad = IsNull(_DT_DEV.Rows.Item(i)("Unidad"), "")
                    obj_dev.Presentacion = IsNull(_DT_DEV.Rows.Item(i)("Presentacion"), "")
                    obj_dev.Bodega = _DT_DEV.Rows.Item(i)("Bodega")
                    obj_dev.Cantidad = IsNull(_DT_DEV.Rows.Item(i)("Cantidad"), 0.00)
                    obj_dev.Costo = IsNull(_DT_DEV.Rows.Item(i)("Costo"), 0.00)

                    db_dev.Insertar(obj_dev)
                Next
            End If
            '
            HideSplash()
            '
            XtraMsg("La Orden de Producción se guardado con éxito!")
            db_Prod_Produccion.Imprimir(IdProduccion, cbEstado.GetColumnValue("Etiqueta"))
            '

            '  Dim cl As SysContab.ClConexion()            
            FrmProduccion.Cargar()
            Close()
        Else
            ShowSplash("Actualizando...")

            'Borrar Detalle de la Devolución
            obj_dev.IdProduccion = IdProduccion
            db_dev.Borrar(obj_dev)

            db.Actualizar(obj)  'Actualizar Encabezado

            If Not AgregarOtroProd Then

                'Actualizar registros modificados
                Dim _DT_UPD As DataTable = DT.GetChanges(DataRowState.Modified)

                If Not _DT_UPD Is Nothing Then
                    For i As Integer = 0 To _DT_UPD.Rows.Count - 1
                        obj_dtl.IdSysArticulosFormulaDetalle = _DT_UPD.Rows.Item(i)("IdDetalle")
                        obj_dtl.IdSysProduccion = IdProduccion
                        obj_dtl.IdSysArticulosFormula = cbFormula.EditValue
                        obj_dtl.EMPRESA = EmpresaActual
                        obj_dtl.TIPO = _DT_UPD.Rows.Item(i)("Tipo")
                        obj_dtl.CODIGO_ARTICULO = _DT_UPD.Rows.Item(i)("Producto")
                        obj_dtl.Unidad = IsNull(_DT_UPD.Rows.Item(i)("Und. Materia"), "")
                        obj_dtl.Presentacion = IsNull(_DT_UPD.Rows.Item(i)("Presentacion"), "")
                        obj_dtl.Cantidad = _DT_UPD.Rows.Item(i)("Cantidad")
                        obj_dtl.CantidadProduccion = _DT_UPD.Rows.Item(i)("A Producir")
                        obj_dtl.COSTO = _DT_UPD.Rows.Item(i)("Costo")
                        obj_dtl.CodTipoProd = IsNull(_DT_UPD.Rows.Item(i)("Tipo Producto"), 0)
                        obj_dtl.CODIGO_BODEGA = _DT_UPD.Rows.Item(i)("Bodega")
                        obj_dtl.Factor = _DT_UPD.Rows.Item(i)("Factor")
                        obj_dtl.Cantidad_Unidad = _DT_UPD.Rows.Item(i)("Base Producir")
                        obj_dtl.Unidad_Factor = IsNull(_DT_UPD.Rows.Item(i)("Unidad Base"), "")
                        '
                        db_dtl.Actualizar(obj_dtl)
                    Next
                End If
                '
                'Agregar Nuevos Registros
                Dim _DT_NEW As DataTable = DT.GetChanges(DataRowState.Added)
                If Not _DT_NEW Is Nothing Then
                    For i As Integer = 0 To _DT_NEW.Rows.Count - 1
                        obj_dtl.IdSysProduccion = IdProduccion
                        obj_dtl.IdSysArticulosFormula = cbFormula.EditValue
                        obj_dtl.EMPRESA = EmpresaActual
                        obj_dtl.TIPO = _DT_NEW.Rows.Item(i)("Tipo")
                        obj_dtl.CODIGO_ARTICULO = _DT_NEW.Rows.Item(i)("Producto")
                        obj_dtl.Unidad = IsNull(_DT_NEW.Rows.Item(i)("Und. Materia"), "")
                        obj_dtl.Presentacion = IsNull(_DT_NEW.Rows.Item(i)("Presentacion"), "")
                        obj_dtl.Cantidad = _DT_NEW.Rows.Item(i)("Cantidad")
                        obj_dtl.CantidadProduccion = _DT_NEW.Rows.Item(i)("A Producir")
                        obj_dtl.COSTO = _DT_NEW.Rows.Item(i)("Costo")
                        obj_dtl.CodTipoProd = IsNull(_DT_NEW.Rows.Item(i)("Tipo Producto"), 0)
                        obj_dtl.CODIGO_BODEGA = _DT_NEW.Rows.Item(i)("Bodega")
                        obj_dtl.Factor = _DT_NEW.Rows.Item(i)("Factor")
                        obj_dtl.Cantidad_Unidad = _DT_NEW.Rows.Item(i)("Base Producir")
                        obj_dtl.Unidad_Factor = IsNull(_DT_NEW.Rows.Item(i)("Unidad Base"), "")

                        db_dtl.Insertar(obj_dtl)
                    Next
                End If
                '
                'Borrrar Lineas
                Dim _DT_DEL As DataTable = DT.GetChanges(DataRowState.Deleted)
                If Not _DT_DEL Is Nothing Then
                    For i As Integer = 0 To _DT_DEL.Rows.Count - 1
                        obj_dtl.IdSysArticulosFormulaDetalle = _DT_DEL.Rows.Item(i)("IdDetalle", DataRowVersion.Original)
                        db_dtl.Borrar(obj_dtl)
                    Next
                End If
                '
                'Agregar Devoluciones
                Dim _DT_DEV As DataTable = DT_DEV.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Unchanged)
                If Not _DT_DEV Is Nothing Then
                    For i As Integer = 0 To _DT_DEV.Rows.Count - 1
                        obj_dev.Tipo = _DT_DEV.Rows.Item(i)("Tipo")
                        obj_dev.Producto = _DT_DEV.Rows.Item(i)("Producto")
                        obj_dev.IdTipoProducto = IsNull(_DT_DEV.Rows.Item(i)("Tipo Producto"), 0)
                        obj_dev.Unidad = IsNull(_DT_DEV.Rows.Item(i)("Unidad"), "")
                        obj_dev.Presentacion = IsNull(_DT_DEV.Rows.Item(i)("Presentacion"), "")
                        obj_dev.Bodega = _DT_DEV.Rows.Item(i)("Bodega")
                        obj_dev.Cantidad = IsNull(_DT_DEV.Rows.Item(i)("Cantidad"), 0.00)
                        obj_dev.Costo = IsNull(_DT_DEV.Rows.Item(i)("Costo"), 0.00)

                        db_dev.Insertar(obj_dev)
                    Next
                End If
            Else
                'BorrarDetalle de Produccion
                obj_dtl.IdSysProduccion = IdProduccion
                db_dtl.BorrarProduccion(obj_dtl)

                'Agregar la formula actualizada al detalle de produccion
                Dim _DT_NEW As DataTable = DT.GetChanges(DataRowState.Modified Or DataRowState.Unchanged)

                If Not _DT_NEW Is Nothing Then
                    For i As Integer = 0 To _DT_NEW.Rows.Count - 1
                        obj_dtl.IdSysProduccion = IdProduccion
                        obj_dtl.IdSysArticulosFormula = cbFormula.EditValue
                        obj_dtl.EMPRESA = EmpresaActual
                        obj_dtl.TIPO = _DT_NEW.Rows.Item(i)("Tipo")
                        obj_dtl.CODIGO_ARTICULO = _DT_NEW.Rows.Item(i)("Producto")
                        obj_dtl.Unidad = IsNull(_DT_NEW.Rows.Item(i)("Und. Materia"), "")
                        obj_dtl.Presentacion = IsNull(_DT_NEW.Rows.Item(i)("Presentacion"), "")
                        obj_dtl.Cantidad = _DT_NEW.Rows.Item(i)("Cantidad")
                        obj_dtl.CantidadProduccion = _DT_NEW.Rows.Item(i)("A Producir")
                        obj_dtl.COSTO = _DT_NEW.Rows.Item(i)("Costo")
                        obj_dtl.CodTipoProd = IsNull(_DT_NEW.Rows.Item(i)("Tipo Producto"), 0)
                        obj_dtl.CODIGO_BODEGA = _DT_NEW.Rows.Item(i)("Bodega")
                        obj_dtl.Factor = _DT_NEW.Rows.Item(i)("Factor")
                        obj_dtl.Cantidad_Unidad = _DT_NEW.Rows.Item(i)("Base Producir")
                        obj_dtl.Unidad_Factor = IsNull(_DT_NEW.Rows.Item(i)("Unidad Base"), "")

                        db_dtl.Insertar(obj_dtl)
                    Next
                End If
                '
                'Agregar Devoluciones
                Dim _DT_DEV As DataTable = DT_DEV.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Unchanged)
                If Not _DT_DEV Is Nothing Then
                    For i As Integer = 0 To _DT_DEV.Rows.Count - 1
                        obj_dev.Tipo = _DT_DEV.Rows.Item(i)("Tipo")
                        obj_dev.Producto = _DT_DEV.Rows.Item(i)("Producto")
                        obj_dev.IdTipoProducto = IsNull(_DT_DEV.Rows.Item(i)("Tipo Producto"), 0)
                        obj_dev.Unidad = IsNull(_DT_DEV.Rows.Item(i)("Unidad"), "")
                        obj_dev.Presentacion = IsNull(_DT_DEV.Rows.Item(i)("Presentacion"), "")
                        obj_dev.Bodega = _DT_DEV.Rows.Item(i)("Bodega")
                        obj_dev.Cantidad = IsNull(_DT_DEV.Rows.Item(i)("Cantidad"), 0.00)
                        obj_dev.Costo = IsNull(_DT_DEV.Rows.Item(i)("Costo"), 0.00)

                        db_dev.Insertar(obj_dev)
                    Next
                End If
            End If

        HideSplash()
        ' 
        XtraMsg("La Orden de Producción actualizada con éxito!")
        '
        FrmProduccion.Cargar()
        Close()
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles bActualizar.Click
        ShowSplash("Actualizando Costos...")
        For i As Integer = 0 To iVista.DataRowCount - 1
            Dim Costo As Double = GetCostoPromedioProducto(IsNull(iVista.GetRowCellValue(i, "Producto"), ""), _
                                                           IsNull(iVista.GetRowCellValue(i, "Tipo"), "P"), _
                                                           IsNull(iVista.GetRowCellValue(i, "Bodega"), "0"))

            iVista.SetRowCellValue(i, "Costo", Costo)
            iVista.SetRowCellValue(i, "Total", Math.Round(IsNull(iVista.GetRowCellValue(i, "A Producir"), 0.0) * Costo, 6))
        Next
        iVista.RefreshData()
        iVista.UpdateTotalSummary()
        TotalCosto()
        TotalBase()
        HideSplash()
    End Sub

    Sub TotalCosto()
        'lblCostoProduccion.Text = "Total Costo de Producción = " & CDbl(iVista.Columns("Total").SummaryItem.SummaryValue).ToString("n2")
        Dim TotalCosto As Double = 0
        If DT.Rows.Count > 0 Then
            Dim dr() As DataRow = DT.Select("Tipo = 'P'")
            If dr.Length > 0 Then
                lblCostoProduccion.Text = "Total Costo de Producción = " & CDbl(DT.Compute("SUM(Total)", "Tipo = 'P'")).ToString("n2")
                TotalCosto = CDbl(DT.Compute("SUM(Total)", "Tipo = 'P'"))
            Else
                lblCostoProduccion.Text = "Total Costo de Producción = 0.00"
            End If
        Else
                lblCostoProduccion.Text = "Total Costo de Producción = 0.00"
        End If
        '
        If DT_DEV.Rows.Count > 0 Then
            Dim dr() As DataRow = DT_DEV.Select("Tipo = 'P'")
            If dr.Length > 0 Then
                TotalCosto = TotalCosto + CDbl(DT_DEV.Compute("SUM(Total)", "Tipo = 'P'"))
                lblCostoProduccion.Text = "Total Costo de Producción = " & TotalCosto.ToString("n2")
            End If
        End If
    End Sub

    Sub TotalBase()
        Dim Cantidad As Double = 0.00

        If DT.Rows.Count > 0 Then
            Dim dr() As DataRow = DT.Select("[Tipo Producto] = 1")
            If dr.Length > 0 Then
                lblCantidad.Text = "Cantidad Base = " & CDbl(DT.Compute("SUM([Cantidad Base])", "[Tipo Producto] = 1")).ToString("n2")
                lblBase.Text = "Base a Producir = " & CDbl(DT.Compute("SUM([Base Producir])", "[Tipo Producto] = 1")).ToString("n2")
                '
                Cantidad = CDbl(DT.Compute("SUM([Base Producir])", "[Tipo Producto] = 1"))
            Else
                lblCantidad.Text = "Cantidad Base = 0.00"
                lblBase.Text = "Base a Producir = 0.00"
            End If
        Else
            lblCantidad.Text = "Cantidad Base = 0.00"
            lblBase.Text = "Base a Producir = 0.00"
        End If

        If DT_DEV.Rows.Count > 0 Then
            Dim dr() As DataRow = DT_DEV.Select("[Tipo Producto] = 1")
            If dr.Length > 0 Then
                Cantidad = Cantidad + CDbl(DT_DEV.Compute("SUM(Cantidad)", "[Tipo Producto] = 1"))
                lblBase.Text = "Base a Producir = " & Cantidad.ToString("n2")
            End If
        End If



        'Dim TotalCantidad As Double = 0

        'For i As Integer = 0 To iVista.DataRowCount - 1
        '    If iVista.GetRowCellValue(i, "Tipo Producto") = 1 Then
        '        TotalCantidad += iVista.GetRowCellValue(i, "A Producir")
        '    End If
        'Next
        '' TotalCantidad = TotalCantidad * TxtAProducir.EditValue

        'lblBase.Text = "Base a Producir = " & TotalCantidad.ToString("n2")
    End Sub


    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub cbProducto_EditValueChanged(sender As Object, e As EventArgs) Handles cbFormula.EditValueChanged
        DatosProducto()
    End Sub

    Sub DatosProducto()
        Try
            If cbFormula.EditValue Is Nothing Then
                UndMedida.Text = ""
                UndPresentacion.Text = ""
            Else
                'Dim DR As DataRowView = cbFormula.Properties.GetRowByKeyValue(cbFormula.EditValue)
                ''
                'UndMedida.Text = DR.Item("Unidad")
                'UndPresentacion.Text = DR.Item("Presentacion")

                Dim DetalleFormula As New Prod_CatMaestroFormula
                DetalleFormula = db_Prod_CatMaestroFormula.Detalles(cbFormula.EditValue)

                Dim DetalleProducto As New Prod_CatalogoProductos
                DetalleProducto = db_Prod_CatalogoProductos.Detalles(DetalleFormula.CODIGO_ARTICULO)

                UndMedida.Text = DetalleProducto.Unidad
                UndPresentacion.Text = DetalleProducto.Presentacion

                If Not Inicio Then CargarDetalleFormula()
                If Not Inicio Then ActualizarCantidaAProducir()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub iVista_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles iVista.CellValueChanged
        'If e.Column.FieldName = "Producto" Then

        '    If DT.Compute("Count(Producto)", "Producto = '" & e.Value & "'") >= 1 Then
        '        XtraMsg("Este producto ya existe en la lista", MessageBoxIcon.Error)
        '        iVista.DeleteRow(iVista.FocusedRowHandle)
        '    End If

        '    Dim DR As DataRowView = cbItems.GetRowByKeyValue(e.Value)

        '    iVista.SetRowCellValue(e.RowHandle, "Tipo", DR.Item("Tipo"))
        '    iVista.SetRowCellValue(e.RowHandle, "Unidad", DR.Item("Unidad"))
        '    iVista.SetRowCellValue(e.RowHandle, "Presentacion", DR.Item("Presentacion"))
        'End If
        '
        'If e.Column.FieldName = "A Producir" Then
        '    iVista.SetRowCellValue(e.RowHandle, "Base Producir", Math.Round(e.Value / IsNull(iVista.GetRowCellValue(e.RowHandle, "Factor"), 1.0), 6))
        '    iVista.SetRowCellValue(e.RowHandle, "Total", Math.Round(IsNull(iVista.GetRowCellValue(e.RowHandle, "Costo"), 0.0) * e.Value, 6))
        '    '
        '    TotalCosto()
        'End If
        ''
        'If e.Column.FieldName = "Base Producir" Then
        '    iVista.SetRowCellValue(e.RowHandle, "A Producir", Math.Round(e.Value * IsNull(iVista.GetRowCellValue(e.RowHandle, "Factor"), 1.0), 6))
        '    iVista.SetRowCellValue(e.RowHandle, "Total", Math.Round(IsNull(iVista.GetRowCellValue(e.RowHandle, "Costo"), 0.0) * IsNull(iVista.GetRowCellValue(e.RowHandle, "A Producir"), 0.0), 6))
        '    '
        '    TotalCosto()
        'End If
        '
        'If e.Column.FieldName = "A Producir" Or _
        '    e.Column.FieldName = "Base Producir" Or _
        '    e.Column.FieldName = "Bodega" Then

        '    Dim Costo As Double = GetCostoPromedioProducto(IsNull(iVista.GetRowCellValue(e.RowHandle, "Producto"), ""), _
        '                                                   IsNull(iVista.GetRowCellValue(e.RowHandle, "Tipo"), "P"), _
        '                                                   IsNull(iVista.GetRowCellValue(e.RowHandle, "Bodega"), "0"))


        '    'If e.Column.FieldName = "A Producir" Then iVista.SetRowCellValue(e.RowHandle, "Base Producir", Math.Round(e.Value / IsNull(iVista.GetRowCellValue(e.RowHandle, "Factor"), 1.0), 6))
        '    'If e.Column.FieldName = "Base Producir" Then iVista.SetRowCellValue(e.RowHandle, "A Producir", Math.Round(e.Value * IsNull(iVista.GetRowCellValue(e.RowHandle, "Factor"), 1.0), 6))

        '    iVista.SetRowCellValue(e.RowHandle, "Costo", Costo)
        '    iVista.SetRowCellValue(e.RowHandle, "Total", Math.Round(IsNull(iVista.GetRowCellValue(e.RowHandle, "A Producir"), 0.0) * Costo, 6))
        'End If

        'If e.Column.FieldName = "Base Producir" Then

        'End If

    End Sub

    Private Sub iVista_KeyDown(sender As Object, e As KeyEventArgs) Handles iVista.KeyDown
        'If iVista.FocusedRowHandle < 0 Then Exit Sub

        'If e.KeyCode = Keys.Delete Then
        '    iVista.DeleteSelectedRows()
        '    iVista.RefreshData()
        'End If
    End Sub

    Private Sub iVista_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles iVista.RowUpdated
        TotalCosto()
        TotalBase()
    End Sub

    Private Sub iVista_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles iVista.ValidateRow
        If IsDBNull(iVista.GetRowCellValue(e.RowHandle, "Bodega")) Or _
            IsDBNull(iVista.GetRowCellValue(e.RowHandle, "Cantidad")) Or _
            IsDBNull(iVista.GetRowCellValue(e.RowHandle, "Base Producir")) Or _
            IsDBNull(iVista.GetRowCellValue(e.RowHandle, "A Producir")) Then
            e.ErrorText = "Complete la informacion" & vbCrLf
            e.Valid = False
        End If
    End Sub

    Sub CargarDetalleFormula()
        'Cargar Detalle de la formula
        DT = db_Prod_CatDetalleFormula.Listar(cbFormula.EditValue)
        iGrid.DataSource = DT
        iVista.PopulateColumns()

        FormatoGrid(iVista, 6, 0, False, True, False)

        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
        Next

        iVista.Columns("Base Producir").OptionsColumn.AllowEdit = True
        iVista.Columns("A Producir").OptionsColumn.AllowEdit = True
        iVista.Columns("Tipo Producto").OptionsColumn.AllowEdit = True
        'iVista.Columns("Bodega").OptionsColumn.AllowEdit = True
        '
        iVista.Columns("IdDetalle").Visible = False
        iVista.Columns("IdFormula").Visible = False
        iVista.Columns("IdProduccion").Visible = False
        iVista.Columns("Tipo").Visible = False
        iVista.Columns("Presentacion").Visible = False
        iVista.Columns("Cantidad").Visible = False

        iVista.Columns("Producto").ColumnEdit = cbItems
        iVista.Columns("Tipo Producto").ColumnEdit = TipoProducto
        iVista.Columns("Bodega").ColumnEdit = Bodega
        iVista.Columns("Cantidad").ColumnEdit = txtCantidad
        iVista.Columns("Cantidad Base").ColumnEdit = txtCantidad
        iVista.Columns("Base Producir").ColumnEdit = txtCantidad
        iVista.Columns("A Producir").ColumnEdit = txtCantidad    
        iVista.Columns("Costo").ColumnEdit = txtCantidad
        iVista.Columns("Total").ColumnEdit = txtCantidad
        'iVista.Columns("Producto").Width = 250

        iVista.BestFitColumns()
        TotalCosto()
        TotalBase()
    End Sub

    Private Sub TxtAProducir_EditValueChanged(sender As Object, e As EventArgs) Handles TxtAProducir.EditValueChanged
        If Not Inicio Then ActualizarCantidaAProducir()
    End Sub

    Sub ActualizarCantidaAProducir()
        ShowSplash("Actualizando Cantidades...")
        For i As Integer = 0 To iVista.DataRowCount - 1

            ' iVista.SetRowCellValue(i, "Base Producir", Math.Round((IsNull(iVista.GetRowCellValue(i, "A Producir"), 0.0) / IsNull(iVista.GetRowCellValue(i, "Factor"), 1.0)) / 100, 6))
            'iVista.SetRowCellValue(i, "Base Producir", Math.Round(((IsNull(iVista.GetRowCellValue(i, "Cantidad Base"), 0.0) * IsNull(iVista.GetRowCellValue(i, "Factor"), 1.0)) * TxtAProducir.EditValue) / 100.0, 6))
            If IsNull(iVista.GetRowCellValue(i, "Factor"), 1.0) = 1 Then
                iVista.SetRowCellValue(i, "Base Producir", Math.Round((IsNull(iVista.GetRowCellValue(i, "Cantidad"), 0.0) * TxtAProducir.EditValue), 6))
                iVista.SetRowCellValue(i, "A Producir", Math.Round((IsNull(iVista.GetRowCellValue(i, "Cantidad"), 0.0) * TxtAProducir.EditValue), 6))
            Else
                iVista.SetRowCellValue(i, "Base Producir", Math.Round(((IsNull(iVista.GetRowCellValue(i, "Cantidad Base"), 0.0) * TxtAProducir.EditValue) / 100.0), 6))
                iVista.SetRowCellValue(i, "A Producir", Math.Round((IsNull(iVista.GetRowCellValue(i, "Cantidad"), 0.0) * TxtAProducir.EditValue), 6))
            End If
            iVista.SetRowCellValue(i, "Total", Math.Round(IsNull(iVista.GetRowCellValue(i, "A Producir"), 0.0) * IsNull(iVista.GetRowCellValue(i, "Costo"), 0.0), 6))
        Next
        iVista.RefreshData()
        iVista.UpdateTotalSummary()
        TotalCosto()
        TotalBase()
        HideSplash()
    End Sub

    Private Sub iVistaDev_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles iVistaDev.CellValueChanged
        If e.Column.FieldName = "Producto" Then
            With iVistaDev
                If DT_DEV.Compute("Count(Producto)", "Producto = '" & e.Value & "'") >= 1 Then
                    XtraMsg("Este producto ya existe en la lista", MessageBoxIcon.Error)
                    .DeleteRow(.FocusedRowHandle)
                End If

                Dim DR As DataRowView = cbItems.GetRowByKeyValue(e.Value)

                .SetRowCellValue(e.RowHandle, "Tipo", DR.Item("Tipo"))
                .SetRowCellValue(e.RowHandle, "Unidad", DR.Item("Unidad"))
                .SetRowCellValue(e.RowHandle, "Presentacion", DR.Item("Presentacion"))
                .SetRowCellValue(e.RowHandle, "Cantidad", 1.0)
            End With
        End If
        '
        If e.Column.FieldName = "Cantidad" Or
         e.Column.FieldName = "Bodega" Then
            With iVistaDev
                Dim Costo As Double = GetCostoPromedioProducto(IsNull(.GetRowCellValue(e.RowHandle, "Producto"), ""),
                                                           IsNull(.GetRowCellValue(e.RowHandle, "Tipo"), "P"),
                                                           IsNull(.GetRowCellValue(e.RowHandle, "Bodega"), "0"))

                .SetRowCellValue(e.RowHandle, "Costo", Costo)
                .SetRowCellValue(e.RowHandle, "Total", Math.Round(IsNull(.GetRowCellValue(e.RowHandle, "Cantidad"), 0.0) * Costo, 6))
            End With
        End If
    End Sub

    Private Sub iVistaDev_KeyDown(sender As Object, e As KeyEventArgs) Handles iVistaDev.KeyDown
        If iVistaDev.FocusedRowHandle < 0 Then Exit Sub
        '
        If e.KeyCode = Keys.Delete Then
            iVistaDev.DeleteSelectedRows()
            iVistaDev.RefreshData()
        End If
    End Sub

    Private Sub iVistaDev_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles iVistaDev.RowUpdated
        TotalCosto()
        TotalBase()
    End Sub
End Class