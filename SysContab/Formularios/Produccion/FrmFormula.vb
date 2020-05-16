Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class FrmFormula

    Dim obj As New Prod_CatMaestroFormula
    Dim db As New db_Prod_CatMaestroFormula

    Dim obj_dtl As New Prod_CatDetalleFormula
    Dim db_dtl As New db_Prod_CatDetalleFormula

    Public IdFormula As Integer = 0
    Dim DT As DataTable, Tipo As String = "P"

    Private Sub FrmFormula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        '
        If IdFormula <> 0 Then
            obj = db_Prod_CatMaestroFormula.Detalles(IdFormula)

            If Not obj Is Nothing Then
                cbProducto.EditValue = obj.CODIGO_ARTICULO
                Numero.Text = obj.Numero
                '
                DatosProducto()
                txtDescripcion.Text = obj.Descripcion
            End If

            bGuardarNueva.Enabled = True
        Else
            Numero.Text = db_Prod_CatMaestroFormula.GetNumero()
        End If
        '
        'Cargar Detalle de la formula
        DT = db_Prod_CatDetalleFormula.Listar(IdFormula)
        iGrid.DataSource = DT
        iVista.PopulateColumns()
        FormatoGrid2(iVista, 6, 0, False, True, False)

        iVista.Columns("Cantidad").OptionsColumn.AllowEdit = False
        iVista.Columns("Total").OptionsColumn.AllowEdit = False
        iVista.Columns("Total").OptionsColumn.AllowFocus = False
        iVista.Columns("Costo").OptionsColumn.AllowEdit = False
        iVista.Columns("Und. Materia").OptionsColumn.AllowEdit = False
        '
        iVista.Columns("IdDetalle").Visible = False
        iVista.Columns("IdFormula").Visible = False
        iVista.Columns("IdProduccion").Visible = False
        iVista.Columns("Tipo").Visible = False
        'iVista.Columns("Cantidad Producción").Visible = False
        iVista.Columns("Base Producir").Visible = False
        iVista.Columns("A Producir").Visible = False
        iVista.Columns("Presentacion").Visible = False
        iVista.Columns("Costo").Visible = False
        iVista.Columns("Total").Visible = False

        iVista.Columns("Und. Materia").ColumnEdit = cbUnidad
        iVista.Columns("Unidad Base").ColumnEdit = cbUnidadProduccion

        iVista.Columns("Producto").ColumnEdit = cbItems
        iVista.Columns("Tipo Producto").ColumnEdit = TipoProducto
        iVista.Columns("Bodega").ColumnEdit = Bodega
        iVista.Columns("Cantidad").ColumnEdit = txtCantidad
        iVista.Columns("Cantidad Base").ColumnEdit = txtCantidad
        iVista.Columns("Costo").ColumnEdit = txtCantidad
        iVista.Columns("Total").ColumnEdit = txtCantidad
        'iVista.Columns("Producto").Width = 250

        iVista.BestFitColumns()
        TotalCosto()
        TotalBase()
    End Sub

    Sub CargarCombos()
        Dim DT_PROD As DataTable = ObtieneDatos("sp_GetProductos_Forumlas", EmpresaActual, 0)
        Dim DT_UND As DataTable = db_UnidadesMedida.Listar(0)

        SearchLookUp(cbProducto, DT_PROD, "Nombre", "Codigo", 2, 3)
        RepositorySearchLook(cbItems, DT_PROD, "Nombre", "Codigo", 2, 3)

        RepositoryItemLookUpEdit(cbUnidad, DT_UND, "Unidad", "Unidad", 0)
        RepositoryItemLookUpEdit(cbUnidadProduccion, DT_UND, "Unidad", "Unidad", 0)

        'SearchLookUp(cbFormula, db_Prod_CatMaestroFormula.Listar(1), "Nombre", "IdFormula")
        Combo(TipoProducto, db_Prod_TipoProductos.Listar(0))
        GetBodegasxUsuario(Bodega, 0)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If cbProducto.EditValue Is Nothing Then
            XtraMsg("Seleccione el producto para crear su formula")
            cbProducto.Focus()
            Exit Sub
        End If
        '
        If iVista.DataRowCount = 0 Then
            XtraMsg("Debe ingresar al menos 1 producto para crear esta formula.")
            Exit Sub
        End If
        '
        obj.IdSysFormula = IdFormula
        obj.EMPRESA = EmpresaActual
        obj.TIPO = Tipo
        obj.CODIGO_ARTICULO = cbProducto.EditValue
        obj.Numero = IIf(IdFormula = 0, db_Prod_CatMaestroFormula.GetNumero(), Numero.Text)
        obj.Descripcion = txtDescripcion.Text

        If IdFormula = 0 Then
            ShowSplash("Guardando...")

            IdFormula = db.Insertar(obj)

            ''********** Guardar Detalle    *****************************
            Dim _DT As DataTable = DT.GetChanges(DataRowState.Added Or DataRowState.Modified)

            If Not _DT Is Nothing Then
                For i As Integer = 0 To _DT.Rows.Count - 1
                    obj_dtl.IdSysArticulosFormula = IdFormula
                    obj_dtl.EMPRESA = EmpresaActual
                    obj_dtl.TIPO = _DT.Rows.Item(i)("Tipo")
                    obj_dtl.CODIGO_ARTICULO = _DT.Rows.Item(i)("Producto")
                    obj_dtl.Unidad = IsNull(_DT.Rows.Item(i)("Und. Materia"), "")
                    obj_dtl.Presentacion = IsNull(_DT.Rows.Item(i)("Presentacion"), "")
                    obj_dtl.Cantidad = _DT.Rows.Item(i)("Cantidad")                    
                    obj_dtl.CodTipoProd = IsNull(_DT.Rows.Item(i)("Tipo Producto"), 0)
                    obj_dtl.CODIGO_BODEGA = _DT.Rows.Item(i)("Bodega")
                    obj_dtl.Costo = _DT.Rows.Item(i)("Costo")
                    obj_dtl.Factor = IsNull(_DT.Rows.Item(i)("Factor"), 1.0)
                    obj_dtl.Cantidad_Unidad = IsNull(_DT.Rows.Item(i)("Cantidad Base"), 1.0)
                    obj_dtl.Unidad_Factor = IsNull(_DT.Rows.Item(i)("Unidad Base"), "")

                    db_dtl.Insertar(obj_dtl)
                Next
            End If
            HideSplash()
            '
            XtraMsg("La Formula se ha guardado con éxito!")
            '
            FrmFormulaList.Cargar()
            Close()
        Else
            ShowSplash("Actualizando...")

            db.Actualizar(obj)  'Actualizar Encabezado

            'Actualizar registros modificados
            Dim _DT_UPD As DataTable = DT.GetChanges(DataRowState.Modified)

            If Not _DT_UPD Is Nothing Then
                For i As Integer = 0 To _DT_UPD.Rows.Count - 1
                    obj_dtl.IdSysArticulosFormulaDetalle = _DT_UPD.Rows.Item(i)("IdDetalle")
                    obj_dtl.IdSysArticulosFormula = IdFormula
                    obj_dtl.EMPRESA = EmpresaActual
                    obj_dtl.TIPO = _DT_UPD.Rows.Item(i)("Tipo")
                    obj_dtl.CODIGO_ARTICULO = _DT_UPD.Rows.Item(i)("Producto")
                    obj_dtl.Unidad = IsNull(_DT_UPD.Rows.Item(i)("Und. Materia"), "")
                    obj_dtl.Presentacion = IsNull(_DT_UPD.Rows.Item(i)("Presentacion"), "")
                    obj_dtl.Cantidad = _DT_UPD.Rows.Item(i)("Cantidad")
                    obj_dtl.CodTipoProd = IsNull(_DT_UPD.Rows.Item(i)("Tipo Producto"), 0)
                    obj_dtl.CODIGO_BODEGA = _DT_UPD.Rows.Item(i)("Bodega")
                    obj_dtl.Costo = _DT_UPD.Rows.Item(i)("Costo")
                    obj_dtl.Factor = IsNull(_DT_UPD.Rows.Item(i)("Factor"), 1.0)
                    obj_dtl.Cantidad_Unidad = IsNull(_DT_UPD.Rows.Item(i)("Cantidad Base"), 1.0)
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
                    obj_dtl.IdSysArticulosFormula = IdFormula
                    obj_dtl.EMPRESA = EmpresaActual
                    obj_dtl.TIPO = _DT_NEW.Rows.Item(i)("Tipo")
                    obj_dtl.CODIGO_ARTICULO = _DT_NEW.Rows.Item(i)("Producto")
                    obj_dtl.Unidad = IsNull(_DT_NEW.Rows.Item(i)("Und. Materia"), "")
                    obj_dtl.Presentacion = IsNull(_DT_NEW.Rows.Item(i)("Presentacion"), "")
                    obj_dtl.Cantidad = _DT_NEW.Rows.Item(i)("Cantidad")                    
                    obj_dtl.CodTipoProd = IsNull(_DT_NEW.Rows.Item(i)("Tipo Producto"), 0)
                    obj_dtl.CODIGO_BODEGA = _DT_NEW.Rows.Item(i)("Bodega")
                    obj_dtl.Costo = _DT_NEW.Rows.Item(i)("Costo")
                    obj_dtl.Factor = IsNull(_DT_NEW.Rows.Item(i)("Factor"), 1.0)
                    obj_dtl.Cantidad_Unidad = IsNull(_DT_NEW.Rows.Item(i)("Cantidad Base"), 1.0)
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

            HideSplash()
            ' 
            XtraMsg("Información actualizada con éxito!")
            '
            FrmFormulaList.Cargar()
            Close()
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        ShowSplash("Actualizando Costos...")
        For i As Integer = 0 To iVista.DataRowCount - 1
            Dim Costo As Double = GetCostoPromedioProducto(IsNull(iVista.GetRowCellValue(i, "Producto"), ""), _
                                                           IsNull(iVista.GetRowCellValue(i, "Tipo"), "P"), _
                                                           IsNull(iVista.GetRowCellValue(i, "Bodega"), "0"))

            iVista.SetRowCellValue(i, "Costo", Costo)
            iVista.SetRowCellValue(i, "Total", Math.Round(IsNull(iVista.GetRowCellValue(i, "Cantidad"), 0.0) * Costo, 6))
        Next
        '
        iVista.RefreshData()
        iVista.UpdateTotalSummary()
        TotalCosto()
        TotalBase()
        HideSplash()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub cbProducto_EditValueChanged(sender As Object, e As EventArgs) Handles cbProducto.EditValueChanged
        DatosProducto()
    End Sub

    Sub DatosProducto()
        Try
            If cbProducto.EditValue Is Nothing Then
                UndMedida.Text = ""
                UndPresentacion.Text = ""
                txtDescripcion.Text = ""
            Else
                Dim DetalleProducto As New Prod_CatalogoProductos
                DetalleProducto = db_Prod_CatalogoProductos.Detalles(cbProducto.EditValue)
                UndMedida.Text = DetalleProducto.Unidad
                UndPresentacion.Text = DetalleProducto.Presentacion
                txtDescripcion.Text = DetalleProducto.Nombre

                'If txtDescripcion.Text.Trim.Length = 0 Then txtDescripcion.Text = DetalleProducto.Nombre
                'Dim DR As DataRowView = cbProducto.Properties.GetRowByKeyValue(cbProducto.EditValue)
                'UndMedida.Text = DR.Item("Unidad")
                'UndPresentacion.Text = DR.Item("Presentacion")
            End If
        Catch ex As Exception
        End Try
      
    End Sub

    Private Sub iVista_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles iVista.CellValueChanged
        If e.Column.FieldName = "Producto" Then

            If DT.Compute("Count(Producto)", "Producto = '" & e.Value & "'") >= 1 Then
                XtraMsg("Este producto ya existe en la lista", MessageBoxIcon.Error)
                iVista.DeleteRow(iVista.FocusedRowHandle)
            End If

            Dim DR As DataRowView = cbItems.GetRowByKeyValue(e.Value)

            iVista.SetRowCellValue(e.RowHandle, "Tipo", DR.Item("Tipo"))
            iVista.SetRowCellValue(e.RowHandle, "Und. Materia", DR.Item("Unidad"))
            iVista.SetRowCellValue(e.RowHandle, "Unidad Base", DR.Item("Unidad"))
            iVista.SetRowCellValue(e.RowHandle, "Presentacion", DR.Item("Presentacion"))
            iVista.SetRowCellValue(e.RowHandle, "Cantidad", 1.0)
            iVista.SetRowCellValue(e.RowHandle, "Factor", 1.0)
            iVista.SetRowCellValue(e.RowHandle, "Cantidad Base", 1.0)
        End If
        '
        If e.Column.FieldName = "Cantidad Base" Or _
            e.Column.FieldName = "Factor" Then
            iVista.SetRowCellValue(e.RowHandle, "Cantidad", Math.Round(IsNull(iVista.GetRowCellValue(e.RowHandle, "Cantidad Base"), 1.0) * IsNull(iVista.GetRowCellValue(e.RowHandle, "Factor"), 1.0), 6))
        End If
        '
        If e.Column.FieldName = "Cantidad" Or _
           e.Column.FieldName = "Bodega" Then

            Dim Costo As Double = GetCostoPromedioProducto(IsNull(iVista.GetRowCellValue(e.RowHandle, "Producto"), ""), _
                                                           IsNull(iVista.GetRowCellValue(e.RowHandle, "Tipo"), "P"), _
                                                           IsNull(iVista.GetRowCellValue(e.RowHandle, "Bodega"), "0"))

            iVista.SetRowCellValue(e.RowHandle, "Costo", Costo)
            iVista.SetRowCellValue(e.RowHandle, "Total", Math.Round(IsNull(iVista.GetRowCellValue(e.RowHandle, "Cantidad"), 0.0) * Costo, 6))
        End If
    End Sub

    Private Sub iVista_KeyDown(sender As Object, e As KeyEventArgs) Handles iVista.KeyDown
        If iVista.FocusedRowHandle < 0 Then Exit Sub

        If e.KeyCode = Keys.Delete Then
            iVista.DeleteSelectedRows()
            iVista.RefreshData()
            '
            TotalCosto()
            TotalBase()
        End If
    End Sub

    Private Sub iVista_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles iVista.RowUpdated
        TotalCosto()
        TotalBase()
    End Sub


    Sub TotalCosto()
        'lblCostoProduccion.Text = "Total Costo de Producción = " & CDbl(iVista.Columns("Total").SummaryItem.SummaryValue).ToString("n2")
        If DT.Rows.Count > 0 Then
            Dim dr() As DataRow = DT.Select("Tipo = 'P'")
            If dr.Length > 0 Then lblCostoProduccion.Text = "Total Costo de Producción = " & CDbl(DT.Compute("SUM(Total)", "Tipo = 'P'")).ToString("n2")
            If dr.Length = 0 Then lblCostoProduccion.Text = "Total Costo de Producción = 0.00"
        Else
                lblCostoProduccion.Text = "Total Costo de Producción = 0.00"
        End If
    End Sub

    Sub TotalBase()
        'Dim TotalCantidad As Double = 0

        'For i As Integer = 0 To iVista.DataRowCount - 1
        '    If iVista.GetRowCellValue(i, "Tipo Producto") = 1 Then
        '        TotalCantidad += iVista.GetRowCellValue(i, "Cantidad Base")
        '    End If
        'Next
        'lblBase.Text = "Base a Producir = " & TotalCantidad.ToString("n2")

        If DT.Rows.Count > 0 Then
            Dim dr() As DataRow = DT.Select("[Tipo Producto] = 1")
            If dr.Length > 0 Then
                lblCantidad.Text = "Cantidad = " & CDbl(DT.Compute("SUM(Cantidad)", "[Tipo Producto] = 1")).ToString("n2")
                lblBase.Text = "Base a Producir = " & CDbl(DT.Compute("SUM([Cantidad Base])", "[Tipo Producto] = 1")).ToString("n2")
            Else
                lblCantidad.Text = "Cantidad = 0.00"
                lblBase.Text = "Base a Producir = 0.00"
            End If
        Else
            lblCantidad.Text = "Cantidad = 0.00"
            lblBase.Text = "Base a Producir = 0.00"
        End If
    End Sub

    Private Sub iVista_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles iVista.ValidateRow
        If IsDBNull(iVista.GetRowCellValue(e.RowHandle, "Bodega")) Or _
            IsDBNull(iVista.GetRowCellValue(e.RowHandle, "Cantidad")) Or _
            IsDBNull(iVista.GetRowCellValue(e.RowHandle, "Factor")) Or _
            IsDBNull(iVista.GetRowCellValue(e.RowHandle, "Cantidad Base")) Or _
            IsDBNull(iVista.GetRowCellValue(e.RowHandle, "Unidad Base")) Then
            e.ErrorText = "Complete la informacion" & vbCrLf
            e.Valid = False
            '
        End If
    End Sub

    'Sub CargarDetalleFormula()
    '    'Cargar Detalle de la formula
    '    DT = db_Prod_CatDetalleFormula.Listar(cbProducto.EditValue)
    '    iGrid.DataSource = DT
    '    iVista.PopulateColumns()
    '    FormatoGrid(iVista, 6, 0, False, True, False)
    '    iVista.Columns("Total").OptionsColumn.AllowEdit = False
    '    iVista.Columns("Total").OptionsColumn.AllowFocus = False
    '    iVista.Columns("Costo").OptionsColumn.AllowEdit = False
    '    '
    '    iVista.Columns("IdDetalle").Visible = False
    '    iVista.Columns("IdFormula").Visible = False
    '    iVista.Columns("Tipo").Visible = False

    '    iVista.Columns("Producto").ColumnEdit = cbItems
    '    iVista.Columns("Tipo Producto").ColumnEdit = TipoProducto
    '    iVista.Columns("Bodega").ColumnEdit = Bodega
    '    iVista.Columns("Cantidad").ColumnEdit = txtCantidad
    '    iVista.Columns("Costo").ColumnEdit = txtCantidad
    '    iVista.Columns("Total").ColumnEdit = txtCantidad
    'End Sub

    Private Sub bGuardarNueva_Click(sender As Object, e As EventArgs) Handles bGuardarNueva.Click
        If cbProducto.EditValue Is Nothing Then
            XtraMsg("Seleccione el producto para crear su formula")
            cbProducto.Focus()
            Exit Sub
        End If
        '
        If iVista.DataRowCount = 0 Then
            XtraMsg("Debe ingresar al menos 1 producto para crear esta formula.")
            Exit Sub
        End If
        '
        obj.IdSysFormula = IdFormula
        obj.EMPRESA = EmpresaActual
        obj.TIPO = Tipo
        obj.CODIGO_ARTICULO = cbProducto.EditValue
        obj.Numero = db_Prod_CatMaestroFormula.GetNumero()

        ShowSplash("Guardando...")
        IdFormula = db.Insertar(obj)

        ''********** Guardar Detalle    *****************************
        Dim _DT As DataTable = DT.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Unchanged)

        If Not _DT Is Nothing Then
            For i As Integer = 0 To _DT.Rows.Count - 1
                obj_dtl.IdSysArticulosFormula = IdFormula
                obj_dtl.EMPRESA = EmpresaActual
                obj_dtl.TIPO = _DT.Rows.Item(i)("Tipo")
                obj_dtl.CODIGO_ARTICULO = _DT.Rows.Item(i)("Producto")
                obj_dtl.Unidad = IsNull(_DT.Rows.Item(i)("Und. Materia"), "")
                obj_dtl.Presentacion = IsNull(_DT.Rows.Item(i)("Presentacion"), "")
                obj_dtl.Cantidad = _DT.Rows.Item(i)("Cantidad")
                obj_dtl.CodTipoProd = IsNull(_DT.Rows.Item(i)("Tipo Producto"), 0)
                obj_dtl.CODIGO_BODEGA = _DT.Rows.Item(i)("Bodega")
                obj_dtl.Costo = _DT.Rows.Item(i)("Costo")
                obj_dtl.Factor = IsNull(_DT.Rows.Item(i)("Factor"), 1.0)
                obj_dtl.Cantidad_Unidad = IsNull(_DT.Rows.Item(i)("Cantidad Base"), 1.0)
                obj_dtl.Unidad_Factor = IsNull(_DT.Rows.Item(i)("Unidad Base"), "")

                db_dtl.Insertar(obj_dtl)
            Next
        End If
        HideSplash()
        '
        XtraMsg("La Formula se ha guardado con éxito!")
        '
        FrmFormulaList.Cargar()
        Close()
    End Sub
End Class