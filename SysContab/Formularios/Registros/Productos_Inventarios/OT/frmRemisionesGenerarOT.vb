Imports ClasesBLL
Imports System.Linq
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI

Public Class frmRemisionesGenerarOT

    Private DetallesCliente As New VB.SysContab.ClientesDetails

    'Dim obj As New Remisiones
    'Dim db As New db_Remisiones

    'Dim obj_detalle As New RemisionesDetalle
    'Dim db_detalle As New db_RemisionesDetalle

    'Private Config As New VB.SysContab.ConfiguracionDB
    'Private ConfigDetalles As New VB.SysContab.ConfiguracionDetails

    Dim obj As New OrdenesTrabajo
    Dim db As New db_OrdenesTrabajo

    Dim obj_detalle As New OrdenesTrabajoDetalle
    Dim db_detalle As New db_OrdenesTrabajoDetalle

    Public IdRemision As Integer = 0
    Private Temp As Boolean = False

    Dim DT_OT As DataTable = New DataTable("Remision")
    Public DT_ROL As DataTable

    Private Sub frmOrdenesEntregaAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        Fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date

        CargarCombos()
        Cargar()
    End Sub

    Sub CargarCombos()

        RepositorySearchLook(cbCliente,
                              VB.SysContab.ClientesDB.GetList(1).Tables("CLIENTES"),
                             "Nombre",
                             "Codigo", 3, 4, 5, 6, 7, 8)

        RepositoryItemLookUpEdit(cbTipo,
                                 ObtieneDatos("sp_OrdenesTrabajo_TipoMantenimiento", 0),
                                 "Nombre",
                                 "Codigo", 0)

        Combo(cbTecnicos, ObtieneDatos("sp_VENDEDORES_GetTecnicos", EmpresaActual), "[Seleccione Técnico]")

        Combo(cbBodega, ObtieneDatos("sp_GetSucursalesxUsuario", EmpresaActual, Usuario_ID), "[Seleccione Bodega]")
        ' cbBodega.ItemIndex = 0
        cbBodega.EditValue = db_Remisiones.Detalles(IdRemision).Bodega

        RepositorySearchLook(cbItems,
                             ObtieneDatos("SP_ArticulosGetAll", "P", EmpresaActual),
                             "Codigo",
                             "Codigo",
                             3, 4, 6, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26)

        cbItems.View.Columns("PrecioU").Caption = "Precio U$"
        FormatoGrid(cbItems.View)
        '
    End Sub

    'Sub MostrarDatos()

    '    obj = db_Remisiones.Detalles(IdRemision)

    '    'Numero.Text = obj.NoRemision
    '    'Fecha.DateTime = obj.Fecha
    '    'cbProyectos.EditValue = obj.IdProyecto
    '    'cbCliente.EditValue = obj.IdCliente
    '    'ANombre.Text = obj.ANombre
    '    'cbMoneda.EditValue = obj.Moneda
    '    'tTasa.EditValue = obj.TCambio
    '    cbBodega.EditValue = db_Remisiones.Detalles(IdRemision).Bodega
    '    'txtDireccion.Text = obj.Direccion
    '    'txtReferencia.Text = obj.Referencia
    '    'txtNoPlaca.Text = obj.Placa
    '    'txtTransporte.Text = obj.Transporte
    '    'txtConductor.Text = obj.Conductor
    '    'txtObservaciones.Text = obj.Concepto
    '    'chkExento.Checked = obj.Exento
    '    '
    '    'If obj.Estado <> "P" Then
    '    '    bGuardar.Enabled = False
    '    '    If obj.Estado = "E" Then
    '    '        cbProyectos.Properties.ReadOnly = True
    '    '        cbCliente.Properties.ReadOnly = True
    '    '    End If

    '    'End If

    'End Sub

    Public Sub Cargar()

        DT_OT = db_RemisionesDetalle.ListarOT(IdRemision)
        iVista.PopulateColumns()
        iGrid.DataSource = DT_OT
        FormatoGrid(iVista, 4, 0, False, True, False)

        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
        Next

        iVista.Columns("IdDetalle").Visible = False
        iVista.Columns("Tipo").Visible = False
        iVista.Columns("Costo").Visible = False

        'iVista.Columns("IVA").Visible = False
        'iVista.Columns("Precio").Visible = False
        'iVista.Columns("Precio U$").Visible = False
        'iVista.Columns("SubTotal").Visible = False
        'iVista.Columns("Exento").Visible = False
        '
        'iVista.Columns("Producto").OptionsColumn.AllowEdit = True
        iVista.Columns("Cantidad Ingresar").OptionsColumn.AllowEdit = True
        iVista.Columns("Cliente").OptionsColumn.AllowEdit = True
        iVista.Columns("Tipo Mantenimiento").OptionsColumn.AllowEdit = True
        iVista.Columns("No. Documento").OptionsColumn.AllowEdit = True

        iVista.Columns("Producto").ColumnEdit = cbItems
        iVista.Columns("Cliente").ColumnEdit = cbCliente
        iVista.Columns("Tipo Mantenimiento").ColumnEdit = cbTipo
        iVista.Columns("Cantidad").ColumnEdit = tMonto
        iVista.Columns("Cantidad Ingresar").ColumnEdit = tMonto
        'iVista.Columns("Existencia").ColumnEdit = tMonto
        'iVista.Columns("Precio").ColumnEdit = tMonto
        'iVista.Columns("Precio U$").ColumnEdit = tMonto
        'iVista.Columns("IVA").ColumnEdit = tMonto

        iVista.Columns("Producto").VisibleIndex = 0
        iVista.Columns("Nombre").VisibleIndex = 1
        ' iVista.Columns("Existencia").VisibleIndex = 2
        iVista.Columns("Cantidad Ingresar").VisibleIndex = 3
        ' iVista.Columns("Costo").VisibleIndex = 4
        iVista.Columns("Cliente").VisibleIndex = 5
        iVista.Columns("Tipo Mantenimiento").VisibleIndex = 6
        iVista.Columns("No. Documento").VisibleIndex = 7

        'If EmpresaActual <> 1 Then
        '    iVista.Columns("Factor").Visible = False
        '    iVista.Columns("Real").Visible = False
        'End If
        ''
        'Dim TC As DataTable = ObtieneDatos("_GetListTasaCambioDisponibles", EmpresaActual)

        'If TC.Rows.Count > 0 Then
        '    Dim dr() As DataRow = TC.Select("MonedaCambio = '" & MonedaBase & "'")
        '    If dr.Length > 0 Then
        '        iVista.Columns("Precio").Caption = "Precio " & dr(0).Item("Simbolo").ToString
        '        lyTotal.Text = "Total " & dr(0).Item("Simbolo").ToString & ":"
        '    End If
        'End If
    End Sub

    'Private Sub Fecha_EditValueChanged(sender As Object, e As EventArgs) Handles Fecha.EditValueChanged
    '    tTasa.EditValue = GetTasaCambioDia(Fecha.DateTime.Date)
    'End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        Dim ValidaCliente As Boolean = True,
            ValidaDocumento As Boolean = True

        For i As Integer = 0 To iVista.DataRowCount - 1
            If IsNull(iVista.GetRowCellValue(i, "Cliente"), 0) = 0 Then ValidaCliente = False
            If IsNull(iVista.GetRowCellValue(i, "No. Documento"), "") = "" Then ValidaDocumento = False
        Next
        '      
        If Not ValidaCliente Then
            XtraMsg("Debe ingresar el Cliente para la Nueva O/T", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If Not ValidaDocumento Then
            XtraMsg("Debe ingresar el No. de Documeento para la Nueva O/T", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        Dim Contador As Integer = 0


        ShowSplash("Creando O/T...")
        '
        Dim Documento = From row In DT_OT.AsEnumerable()
                        Select row.Field(Of String)("No. Documento") Distinct

        For Each s As Object In Documento
            If Not s Is Nothing Then

                Dim IdOrden As Integer = 0
                Dim DT_DETALLE As DataTable = DT_OT.Select("[No. Documento] ='" & s.ToString & "'").CopyToDataTable

                obj.IdOrden = IdOrden
                obj.NoOrden = db_OrdenesTrabajo.GetNumero()
                obj.Documento = s.ToString()
                obj.Fecha = Fecha.DateTime.Date
                obj.Tipo_Mantenimiento = DT_DETALLE.Rows.Item(0)("Tipo Mantenimiento")
                obj.IdCliente = DT_DETALLE.Rows.Item(0)("Cliente")
                obj.IdVendedor = cbTecnicos.EditValue
                obj.Bodega = cbBodega.EditValue
                obj.Fallas_Equipo = txtFallas.Text
                obj.Trabajo_Realizado = txtTrabajo.Text
                obj.Observaciones = ""
                obj.Monto = 0.00
                obj.SubTotal = 0.00
                obj.IVA = 0.00
                obj.Total = 0.00
                obj.TCambio = GetTasaCambioDia(Fecha.DateTime.Date)
                obj.Tipo = 3
                obj.IdRemision = IdRemision
                '
                IdOrden = db.Insertar(obj)

                For i As Integer = 0 To DT_DETALLE.Rows.Count - 1
                    obj_detalle.IdOrden = IdOrden
                    obj_detalle.Tipo = DT_DETALLE.Rows.Item(i)("Tipo")
                    obj_detalle.Producto = DT_DETALLE.Rows.Item(i)("Producto")
                    obj_detalle.Cantidad = DT_DETALLE.Rows.Item(i)("Cantidad Ingresar")
                    obj_detalle.Precio = 0.00       'IsNull(_DT_DTL.Rows.Item(i)("Precio"), 0.00)
                    obj_detalle.IVA = 0.00          'IsNull(_DT_DTL.Rows.Item(i)("IVA"), 0.00)
                    obj_detalle.Descuento = 0.00
                    obj_detalle.Total = 0.00        'IsNull(_DT_DTL.Rows.Item(i)("SubTotal"), 0.00)
                    obj_detalle.Descripcion = DT_DETALLE.Rows.Item(i)("Nombre") 'IsNull(_DT_DTL.Rows.Item(i)("Descripcion"), "")

                    db_detalle.Insertar(obj_detalle)
                Next

                Contador += 1
            End If
        Next
        'Actualizar estado de la Remision
        db_Remisiones.UpdateEstado(IdRemision, "O")

        HideSplash()
        XtraMsg("Se han creado con Exito ( " & Contador.ToString & " ) Ordenes de Trabajo!")

        Close()
        If frmRemisionesCliente.Created Then frmRemisionesCliente.Cargar()
    End Sub

    Sub Imprimir()
        ShowSplash("Imprimiendo...")

        Dim Temp As Boolean = db_Formatos.FormatoImpreso(10, "rptRemisiones")

        Dim rpt As rptRemisiones

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptRemisiones.repx", True)
        Else
            rpt = New rptRemisiones
        End If

        rpt.DT_ROL = DT_ROL
        'rpt.DataSource = ObtieneDatos("sp_sel_Remisiones_Imprimir", IdRemision, EmpresaActual)
        VistaPreviaDX(rpt,
                      db_Remisiones.Imprimir(IdRemision),
                      "Remisión de Bodega No. " & db_Remisiones.Detalles(IdRemision).NoRemision)
        HideSplash()


        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        ''
        'HideSplash()
        'rpt.ShowRibbonPreview()
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, "Detalle de Remisión No. " + db_Remisiones.Detalles(IdRemision).NoRemision)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub iVista_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles iVista.CellValueChanged
        'If e.Column.FieldName = "Cantidad Ingresar" Then

        'End If




        'If e.Column.FieldName = "Producto" Then
        '    Dim DR As DataRowView = cbItems.GetRowByKeyValue(e.Value)

        '    If Not DR Is Nothing Then
        '        Temp = True

        '        Dim dr_buscar() As DataRow = DT_OT.Select("Producto = '" & e.Value & "'")

        '        If dr_buscar.Length > 0 Then
        '            XtraMsg("El Producto que intenta agregar ya se encuentra en al Lista", MessageBoxIcon.Error)
        '            iVista.DeleteSelectedRows()
        '            Exit Sub
        '        End If

        '        iVista.SetRowCellValue(e.RowHandle, "Nombre", DR.Item("Nombre"))
        '        iVista.SetRowCellValue(e.RowHandle, "Precio", DR.Item("Precio"))
        '        '    iVista.SetRowCellValue(e.RowHandle, "Precio U$", DR.Item("Precio") / tTasa.EditValue)
        '        iVista.SetRowCellValue(e.RowHandle, "Tipo", DR.Item("Tipo"))
        '        iVista.SetRowCellValue(e.RowHandle, "Cantidad", 1.0)
        '        iVista.SetRowCellValue(e.RowHandle, "Factor", DR.Item("Factor"))
        '        iVista.SetRowCellValue(e.RowHandle, "Real", DR.Item("Factor"))
        '        iVista.SetRowCellValue(e.RowHandle, "Fisico", 0.00)
        '        iVista.SetRowCellValue(e.RowHandle, "Autorizado", 0.00)
        '        iVista.SetRowCellValue(e.RowHandle, "Entregado", 0.00)
        '        'iVista.SetRowCellValue(e.RowHandle, "IVA", IIf(chkExento.Checked, 0.00, IIf(DR.Item("Exento"), 0.00, CDbl(DR.Item("Precio") * (ConfigDetalles.IVA / 100)))))
        '        iVista.SetRowCellValue(e.RowHandle, "SubTotal", DR.Item("Precio"))

        '        'If EmpresaActual = 1 Then
        '        '    Dim DT_PROD As DataTable = ObtieneDatos("sp_GetExistenciaRemisiones", e.Value, cbSucursal.EditValue, EmpresaActual)
        '        '    If DT_PROD.Rows.Count > 0 Then iVista.SetRowCellValue(e.RowHandle, "Existencia", DT_PROD.Rows.Item(0)("Existencia"))
        '        '    If DT_PROD.Rows.Count = 0 Then iVista.SetRowCellValue(e.RowHandle, "Existencia", 0.00)
        '        'Else
        '        '    Dim DT_PROD As DataTable = ObtieneDatos("sp_GetExistenciaOrdenEntrega", e.Value, cbSucursal.EditValue, EmpresaActual)
        '        '    If DT_PROD.Rows.Count > 0 Then iVista.SetRowCellValue(e.RowHandle, "Existencia", DT_PROD.Rows.Item(0)("Existencia"))
        '        '    If DT_PROD.Rows.Count = 0 Then iVista.SetRowCellValue(e.RowHandle, "Existencia", 0.00)
        '        'End If

        '        Temp = False
        '    End If
        'End If

        'If e.Column.FieldName = "Precio" And Not Temp Then
        '    If e.Value <> 0 Then
        '        Temp = True
        '        iVista.SetRowCellValue(e.RowHandle, "Precio U$", CDbl(e.Value / tTasa.EditValue).ToString(RoundP))
        '        Temp = False
        '    End If
        'End If
        ''
        'If e.Column.FieldName = "Precio U$" And Not Temp Then
        '    If e.Value <> 0 Then
        '        Temp = True
        '        iVista.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * tTasa.EditValue).ToString(RoundP))
        '        Temp = False
        '    End If
        'End If

        'If e.Column.FieldName = "Precio" Or
        '   e.Column.FieldName = "Precio U$" Or
        '   e.Column.FieldName = "Cantidad" And Not Temp Then

        '    Dim DR As DataRowView = cbItems.GetRowByKeyValue(iVista.GetRowCellValue(e.RowHandle, "Producto"))

        '    iVista.SetRowCellValue(e.RowHandle, "Real", IsNull(iVista.GetRowCellValue(e.RowHandle, "Cantidad"), 1.0) * IsNull(iVista.GetRowCellValue(e.RowHandle, "Factor"), 1.0))

        '    iVista.SetRowCellValue(e.RowHandle, "SubTotal", (IsNull(iVista.GetRowCellValue(e.RowHandle, "Real"), 1.0)) *
        '                                                     IsNull(iVista.GetRowCellValue(e.RowHandle, "Precio"), 0.0))

        '    If chkExento.Checked Then
        '        iVista.SetRowCellValue(e.RowHandle, "IVA", 0.0)
        '    Else
        '        If DR.Item("Exento") Then
        '            iVista.SetRowCellValue(e.RowHandle, "IVA", 0.0)
        '        Else
        '            iVista.SetRowCellValue(e.RowHandle, "IVA", IsNull(iVista.GetRowCellValue(e.RowHandle, "SubTotal") * (ConfigDetalles.IVA / 100.0), 0))
        '        End If
        '    End If
        'End If

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
        'tSubTotal.EditValue = iVista.Columns("SubTotal").SummaryItem.SummaryValue
        'tIva.EditValue = iVista.Columns("IVA").SummaryItem.SummaryValue
        'tTotal.EditValue = tSubTotal.EditValue + tIva.EditValue
        'tTotalU.EditValue = tTotal.EditValue / tTasa.EditValue
    End Sub

    Private Sub frmOrdenesEntregaAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        '  If frmRemisionesCliente.Created Then frmRemisionesCliente.Cargar()
    End Sub

    Private Sub frmOrdenesEntregaRemision_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '  If e.KeyCode = Keys.Escape Then Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If IdRemision <> 0 Then Imprimir()
    End Sub

    Private Sub iVista_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles iVista.ValidateRow
        If iVista.GetRowCellValue(e.RowHandle, "Cantidad Ingresar") > iVista.GetRowCellValue(e.RowHandle, "Cantidad") Then
            e.ErrorText = "La Cantidad a Ingresar no puede ser Mayor que la Cantidad Registrada en la Remisión." & vbCrLf
            e.Valid = False
        End If
    End Sub


    'Sub ReCalcularIVA()
    '    For i As Integer = 0 To iVista.DataRowCount - 1

    '        Dim DR As DataRowView = cbItems.GetRowByKeyValue(iVista.GetRowCellValue(i, "Item"))

    '        ' Dim Config As New VB.SysContab.ConfiguracionDB
    '        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
    '        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails
    '        DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cbCliente.EditValue)

    '        If DetallesCliente.Excento = True Then
    '            iVista.SetRowCellValue(i, "IVA", 0.0)
    '        Else
    '            If chkExento.Checked Then
    '                iVista.SetRowCellValue(i, "IVA", 0.0)
    '            Else
    '                If Not DR Is Nothing Then
    '                    If DR.Item("Exento") = False Then
    '                        iVista.SetRowCellValue(i, "IVA", IsNull(iVista.GetRowCellValue(i, "SubTotal") * (ConfigDetalles.IVA / 100.0), 0))
    '                    Else
    '                        iVista.SetRowCellValue(i, "IVA", 0.0)
    '                    End If
    '                End If
    '            End If
    '        End If
    '        'If CheckEdit1.Checked Then iVista.SetRowCellValue(i, "IVA", 0.0)
    '    Next
    '    '
    '    If iVista.DataRowCount > 0 Then
    '        iVista.RefreshData()
    '        iVista.UpdateTotalSummary()
    '        Totales()
    '    End If
    'End Sub

    'Private Sub cbProyectos_EditValueChanged(sender As Object, e As EventArgs)
    '    If cbProyectos.EditValue <> 0 Then
    '        cbCliente.EditValue = cbProyectos.Properties.View.GetRowCellValue(cbProyectos.Properties.View.FocusedRowHandle, "IdCliente")
    '        cbCliente.ReadOnly = True
    '        '
    '        txtReferencia.Text = cbProyectos.Properties.View.GetRowCellValue(cbProyectos.Properties.View.FocusedRowHandle, "Codigo")
    '    Else
    '        cbCliente.EditValue = 0
    '        cbCliente.ReadOnly = False
    '        '
    '        txtReferencia.Text = ""
    '    End If
    'End Sub

End Class