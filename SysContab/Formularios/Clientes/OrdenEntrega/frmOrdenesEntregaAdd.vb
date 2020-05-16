Imports System.IO
Imports ClasesBLL
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI

Public Class frmOrdenesEntregaAdd

    Dim obj As New OrdenesEntrega
    Dim db As New db_OrdenesEntrega

    Dim obj_detalle As New OrdenesEntregaDetalle
    Dim db_detalle As New db_OrdenesEntregaDetalle

    Private Config As New VB.SysContab.ConfiguracionDB
    Private ConfigDetalles As New VB.SysContab.ConfiguracionDetails

    Public IdOrden As Integer = 0
    Private Temp As Boolean = False

    Dim DT_OT As DataTable = New DataTable("OT_Detalle")
    Public DT_ROL As DataTable

    Private Sub frmOrdenesEntregaAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        Fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date
        CargarCombos()
        MostrarDatos()
        CargarProductos()
        Cargar()
        '
        If IdOrden <> 0 Then
            If DT_ROL.Rows.Count > 0 Then
                Dim dr() As DataRow = DT_ROL.Select("Control = 'bAutorizar'")
                If dr.Length > 0 Then
                    bAutorizar.Enabled = True
                    iVista.Columns("Autorizado").Visible = True
                    iVista.Columns("Autorizado").OptionsColumn.AllowEdit = True
                End If

                Dim dr2() As DataRow = DT_ROL.Select("Control = 'cmdImprimir'")
                If dr2.Length > 0 Then cmdImprimir.Enabled = True
                '
                Dim dr3() As DataRow = DT_ROL.Select("Control = 'Existencias'")
                If dr3.Length > 0 Then iVista.Columns("Fisico").Visible = True
            End If
            '
            If rTipo.EditValue = 2 Then iVista.Columns("Fisico").Visible = True
        End If
        '
        'Validar si el usuario tiene autorizado ver los precios
        If DT_ROL.Rows.Count > 0 Then
            Dim dr() As DataRow = DT_ROL.Select("Control = 'VerPrecios'")
            If dr.Length > 0 Then MostrarPrecios()
        End If

        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails()
        Totales()
    End Sub

    Sub MostrarPrecios()
        iVista.Columns("Precio").Visible = True
        iVista.Columns("Precio U$").Visible = True
        iVista.Columns("SubTotal").Visible = True
        '
        lySubTotal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lyIva.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lyTotal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lyTotalU.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
    End Sub

    Sub CargarCombos()
        SearchLookUp(cbProyectos,
                     db_Proyectos.Fill(IIf(IdOrden = 0, 1, 0)),
                     "Nombre",
                     "IdProyecto", 0, 6, 7, 8)
        cbProyectos.EditValue = 0
        '
        SearchLookUp(cbCliente, VB.SysContab.ClientesDB.GetList(1).Tables("CLIENTES"), "Nombre", "Codigo", 3, 4, 5, 6, 7, 8)

        GetMonedasList(cbMoneda)
        '
        If EmpresaActual = 1 Then
            lySucursal.Text = "Sucursal:"
            lyResponsable.Text = "Responsable: "
            Combo(cbOrigen, ObtieneDatos("sp_GetSucursalesxUsuario", EmpresaActual, Usuario_ID), "[Seleccione Sucursal]")
            'LookUp(cbDestino, ObtieneDatos("sp_GetSucursalesClientes", EmpresaActual, 1), "Sucursal", "Codigo", "[Seleccione Sucursal]", 0, 1)
        End If
        If EmpresaActual <> 1 Then
            lySucursal.Text = "Departamento:"
            lyResponsable.Text = "Entregar A: "
            GetCentrosCostosList(cbOrigen)
        End If
        '
        GetBodegasList(cbDestino)
        cbOrigen.ItemIndex = 0
    End Sub

    Sub CargarProductos()
        Dim Bodega As String = VB.SysContab.ConfiguracionDB.GetConfigDetails().Bodega

        Dim DT_BODEGA As DataTable = ObtieneDatos("sp_GetBodegaxSucursal", cbOrigen.EditValue, EmpresaActual)
        If DT_BODEGA.Rows.Count > 0 Then Bodega = DT_BODEGA.Rows.Item(0)("Codigo_Bodega")

        RepositorySearchLook(cbItems, ObtieneDatos("SP_ArticulosGetAll", "P", EmpresaActual, Bodega), "Codigo", "Codigo", 3, 4, 6, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26)
        '
        cbItems.View.Columns("PrecioU").Caption = "Precio U$"
        FormatoGrid(cbItems.View)
    End Sub

    Sub MostrarDatos()
        If IdOrden = 0 Then
            Numero.Text = db_OrdenesEntrega.GetNumero()
            tTasa.EditValue = GetTasaCambioDia(Fecha.DateTime.Date)

            Solicitado.Text = Usr_Nombre
        Else
            obj = db_OrdenesEntrega.Detalles(IdOrden)

            Fecha.DateTime = obj.Fecha
            Numero.Text = obj.NoOrden
            rTipo.EditValue = obj.Tipo
            cbProyectos.EditValue = obj.IdProyecto
            cbCliente.EditValue = obj.IdCliente
            ANombre.Text = obj.ANombre
            txtResponsable.Text = obj.Responsable
            Solicitado.Text = obj.Solicitado
            cbMoneda.EditValue = obj.Moneda
            tTasa.EditValue = obj.TCambio
            cbOrigen.EditValue = IIf(EmpresaActual = 1, obj.Sucursal, obj.IdCentro)
            cbDestino.EditValue = obj.Destino
            txtDireccion.Text = obj.Direccion
            txtReferencia.Text = obj.Referencia
            txtNoPlaca.Text = obj.Placa
            txtTransporte.Text = obj.Transporte
            txtConductor.Text = obj.Conductor
            txtObservaciones.Text = obj.Concepto

            If obj.Autorizado = 1 Then bGuardar.Enabled = False
        End If
    End Sub

    Public Sub Cargar()

        DT_OT = db_OrdenesEntregaDetalle.Listar(IdOrden)
        iVista.PopulateColumns()
        iGrid.DataSource = DT_OT

        FormatoGrid(iVista, 4, 0, False, True, False)

        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
        Next

        iVista.Columns("IdDetalle").Visible = False
        iVista.Columns("Tipo").Visible = False
        iVista.Columns("IVA").Visible = False
        iVista.Columns("Entregar").Visible = False
        iVista.Columns("Saldo").Visible = False
        iVista.Columns("Costo").Visible = False

        iVista.Columns("Precio").Visible = False
        iVista.Columns("Precio U$").Visible = False
        iVista.Columns("SubTotal").Visible = False
        iVista.Columns("Fisico").Visible = False

        iVista.Columns("Producto").OptionsColumn.AllowEdit = True
        iVista.Columns("Nombre").OptionsColumn.AllowEdit = True
        iVista.Columns("Cantidad").OptionsColumn.AllowEdit = True
        iVista.Columns("Fisico").OptionsColumn.AllowEdit = True
        iVista.Columns("Precio").OptionsColumn.AllowEdit = True
        iVista.Columns("Precio U$").OptionsColumn.AllowEdit = True
        iVista.Columns("Agrupar").OptionsColumn.AllowEdit = True
        '
        iVista.Columns("Producto").ColumnEdit = cbItems
        iVista.Columns("Cantidad").ColumnEdit = tMonto
        iVista.Columns("Cantidad").Caption = "Solicitado"
        iVista.Columns("Fisico").ColumnEdit = tMonto
        iVista.Columns("Autorizado").ColumnEdit = tMonto
        iVista.Columns("Entregado").ColumnEdit = tMonto
        iVista.Columns("Precio").ColumnEdit = tMonto
        iVista.Columns("Precio U$").ColumnEdit = tMonto
        iVista.Columns("IVA").ColumnEdit = tMonto

        iVista.Columns("Producto").VisibleIndex = 0
        iVista.Columns("Nombre").VisibleIndex = 1
        iVista.Columns("Unidad").VisibleIndex = 1
        iVista.Columns("Cantidad").VisibleIndex = 2
        iVista.Columns("Factor").VisibleIndex = 3
        iVista.Columns("Real").VisibleIndex = 4
        iVista.Columns("Fisico").VisibleIndex = 5
        iVista.Columns("Autorizado").VisibleIndex = 6
        iVista.Columns("Entregado").VisibleIndex = 7
        iVista.Columns("Precio U$").VisibleIndex = 8
        iVista.Columns("Precio").VisibleIndex = 9
        iVista.Columns("SubTotal").VisibleIndex = 10

        If EmpresaActual <> 1 Then
            iVista.Columns("Factor").Visible = False
            iVista.Columns("Real").Visible = False
        End If

        If IdOrden = 0 Then
            iVista.Columns("Autorizado").Visible = False
            iVista.Columns("Entregado").Visible = False
        Else
            If obj.Autorizado = 1 Then
                iVista.Columns("Autorizado").Visible = True
                iVista.Columns("Entregado").Visible = True
                iVista.Columns("Cantidad").OptionsColumn.AllowEdit = False
            End If
        End If
        '
        Dim TC As DataTable = ObtieneDatos("_GetListTasaCambioDisponibles", EmpresaActual)

        If TC.Rows.Count > 0 Then
            Dim dr() As DataRow = TC.Select("MonedaCambio = '" & MonedaBase & "'")
            If dr.Length > 0 Then
                iVista.Columns("Precio").Caption = "Precio " & dr(0).Item("Simbolo").ToString
                lyTotal.Text = "Total " & dr(0).Item("Simbolo").ToString & ":"
            End If
        End If
    End Sub

    Private Sub Fecha_EditValueChanged(sender As Object, e As EventArgs) Handles Fecha.EditValueChanged
        tTasa.EditValue = GetTasaCambioDia(Fecha.DateTime.Date)
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        If rTipo.EditValue = 1 Then
            If cbOrigen.EditValue Is Nothing Then
                XtraMsg("Seleccione Sucursal / Departamento que solicita.", MessageBoxIcon.Warning)
                cbOrigen.Focus()
                Exit Sub
            End If
            '
            If cbDestino.EditValue Is Nothing Then
                XtraMsg("Seleccione Destino", MessageBoxIcon.Warning)
                cbDestino.Focus()
                Exit Sub
            End If
        End If

        If iVista.DataRowCount = 0 Then
            XtraMsg("No se han encontrado registrado los Productos para esta Orden de Entrega!", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        obj.IdOrden = IdOrden
        obj.NoOrden = Numero.Text
        obj.Referencia = txtReferencia.Text
        obj.Sucursal = IIf(EmpresaActual = 1, cbOrigen.EditValue, "")
        obj.IdCentro = IIf(EmpresaActual <> 1, cbOrigen.EditValue, 0)
        obj.Fecha = Fecha.DateTime.Date
        obj.IdProyecto = IsNull(cbProyectos.EditValue, 0)
        obj.IdCliente = IsNull(cbCliente.EditValue, 0)
        obj.ANombre = ANombre.Text
        obj.Moneda = cbMoneda.EditValue
        obj.TCambio = tTasa.EditValue
        obj.Direccion = txtDireccion.Text
        obj.Placa = txtNoPlaca.Text
        obj.Transporte = txtTransporte.Text
        obj.Conductor = txtConductor.Text
        obj.Concepto = txtObservaciones.Text
        obj.Monto = iVista.Columns("SubTotal").SummaryItem.SummaryValue
        obj.SubTotal = iVista.Columns("SubTotal").SummaryItem.SummaryValue
        obj.IVA = iVista.Columns("IVA").SummaryItem.SummaryValue
        obj.Total = iVista.Columns("SubTotal").SummaryItem.SummaryValue + iVista.Columns("IVA").SummaryItem.SummaryValue
        obj.Tipo = rTipo.EditValue
        obj.Responsable = txtResponsable.Text
        obj.Solicitado = Solicitado.Text
        obj.Destino = cbDestino.EditValue

        If IdOrden = 0 Then
            ShowSplash("Guardando Orden...")

            IdOrden = db.Insertar(obj)

            Dim _DT_DTL As DataTable = DT_OT.GetChanges(DataRowState.Added Or DataRowState.Modified)

            If Not _DT_DTL Is Nothing Then
                For i As Integer = 0 To _DT_DTL.Rows.Count - 1
                    obj_detalle.IdOrden = IdOrden
                    obj_detalle.Tipo = IsNull(_DT_DTL.Rows.Item(i)("Tipo"), "P")
                    obj_detalle.Producto = IsNull(_DT_DTL.Rows.Item(i)("Producto"), "")
                    obj_detalle.Nombre = IsNull(_DT_DTL.Rows.Item(i)("Nombre"), "")
                    obj_detalle.Cantidad = IsNull(_DT_DTL.Rows.Item(i)("Cantidad"), 0.00)
                    obj_detalle.Fisico = IsNull(_DT_DTL.Rows.Item(i)("Fisico"), 0.00)
                    obj_detalle.Autorizado = IsNull(_DT_DTL.Rows.Item(i)("Cantidad"), 0.00)
                    obj_detalle.Entregado = IsNull(_DT_DTL.Rows.Item(i)("Entregado"), 0.00)
                    obj_detalle.Precio = IsNull(_DT_DTL.Rows.Item(i)("Precio"), 0.00)
                    obj_detalle.IVA = IsNull(_DT_DTL.Rows.Item(i)("IVA"), 0.00)
                    obj_detalle.Total = IsNull(_DT_DTL.Rows.Item(i)("SubTotal"), 0.00)
                    obj_detalle.Agrupar = IsNull(_DT_DTL.Rows.Item(i)("Agrupar"), "")

                    db_detalle.Insertar(obj_detalle)
                Next
            End If

            HideSplash()

            XtraMsg("La Orden de Entrega No. " + db_OrdenesEntrega.Detalles(IdOrden).NoOrden + " se ha creado con exito!")
            Imprimir()

            Close()
            If frmOrdenesEntregaNew.Created Then frmOrdenesEntregaNew.Cargar()
        Else
            ShowSplash("Actualizando Orden...")

            db.Actualizar(obj)

            Dim _DT_UPD As DataTable =
                DT_OT.GetChanges(DataRowState.Modified)

            If Not _DT_UPD Is Nothing Then
                For i As Integer = 0 To _DT_UPD.Rows.Count - 1
                    obj_detalle.IdDetalle = _DT_UPD.Rows.Item(i)("IdDetalle")
                    obj_detalle.IdOrden = IdOrden
                    obj_detalle.Tipo = IsNull(_DT_UPD.Rows.Item(i)("Tipo"), "P")
                    obj_detalle.Producto = IsNull(_DT_UPD.Rows.Item(i)("Producto"), "")
                    obj_detalle.Nombre = IsNull(_DT_UPD.Rows.Item(i)("Nombre"), "")
                    obj_detalle.Cantidad = IsNull(_DT_UPD.Rows.Item(i)("Cantidad"), 0.00)
                    obj_detalle.Fisico = IsNull(_DT_UPD.Rows.Item(i)("Fisico"), 0.00)
                    obj_detalle.Autorizado = IsNull(_DT_UPD.Rows.Item(i)("Autorizado"), 0.00)
                    obj_detalle.Entregado = IsNull(_DT_UPD.Rows.Item(i)("Entregado"), 0.00)
                    obj_detalle.Precio = IsNull(_DT_UPD.Rows.Item(i)("Precio"), 0.00)
                    obj_detalle.IVA = IsNull(_DT_UPD.Rows.Item(i)("IVA"), 0.00)
                    obj_detalle.Total = IsNull(_DT_UPD.Rows.Item(i)("SubTotal"), 0.00)
                    obj_detalle.Agrupar = IsNull(_DT_UPD.Rows.Item(i)("Agrupar"), "")

                    db_detalle.Actualizar(obj_detalle)
                Next
            End If
            '
            'Agregar Nuevos Registros
            Dim _DT_NEW As DataTable = DT_OT.GetChanges(DataRowState.Added)
            If Not _DT_NEW Is Nothing Then
                For i As Integer = 0 To _DT_NEW.Rows.Count - 1
                    obj_detalle.IdOrden = IdOrden
                    obj_detalle.Tipo = IsNull(_DT_NEW.Rows.Item(i)("Tipo"), "P")
                    obj_detalle.Producto = IsNull(_DT_NEW.Rows.Item(i)("Producto"), "")
                    obj_detalle.Nombre = IsNull(_DT_NEW.Rows.Item(i)("Nombre"), "")
                    obj_detalle.Cantidad = IsNull(_DT_NEW.Rows.Item(i)("Cantidad"), 0.00)
                    obj_detalle.Fisico = IsNull(_DT_NEW.Rows.Item(i)("Fisico"), 0.00)
                    obj_detalle.Autorizado = IsNull(_DT_NEW.Rows.Item(i)("Cantidad"), 0.00)
                    obj_detalle.Entregado = IsNull(_DT_NEW.Rows.Item(i)("Entregado"), 0.00)
                    obj_detalle.Precio = IsNull(_DT_NEW.Rows.Item(i)("Precio"), 0.00)
                    obj_detalle.IVA = IsNull(_DT_NEW.Rows.Item(i)("IVA"), 0.00)
                    obj_detalle.Total = IsNull(_DT_NEW.Rows.Item(i)("SubTotal"), 0.00)
                    obj_detalle.Agrupar = IsNull(_DT_NEW.Rows.Item(i)("Agrupar"), "")

                    db_detalle.Insertar(obj_detalle)
                Next
            End If

            '
            Dim _DT_DEL As DataTable = DT_OT.GetChanges(DataRowState.Deleted)
            If Not _DT_DEL Is Nothing Then
                For i As Integer = 0 To _DT_DEL.Rows.Count - 1
                    obj_detalle.IdDetalle = _DT_DEL.Rows.Item(i)("IdDetalle", DataRowVersion.Original)
                    db_detalle.Borrar(obj_detalle)
                Next
            End If

            HideSplash()
            XtraMsg("Los Cambios Solicitados han sido actualizados con exito!")
            '
            Close()
            If frmOrdenesEntregaNew.Created Then frmOrdenesEntregaNew.Cargar()
        End If
    End Sub

    Sub Imprimir()
        ShowSplash("Imprimiendo...")

        'Dim Cadena As String
        'Dim Temp As Boolean = False
        'Dim Data() As Byte

        'Try
        '    Data = CType(ObtieneDatos("sp_get_formato_imprimir", 12, EmpresaA).Rows(0).Item(0), Byte())
        '    Temp = True
        '    '
        '    Dim Tamano As Integer
        '    Tamano = Data.GetUpperBound(0)
        '    Cadena = Application.StartupPath & "\rptOrdenEntrega.repx"
        '    If File.Exists(Cadena) Then Kill(Cadena)
        '    Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
        '    Archivo.Write(Data, 0, Tamano)
        '    Archivo.Close()
        'Catch ex As Exception
        '    Temp = False
        'End Try

        Dim Temp As Boolean = db_Formatos.FormatoImpreso(12, "rptOrdenEntrega")

        Dim rpt As rptOrdenEntrega

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptOrdenEntrega.repx", True)
        Else
            rpt = New rptOrdenEntrega
        End If

        'rpt.DataSource = ObtieneDatos("sp_sel_OrdenesEntrega_Imprimir", IdOrden, EmpresaA)

        VistaPreviaDX(rpt, db_OrdenesEntrega.Imprimir(IdOrden), "Orden de Entrega No. " & Numero.Text)
        HideSplash()

        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()       
        'HideSplash()
        'rpt.ShowRibbonPreview()
    End Sub

    Private Sub bAutorizar_Click(sender As Object, e As EventArgs) Handles bAutorizar.Click

        If EmpresaActual = 1 Then
            Dim dr_fisico() As DataRow = DT_OT.Select("Fisico = 0.00")

            If dr_fisico.Length > 0 Then
                XtraMsg("Existe " & dr_fisico.Length.ToString & " Producto(s) sin Existencia Fisica, favor ingresar Fisico para aprobar", MessageBoxIcon.Warning)
                Exit Sub
            End If

        End If
        '

        If Not XtraMsg2("Esta Seguro de Autorizar esta Orden de Entrega No. " + Numero.Text) Then
            Exit Sub
        End If
        '
        obj.IdOrden = IdOrden
        db.Autorizar(obj, 1)

        XtraMsg("La Orden de Entrega ha sido autorizada.")
        iVista.Columns("Autorizado").Visible = True
        iVista.Columns("Autorizado").OptionsColumn.AllowEdit = True
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        If IdOrden <> 0 Then Imprimir()
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, "Detalle de Orden de Entrega No. " + Numero.Text)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub iVista_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles iVista.CellValueChanged
        If e.Column.FieldName = "Producto" Then
            Dim DR As DataRowView = cbItems.GetRowByKeyValue(e.Value)

            If Not DR Is Nothing Then
                Temp = True

                Dim dr_buscar() As DataRow =
                    DT_OT.Select("Producto = '" & e.Value & "'")

                If dr_buscar.Length > 0 Then
                    XtraMsg("El Producto que intenta agregar ya se encuentra en al Lista",
                            MessageBoxIcon.Error)
                    iVista.DeleteSelectedRows()
                    Exit Sub
                End If

                If IsNull(iVista.GetRowCellValue(e.RowHandle, "IdDetalle"), 0) = 0 Then
                    iVista.SetRowCellValue(e.RowHandle, "Nombre", DR.Item("Nombre"))
                    iVista.SetRowCellValue(e.RowHandle, "Unidad", DR.Item("Unidad"))
                    iVista.SetRowCellValue(e.RowHandle, "Precio", DR.Item("Precio"))
                    iVista.SetRowCellValue(e.RowHandle, "Precio U$", DR.Item("Precio") / tTasa.EditValue)
                    iVista.SetRowCellValue(e.RowHandle, "Tipo", DR.Item("Tipo"))
                    iVista.SetRowCellValue(e.RowHandle, "Cantidad", IIf(iVista.GetRowCellValue(e.RowHandle, "Cantidad") Is Nothing, 1.0, iVista.GetRowCellValue(e.RowHandle, "Cantidad")))
                    iVista.SetRowCellValue(e.RowHandle, "Factor", DR.Item("Factor"))
                    iVista.SetRowCellValue(e.RowHandle, "Real", DR.Item("Factor"))
                    iVista.SetRowCellValue(e.RowHandle, "Fisico", 0.00)
                    iVista.SetRowCellValue(e.RowHandle, "Autorizado", 0.00)
                    iVista.SetRowCellValue(e.RowHandle, "Entregado", 0.00)
                    iVista.SetRowCellValue(e.RowHandle, "IVA", IIf(DR.Item("Exento"), 0.00, CDbl(DR.Item("Precio") * (ConfigDetalles.IVA / 100))))
                    iVista.SetRowCellValue(e.RowHandle, "SubTotal", DR.Item("Precio"))
                Else
                    iVista.SetRowCellValue(e.RowHandle, "Nombre", DR.Item("Nombre"))
                    iVista.SetRowCellValue(e.RowHandle, "Unidad", DR.Item("Unidad"))
                    iVista.SetRowCellValue(e.RowHandle, "Precio", DR.Item("Precio"))
                    iVista.SetRowCellValue(e.RowHandle, "Precio U$", DR.Item("Precio") / tTasa.EditValue)
                    iVista.SetRowCellValue(e.RowHandle, "Tipo", DR.Item("Tipo"))
                    'iVista.SetRowCellValue(e.RowHandle, "Cantidad", IIf(iVista.GetRowCellValue(e.RowHandle, "Cantidad") Is Nothing, 1.0, iVista.GetRowCellValue(e.RowHandle, "Cantidad")))
                    'iVista.SetRowCellValue(e.RowHandle, "Factor", DR.Item("Factor"))
                    'iVista.SetRowCellValue(e.RowHandle, "Real", DR.Item("Factor"))
                    'iVista.SetRowCellValue(e.RowHandle, "Fisico", 0.00)
                    'iVista.SetRowCellValue(e.RowHandle, "Autorizado", 0.00)
                    'iVista.SetRowCellValue(e.RowHandle, "Entregado", 0.00)
                    iVista.SetRowCellValue(e.RowHandle, "IVA", IIf(DR.Item("Exento"), 0.00, CDbl(DR.Item("Precio") * (ConfigDetalles.IVA / 100))))
                    'iVista.SetRowCellValue(e.RowHandle, "SubTotal", DR.Item("Precio"))
                End If

                If EmpresaActual <> 1 Then
                    Dim DT_PROD As DataTable = ObtieneDatos("sp_GetExistenciaOrdenEntrega", e.Value, cbDestino.EditValue, EmpresaActual)

                    If DT_PROD.Rows.Count > 0 Then iVista.SetRowCellValue(e.RowHandle, "Fisico", DT_PROD.Rows.Item(0)("Existencia"))
                    If DT_PROD.Rows.Count = 0 Then iVista.SetRowCellValue(e.RowHandle, "Fisico", 0.00)
                End If

                Temp = False

                End If
            End If
        '
        If e.Column.FieldName = "Nombre" Then
            Temp = True
            Dim dr_buscar() As DataRow = DT_OT.Select("Nombre = '" & e.Value & "'")

            If dr_buscar.Length > 0 Then
                XtraMsg("El Nombre de Producto que intenta agregar ya se encuentra en al Lista", MessageBoxIcon.Error)
                iVista.DeleteSelectedRows()
                Exit Sub
            End If
            '
            If IsNull(iVista.GetRowCellValue(e.RowHandle, "IdDetalle"), 0) = 0 Then
                iVista.SetRowCellValue(e.RowHandle, "Precio", 0.00)
                iVista.SetRowCellValue(e.RowHandle, "Precio U$", 0.00)
                iVista.SetRowCellValue(e.RowHandle, "Tipo", "P")
                iVista.SetRowCellValue(e.RowHandle, "Cantidad", 1.0)
                iVista.SetRowCellValue(e.RowHandle, "Factor", 1.0)
                iVista.SetRowCellValue(e.RowHandle, "Real", 1.0)
                iVista.SetRowCellValue(e.RowHandle, "Fisico", 0.00)
                iVista.SetRowCellValue(e.RowHandle, "Autorizado", 0.00)
                iVista.SetRowCellValue(e.RowHandle, "Entregado", 0.00)
                iVista.SetRowCellValue(e.RowHandle, "IVA", 0.00)
                iVista.SetRowCellValue(e.RowHandle, "SubTotal", 0.00)
            End If

            If EmpresaActual <> 1 Then
                Dim DT_PROD As DataTable = ObtieneDatos("sp_GetExistenciaOrdenEntrega", iVista.GetRowCellValue(e.RowHandle, "Producto"), cbDestino.EditValue, EmpresaActual)

                If DT_PROD.Rows.Count > 0 Then iVista.SetRowCellValue(e.RowHandle, "Fisico", DT_PROD.Rows.Item(0)("Existencia"))
                If DT_PROD.Rows.Count = 0 Then iVista.SetRowCellValue(e.RowHandle, "Fisico", 0.00)
            End If


            Temp = False
        End If

        If e.Column.FieldName = "Precio" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True
                iVista.SetRowCellValue(e.RowHandle, "Precio U$", CDbl(e.Value / tTasa.EditValue).ToString(RoundP))
                Temp = False
            End If
        End If
        '
        If e.Column.FieldName = "Precio U$" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True
                iVista.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * tTasa.EditValue).ToString(RoundP))
                Temp = False
            End If
        End If

        If e.Column.FieldName = "Precio" Or
           e.Column.FieldName = "Precio U$" Or
           e.Column.FieldName = "Cantidad" And Not Temp Then

            Dim DR As DataRowView = cbItems.GetRowByKeyValue(IsNull(iVista.GetRowCellValue(e.RowHandle, "Producto"), ""))

            iVista.SetRowCellValue(e.RowHandle, "Real", IsNull(iVista.GetRowCellValue(e.RowHandle, "Cantidad"), 1.0) * IsNull(iVista.GetRowCellValue(e.RowHandle, "Factor"), 1.0))

            iVista.SetRowCellValue(e.RowHandle, "SubTotal", (IsNull(iVista.GetRowCellValue(e.RowHandle, "Real"), 1.0)) *
                                                             IsNull(iVista.GetRowCellValue(e.RowHandle, "Precio"), 0.0))

            If Not DR Is Nothing Then
                If DR.Item("Exento") Then
                    iVista.SetRowCellValue(e.RowHandle, "IVA", 0.0)
                Else
                    iVista.SetRowCellValue(e.RowHandle, "IVA", IsNull(iVista.GetRowCellValue(e.RowHandle, "SubTotal") * (ConfigDetalles.IVA / 100.0), 0))
                End If
            End If
        End If

        iVista.UpdateTotalSummary()
    End Sub

    Private Sub iVista_KeyDown(sender As Object, e As KeyEventArgs) Handles iVista.KeyDown
        If Me.iVista.FocusedRowHandle < 0 Then Exit Sub
        'Borrar Lineas del Grid
        If e.KeyCode = Keys.Delete Then
            iVista.DeleteSelectedRows()
            Totales()
        End If
    End Sub

    Private Sub iVista_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles iVista.RowUpdated
        Totales()
    End Sub

    Sub Totales()
        iVista.UpdateTotalSummary()
        iVista.RefreshData()
        '
        tSubTotal.EditValue = iVista.Columns("SubTotal").SummaryItem.SummaryValue
        tIva.EditValue = iVista.Columns("IVA").SummaryItem.SummaryValue
        tTotal.EditValue = tSubTotal.EditValue + tIva.EditValue
        tTotalU.EditValue = tTotal.EditValue / tTasa.EditValue
    End Sub

    Private Sub frmOrdenesEntregaAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'If frmOrdenesEntregaNew.Created Then frmOrdenesEntregaNew.Cargar()
    End Sub

    Private Sub iVista_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles iVista.ValidateRow
        If IsNull(iVista.GetRowCellValue(e.RowHandle, "Nombre"), "") = "" Then
            e.ErrorText = "Debe Introducir el Nombre del Producto o Formula" & vbCrLf
            e.Valid = False
        End If
    End Sub

    Private Sub cbOrigen_EditValueChanged(sender As Object, e As EventArgs) Handles cbOrigen.EditValueChanged
        If Not Inicio Then CargarProductos()
    End Sub

    Private Sub frmOrdenesEntregaAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' If e.KeyCode = Keys.Escape Then Close()
    End Sub

    Private Sub rTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rTipo.SelectedIndexChanged

    End Sub

    Private Sub cbCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cbCliente.EditValueChanged
        ANombre.Text = cbCliente.Text
    End Sub

    Private Sub cbProyectos_EditValueChanged(sender As Object, e As EventArgs) Handles cbProyectos.EditValueChanged
        If cbProyectos.EditValue <> 0 Then
            cbCliente.EditValue = cbProyectos.Properties.View.GetRowCellValue(cbProyectos.Properties.View.FocusedRowHandle, "IdCliente")
            cbCliente.ReadOnly = True
            '
            txtReferencia.Text = cbProyectos.Properties.View.GetRowCellValue(cbProyectos.Properties.View.FocusedRowHandle, "Codigo")
        Else
            cbCliente.EditValue = 0
            cbCliente.ReadOnly = False
            '
            txtReferencia.Text = ""
        End If
    End Sub
End Class