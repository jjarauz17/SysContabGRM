Imports System.ComponentModel
Imports System.IO
Imports ClasesBLL
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI

Public Class frmOrdenesEntregaRemision

    Dim obj As New Remisiones
    Dim db As New db_Remisiones

    Dim obj_Ordenes As New OrdenesEntrega
    Dim db_Ordenes As New db_OrdenesEntrega

    Dim obj_detalle As New RemisionesDetalle
    Dim db_detalle As New db_RemisionesDetalle

    Private Config As New VB.SysContab.ConfiguracionDB
    Private ConfigDetalles As New VB.SysContab.ConfiguracionDetails

    Public IdOrden As Integer = 0
    Public IdRemision As Integer = 0, NoRemision As String = ""
    Private Temp As Boolean = False

    Dim DT_OT As DataTable = New DataTable("OT_Detalle")

    Private Sub frmOrdenesEntregaAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        ShowSplash("Cargando Orden...")

        Fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date
        CargarCombos()
        MostrarDatos()
        Cargar()
        '
        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails()
        Totales()
        '
        HideSplash()
    End Sub

    Sub CargarCombos()
        SearchLookUp(
            cbProyectos,
            db_Proyectos.Fill(1),
            "Nombre",
            "IdProyecto", 0, 6, 7, 8)
        cbProyectos.EditValue = 0

        SearchLookUp(cbCliente, VB.SysContab.ClientesDB.GetList(1).Tables("CLIENTES"), "Nombre", "Codigo", 3, 4, 5, 6, 7, 8)
        GetMonedasList(cbMoneda)

        If EmpresaActual = 1 Then
            lyOrigen.Text = "Sucursal: "
            Combo(cbSucursal, ObtieneDatos("sp_GetSucursalesxUsuario", EmpresaActual, Usuario_ID), "[Seleccione Sucursal]")
        End If
        If EmpresaActual <> 1 Then
            lyOrigen.Text = "Bodega: "
            GetBodegasxUsuario(cbSucursal, 0)
        End If

        ' Combo(cbSucursal, ObtieneDatos("sp_GetSucursalesxUsuario", EmpresaActual, Usuario_ID), "[Seleccione Sucursal]")

        RepositorySearchLook(cbItems, ObtieneDatos("SP_ArticulosGetAll", "P", EmpresaActual), "Codigo", "Codigo", 3, 4, 6, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26)
        cbItems.View.Columns("PrecioU").Caption = "Precio U$"
        FormatoGrid(cbItems.View)
    End Sub

    Sub MostrarDatos()
        If IdOrden > 0 Then
            Numero.Text = db_Remisiones.GetNumero()
            obj_Ordenes = db_OrdenesEntrega.Detalles(IdOrden)

            txtOrden.Text = obj_Ordenes.NoOrden
            Fecha.DateTime = obj_Ordenes.Fecha

            'Numero.Text = obj_Ordenes.NoOrden
            cbProyectos.EditValue = obj_Ordenes.IdProyecto
            cbCliente.EditValue = obj_Ordenes.IdCliente
            ANombre.Text = obj_Ordenes.ANombre
            cbMoneda.EditValue = obj_Ordenes.Moneda
            tTasa.EditValue = obj_Ordenes.TCambio
            cbSucursal.EditValue = IIf(EmpresaActual = 1, obj_Ordenes.Sucursal, obj_Ordenes.Bodega)
            txtDireccion.Text = obj_Ordenes.Direccion
            txtReferencia.Text = obj_Ordenes.Referencia
            txtNoPlaca.Text = obj_Ordenes.Placa
            txtTransporte.Text = obj_Ordenes.Transporte
            txtConductor.Text = obj_Ordenes.Conductor
            'txtObservaciones.Text = obj_Ordenes.Concepto
            cbDestino.EditValue = obj_Ordenes.Bodega

        ElseIf IdRemision > 0 Then
            obj = db_Remisiones.Detalles(IdRemision)

            Numero.Text = obj.NoRemision
            Fecha.DateTime = obj.Fecha
            cbProyectos.EditValue = obj.IdProyecto
            cbCliente.EditValue = obj.IdCliente
            cbMoneda.EditValue = obj.Moneda
            tTasa.EditValue = obj.TCambio
            cbSucursal.EditValue = obj.Sucursal
            txtDireccion.Text = obj.Direccion
            txtReferencia.Text = obj.Referencia
            txtNoPlaca.Text = obj.Placa
            txtTransporte.Text = obj.Transporte
            txtConductor.Text = obj.Conductor
            txtObservaciones.Text = obj.Concepto

            ValidarTraslado()
        End If

    End Sub

    Public Sub Cargar()

        If IdOrden > 0 Then DT_OT = db_OrdenesEntregaDetalle.ListarEntrega(IdOrden)
        If IdRemision > 0 Then DT_OT = db_RemisionesDetalle.Listar(IdRemision)

        iVista.PopulateColumns()
        iGrid.DataSource = DT_OT
        FormatoGrid(iVista, 4, 0, False, True, False)

        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
        Next

        If IdRemision > 0 Then
            iVista.Columns("Cantidad").Visible = True
            iVista.Columns("Exento").Visible = False
        ElseIf IdOrden > 0 Then
            iVista.Columns("Cantidad").Visible = False
            iVista.Columns("Real").Visible = False
            '
            iVista.Columns("Cantidad Entregar").OptionsColumn.AllowEdit = True
            iVista.Columns("Entrega").OptionsColumn.AllowEdit = True
            iVista.Columns("Agrupar").OptionsColumn.AllowEdit = True
            iVista.Columns("Entrega").ColumnEdit = rChkEntrega
            '
            iVista.Columns("Saldo").ColumnEdit = tMonto
            iVista.Columns("Cantidad").Caption = "Solicitado"
            ' iVista.Columns("Fisico").ColumnEdit = tMonto
            iVista.Columns("Autorizado").ColumnEdit = tMonto
            iVista.Columns("Entregado").ColumnEdit = tMonto
            iVista.Columns("Cantidad Entregar").ColumnEdit = tMonto
            iVista.Columns("Real").ColumnEdit = tMonto

            If EmpresaActual <> 1 Then
                iVista.Columns("Cantidad Entregar").OptionsColumn.AllowEdit = False
                iVista.Columns("Entrega").OptionsColumn.AllowEdit = False
                iVista.Columns("Entrega").Visible = False
                iVista.Columns("Real").Visible = False
            End If
        End If

        iVista.Columns("IdDetalle").Visible = False
        iVista.Columns("Tipo").Visible = False
        iVista.Columns("IVA").Visible = False
        iVista.Columns("Precio").Visible = False
        iVista.Columns("Precio U$").Visible = False
        iVista.Columns("SubTotal").Visible = False
        iVista.Columns("Costo").Visible = False
        '
        iVista.Columns("Producto").ColumnEdit = cbItems
        iVista.Columns("Cantidad").ColumnEdit = tMonto
        iVista.Columns("Precio").ColumnEdit = tMonto
        iVista.Columns("Precio U$").ColumnEdit = tMonto
        iVista.Columns("IVA").ColumnEdit = tMonto
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
        If iVista.DataRowCount = 0 Then
            XtraMsg("No se han encontrado registrado!", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        'Validar que esten marcados y cantidad mayor que Cero
        If IdOrden > 0 Then
            Dim dr1() As DataRow = DT_OT.Select("Entrega = 1")

            If dr1.Length = 0 Then
                XtraMsg("Debe Marcar al menos 1 Producto para realizar la entrega!", MessageBoxIcon.Error)
                Exit Sub
            End If
            '
            Dim dr2() As DataRow = DT_OT.Select("Entrega = 1 AND [Cantidad Entregar] = 0.00")

            If dr2.Length > 0 Then
                XtraMsg("No se puede entregar productos con Cantidad Cero (0).", MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        '
        If rTipo.EditValue = 1 Then GuardarRemision()
        If rTipo.EditValue = 2 Then GuardarTraslado()


        'ShowSplash("Actualizando Orden...")
        'db.Actualizar(obj)

        'Dim _DT_UPD As DataTable = DT_OT.GetChanges(DataRowState.Modified)

        'If Not _DT_UPD Is Nothing Then
        '    For i As Integer = 0 To _DT_UPD.Rows.Count - 1
        '        obj_detalle.IdDetalle = _DT_UPD.Rows.Item(i)("IdDetalle")
        '        obj_detalle.IdOrden = IdOrden
        '        obj_detalle.Tipo = _DT_UPD.Rows.Item(i)("Tipo")
        '        obj_detalle.Producto = _DT_UPD.Rows.Item(i)("Producto")
        '        obj_detalle.Cantidad = _DT_UPD.Rows.Item(i)("Cantidad")
        '        obj_detalle.Fisico = IsNull(_DT_UPD.Rows.Item(i)("Fisico"), 0.00)
        '        obj_detalle.Autorizado = _DT_UPD.Rows.Item(i)("Autorizado")
        '        obj_detalle.Entregado = IsNull(_DT_UPD.Rows.Item(i)("Entregado"), 0.00)
        '        obj_detalle.Precio = IsNull(_DT_UPD.Rows.Item(i)("Precio"), 0.00)
        '        obj_detalle.IVA = IsNull(_DT_UPD.Rows.Item(i)("IVA"), 0.00)
        '        obj_detalle.Total = IsNull(_DT_UPD.Rows.Item(i)("SubTotal"), 0.00)

        '        db_detalle.Actualizar(obj_detalle)
        '    Next
        'End If
        ''
        ''Agregar Nuevos Registros
        'Dim _DT_NEW As DataTable = DT_OT.GetChanges(DataRowState.Added)
        'For i As Integer = 0 To _DT_NEW.Rows.Count - 1
        '    obj_detalle.IdOrden = IdOrden
        '    obj_detalle.Tipo = _DT_NEW.Rows.Item(i)("Tipo")
        '    obj_detalle.Producto = _DT_NEW.Rows.Item(i)("Producto")
        '    obj_detalle.Cantidad = _DT_NEW.Rows.Item(i)("Cantidad")
        '    obj_detalle.Fisico = IsNull(_DT_NEW.Rows.Item(i)("Fisico"), 0.00)
        '    obj_detalle.Autorizado = _DT_NEW.Rows.Item(i)("Cantidad")
        '    obj_detalle.Entregado = IsNull(_DT_NEW.Rows.Item(i)("Entregado"), 0.00)
        '    obj_detalle.Precio = IsNull(_DT_NEW.Rows.Item(i)("Precio"), 0.00)
        '    obj_detalle.IVA = IsNull(_DT_NEW.Rows.Item(i)("IVA"), 0.00)
        '    obj_detalle.Total = IsNull(_DT_NEW.Rows.Item(i)("SubTotal"), 0.00)

        '    db_detalle.Insertar(obj_detalle)
        'Next
        ''
        'Dim _DT_DEL As DataTable = DT_OT.GetChanges(DataRowState.Deleted)
        'If Not _DT_DEL Is Nothing Then
        '    For i As Integer = 0 To _DT_DEL.Rows.Count - 1
        '        obj_detalle.IdDetalle = _DT_DEL.Rows.Item(i)("IdDetalle", DataRowVersion.Original)
        '        db_detalle.Borrar(obj_detalle)
        '    Next
        'End If
        ' End If
    End Sub

    Sub GuardarRemision()

        obj.IdRemision = IdRemision
        obj.NoRemision = Numero.Text
        obj.NoOrden = txtOrden.Text
        obj.Referencia = txtReferencia.Text
        obj.Sucursal = IIf(EmpresaActual = 1, cbSucursal.EditValue, "")
        obj.Fecha = Fecha.DateTime.Date
        obj.IdProyecto = cbProyectos.EditValue
        obj.IdCliente = cbCliente.EditValue
        obj.Moneda = cbMoneda.EditValue
        obj.TCambio = tTasa.EditValue
        obj.Monto = iVista.Columns("SubTotal").SummaryItem.SummaryValue
        obj.SubTotal = iVista.Columns("SubTotal").SummaryItem.SummaryValue
        obj.IVA = iVista.Columns("IVA").SummaryItem.SummaryValue
        obj.Total = iVista.Columns("SubTotal").SummaryItem.SummaryValue + iVista.Columns("IVA").SummaryItem.SummaryValue
        obj.Direccion = txtDireccion.Text
        obj.Placa = txtNoPlaca.Text
        obj.Transporte = txtTransporte.Text
        obj.Conductor = txtConductor.Text
        obj.Concepto = txtObservaciones.Text
        obj.Exento = False
        obj.Bodega = IIf(EmpresaActual <> 1, cbSucursal.EditValue, "")
        obj.ANombre = ANombre.Text

        '  If IdRemision = 0 Then
        ShowSplash("Guardando Remisión...")
        IdRemision = db.Insertar(obj)
        'Dim _DT_DTL As DataTable = DT_OT.GetChanges(DataRowState.Added Or DataRowState.Modified)

        Dim _DT_DTL As DataTable = DT_OT.Select("Entrega = 1").CopyToDataTable

        If Not _DT_DTL Is Nothing Then
            For i As Integer = 0 To _DT_DTL.Rows.Count - 1
                obj_detalle.IdRemision = IdRemision
                obj_detalle.Tipo = _DT_DTL.Rows.Item(i)("Tipo")
                obj_detalle.Producto = _DT_DTL.Rows.Item(i)("Producto")
                obj_detalle.Cantidad = _DT_DTL.Rows.Item(i)("Cantidad Entregar")
                obj_detalle.Precio = IsNull(_DT_DTL.Rows.Item(i)("Precio"), 0.00)
                obj_detalle.IVA = IsNull(_DT_DTL.Rows.Item(i)("IVA"), 0.00)
                obj_detalle.Descuento = 0.00
                obj_detalle.Total = IsNull(_DT_DTL.Rows.Item(i)("SubTotal"), 0.00)
                obj_detalle.Agrupar = IsNull(_DT_DTL.Rows.Item(i)("Agrupar"), "")
                'Agregar Detalle de Remision.
                db_detalle.Insertar(obj_detalle)
                'Actualiar la Cantidad entrega de OT.
                obj_detalle.IdDetalle = _DT_DTL.Rows.Item(i)("IdDetalle")
                db_detalle.Actualizar_Detalle_Entregado(obj_detalle)
            Next
        End If

        HideSplash()
        'Imprimir()
        Close()
        If frmOrdenesEntregaNew.Created Then frmOrdenesEntregaNew.Cargar()
        ' Else
    End Sub

    Sub GuardarTraslado()

        If txtReferencia.Text.Length = 0 Then
            XtraMsg("Ingrese el Numero de Documento!")
            txtReferencia.Focus()
            Exit Sub
        End If
        '
        If cbSucursal.EditValue = cbDestino.EditValue Then
            XtraMsg("Las bodegas deben ser diferentes para realizar un traslado", MessageBoxIcon.Warning)
            cbDestino.Focus()
            Exit Sub
        End If

        If cbSucursal.EditValue Is Nothing Then
            XtraMsg("Seleccione la Bodega Origen", MessageBoxIcon.Warning)
            cbSucursal.Focus()
            Exit Sub
        End If

        If cbDestino.EditValue Is Nothing Then
            XtraMsg("Seleccione la Bodega Destino", MessageBoxIcon.Warning)
            cbDestino.Focus()
            Exit Sub
        End If
        '
        ShowSplash("Guardando Traslado...")

        Dim Entrada As Integer = db_requisas.Add(EmpresaActual, "E", Fecha.DateTime.Date, cbDestino.EditValue,
                                          Usuario, "", cbMovimientos.EditValue, txtReferencia.Text, txtObservaciones.Text,
                                          txtTransporte.Text, txtNoPlaca.Text, txtConductor.Text, NoRemision,
                                          "", "", IIf(cbCliente.EditValue Is Nothing, 0, cbCliente.EditValue), "",
                                          0, IdOrden, 0, 0, 0)

        Dim Salida As Integer = db_requisas.Add(EmpresaActual, "S", Fecha.DateTime.Date, cbSucursal.EditValue,
                                          Usuario, "", cbMovimientos.EditValue, txtReferencia.Text, txtObservaciones.Text,
                                          txtTransporte.Text, txtNoPlaca.Text, txtConductor.Text, NoRemision,
                                          "", "", IIf(cbCliente.EditValue Is Nothing, 0, cbCliente.EditValue), "",
                                          0, IdOrden, 0, 0, 0)

        'Actualizar Estado a Traslado en Tabla de OT y Remisiones
        obj_Ordenes.IdOrden = IdOrden
        obj.IdRemision = IdRemision

        If IdOrden > 0 Then db_Ordenes.Traslado_Marcar(obj_Ordenes)
        If IdRemision > 0 Then db.Traslado_Marcar(obj)

        Dim _DT_DTL As DataTable = Nothing

        'Dim _DT_DTL As DataTable = DT_OT.GetChanges(DataRowState.Added Or DataRowState.Modified)

        If IdOrden > 0 Then _DT_DTL = DT_OT.Select("Entrega = 1").CopyToDataTable  '_DT_DTL = DT_OT.GetChanges(DataRowState.Added Or DataRowState.Modified)
        If IdRemision > 0 Then _DT_DTL = DT_OT.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Unchanged)

        If Not _DT_DTL Is Nothing Then
            For i As Integer = 0 To _DT_DTL.Rows.Count - 1
                Dim Cantidad As Double = 0
                If IdOrden > 0 Then Cantidad = _DT_DTL.Rows(i)("Real") ' _DT_DTL.Rows(i)("Cantidad Entregar")
                If IdRemision > 0 Then Cantidad = _DT_DTL.Rows(i)("Cantidad")
                '
                db_requisas.AddDetalle(EmpresaActual, Entrada, _DT_DTL.Rows(i)("Producto"), "P", Cantidad,
                                            _DT_DTL.Rows.Item(i)("Costo"), "", "", "", "")

                db_requisas.AddDetalle(EmpresaActual, Salida, _DT_DTL.Rows(i)("Producto"), "P", Cantidad,
                                            _DT_DTL.Rows.Item(i)("Costo"), "", "", "", "")

                'Actualiar la Cantidad entrega de OT.
                If IdOrden > 0 Then
                    obj_detalle.IdDetalle = _DT_DTL.Rows.Item(i)("IdDetalle")
                    obj_detalle.Cantidad = _DT_DTL.Rows.Item(i)("Cantidad Entregar")
                    db_detalle.Actualizar_Detalle_Entregado(obj_detalle)
                End If
            Next
        End If
        '
        HideSplash()
        Close()
        '
        If frmOrdenesEntregaNew.Created Then frmOrdenesEntregaNew.Cargar()
        If frmTrasladosBodegasList.Created Then frmTrasladosBodegasList.Cargar()
        If frmRemisionesCliente.Created Then frmRemisionesCliente.Cargar()
    End Sub

    'Sub Imprimir()
    '    ShowSplash("Imprimiendo...")

    '    Dim Cadena As String
    '    Dim Temp As Boolean = False
    '    Dim Data() As Byte

    '    Try
    '        Data = CType(ObtieneDatos("sp_get_formato_imprimir", 12, EmpresaA).Rows(0).Item(0), Byte())
    '        Temp = True
    '        '
    '        Dim Tamano As Integer
    '        Tamano = Data.GetUpperBound(0)
    '        Cadena = Application.StartupPath & "\rptOrdenEntrega.repx"
    '        If File.Exists(Cadena) Then Kill(Cadena)
    '        Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
    '        Archivo.Write(Data, 0, Tamano)
    '        Archivo.Close()
    '    Catch ex As Exception
    '        Temp = False
    '    End Try

    '    Dim rpt As rptOrdenEntrega

    '    If Temp = True Then
    '        rpt = XtraReport.FromFile(Application.StartupPath & "\rptOrdenEntrega.repx", True)
    '    Else
    '        rpt = New rptOrdenEntrega
    '    End If

    '    rpt.DataSource = ObtieneDatos("sp_sel_Proyecto_Imprimir", IdOrden, EmpresaA)
    '    rpt.ShowPrintMarginsWarning = False
    '    rpt.BringToFront()
    '    '
    '    HideSplash()
    '    rpt.ShowRibbonPreview()
    'End Sub

    'Private Sub bAutorizar_Click(sender As Object, e As EventArgs)
    '    If Not XtraMsg2("Esta Seguro de Autorizar esta Orden de Entrega No. " + Numero.Text) Then
    '        Exit Sub
    '    End If
    '    '
    '    obj.IdOrden = IdOrden
    '    db.Autorizar(obj, 1)

    '    XtraMsg("La Orden de Entrega ha sido autorizada.")
    '    iVista.Columns("Autorizado").Visible = True
    '    iVista.Columns("Autorizado").OptionsColumn.AllowEdit = True
    'End Sub

    'Private Sub cmdImprimir_Click(sender As Object, e As EventArgs)

    'End Sub

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

                Dim dr_buscar() As DataRow = DT_OT.Select("Producto = '" & e.Value & "'")

                If dr_buscar.Length > 0 Then
                    XtraMsg("El Producto que intenta agregar ya se encuentra en al Lista", MessageBoxIcon.Error)
                    iVista.DeleteSelectedRows()
                    Exit Sub
                End If

                iVista.SetRowCellValue(e.RowHandle, "Precio", DR.Item("Precio"))
                iVista.SetRowCellValue(e.RowHandle, "Precio U$", DR.Item("Precio") / tTasa.EditValue)
                iVista.SetRowCellValue(e.RowHandle, "Tipo", DR.Item("Tipo"))
                iVista.SetRowCellValue(e.RowHandle, "Cantidad", 1.0)
                iVista.SetRowCellValue(e.RowHandle, "Fisico", 0.00)
                iVista.SetRowCellValue(e.RowHandle, "Autorizado", 0.00)
                iVista.SetRowCellValue(e.RowHandle, "Entregado", 0.00)
                iVista.SetRowCellValue(e.RowHandle, "IVA", IIf(DR.Item("Exento"), 0.00, CDbl(DR.Item("Precio") * (ConfigDetalles.IVA / 100))))
                iVista.SetRowCellValue(e.RowHandle, "SubTotal", DR.Item("Precio"))
                iVista.SetRowCellValue(e.RowHandle, "Agrupar", "")

                Temp = False

            End If
        End If
        '
        If e.Column.FieldName = "Cantidad Entregar" And Not Temp Then

            Dim DR As DataRowView = cbItems.GetRowByKeyValue(iVista.GetRowCellValue(e.RowHandle, "Producto"))
            '
            If Not DR Is Nothing Then
                If e.Value <> 0 Then
                    Temp = True
                    iVista.SetRowCellValue(e.RowHandle, "Real", Math.Round(CDbl(e.Value * DR.Item("Factor")), 2))
                    Temp = False
                End If
            End If
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

            Dim DR As DataRowView = cbItems.GetRowByKeyValue(iVista.GetRowCellValue(e.RowHandle, "Producto"))

            iVista.SetRowCellValue(e.RowHandle, "SubTotal", (IsNull(iVista.GetRowCellValue(e.RowHandle, "Cantidad"), 1.0)) *
                                                             IsNull(iVista.GetRowCellValue(e.RowHandle, "Precio"), 0.0))

            If DR.Item("Exento") Then
                iVista.SetRowCellValue(e.RowHandle, "IVA", 0.0)
            Else
                iVista.SetRowCellValue(e.RowHandle, "IVA", IsNull(iVista.GetRowCellValue(e.RowHandle, "SubTotal") * (ConfigDetalles.IVA / 100.0), 0))
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
        If frmOrdenesEntregaNew.Created Then frmOrdenesEntregaNew.Cargar()
    End Sub

    Private Sub iVista_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles iVista.ValidateRow
        If iVista.GetRowCellValue(e.RowHandle, "Cantidad Entregar") > iVista.GetRowCellValue(e.RowHandle, "Saldo") Then
            e.ErrorText = "No se puede entregar mas del Saldo Pendiente." & vbCrLf
            e.Valid = False
        End If

    End Sub

    Private Sub frmOrdenesEntregaRemision_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Close()
    End Sub

    Private Sub rTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rTipo.SelectedIndexChanged
        If rTipo.EditValue = 1 Then
            If EmpresaActual = 1 Then
                lyOrigen.Text = "Sucursal: "
                Combo(cbSucursal, ObtieneDatos("sp_GetSucursalesxUsuario", EmpresaActual, Usuario_ID), "[Seleccione Sucursal]")
            End If
            '
            If EmpresaActual <> 1 Then
                lyOrigen.Text = "Bodega: "
                GetBodegasxUsuario(cbSucursal, 0)
            End If

            lyDestino.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lyMovimiento.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            '
            iVista.Columns("Real").Visible = False
        ElseIf rTipo.EditValue = 2 Then
                ValidarTraslado()
        End If
    End Sub

    Sub ValidarTraslado()
        lyOrigen.Text = "Origen"

        lyDestino.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lyMovimiento.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

        GetBodegasxUsuario(cbSucursal, 0)
        cbSucursal.EditValue = obj_Ordenes.Destino
        '
        LookUp(cbMovimientos, ObtieneDatos("sp_Get_TipoMovimientos_Traslados", EmpresaActual), "Nombre", "Codigo", "[Seleccione Movimiento]", 0, 2)
        cbMovimientos.ItemIndex = 0
        GetBodegasList(cbDestino)
        '
        iVista.Columns("Real").Visible = True
    End Sub

    Private Sub iVista_ShowingEditor(sender As Object, e As CancelEventArgs) Handles iVista.ShowingEditor
        If iVista.GetRowCellValue(iVista.FocusedRowHandle, "Saldo") = 0.00 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub cbCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cbCliente.EditValueChanged

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