Imports System.IO
Imports ClasesBLL
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI

Public Class frmRemisionesClienteAdd

    Private DetallesCliente As New VB.SysContab.ClientesDetails

    Dim obj As New Remisiones
    Dim db As New db_Remisiones

    Dim obj_detalle As New RemisionesDetalle
    Dim db_detalle As New db_RemisionesDetalle

    Private Config As New VB.SysContab.ConfiguracionDB
    Private ConfigDetalles As New VB.SysContab.ConfiguracionDetails

    Public IdRemision As Integer = 0
    Private Temp As Boolean = False

    Dim DT_OT As DataTable = New DataTable("Remision")
    Public DT_ROL As DataTable

    Private Sub frmOrdenesEntregaAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        ShowSplash("Cargando Orden...")

        Fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date
        CargarCombos()
        Cargar()
        MostrarDatos()
        '
        'Validar si el usuario tiene autorizado ver los precios
        If DT_ROL.Rows.Count > 0 Then
            Dim dr() As DataRow = DT_ROL.Select("Control = 'VerPrecios'")
            If dr.Length > 0 Then MostrarPrecios()
        End If
        '
        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails()
        Totales()
        '
        HideSplash()
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
        SearchLookUp(
            cbProyectos,
            db_Proyectos.Fill(IIf(IdRemision = 0, 1, 0)),
            "Nombre",
            "IdProyecto", 0, 6, 7, 8)
        cbProyectos.EditValue = 0

        SearchLookUp(cbCliente, VB.SysContab.ClientesDB.GetList(1).Tables("CLIENTES"), "Nombre", "Codigo", 3, 4, 5, 6, 7, 8)
        GetMonedasList(cbMoneda)

        Combo(cbSucursal, ObtieneDatos("sp_GetSucursalesxUsuario", EmpresaActual, Usuario_ID), "[Seleccione Sucursal]")
        cbSucursal.ItemIndex = 0

        RepositorySearchLook(cbItems, ObtieneDatos("SP_ArticulosGetAll", "P", EmpresaActual), "Codigo", "Codigo", 3, 4, 6, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26)
        cbItems.View.Columns("PrecioU").Caption = "Precio U$"
        FormatoGrid(cbItems.View)
        '
        'SearchLookUp(cbProyectos, db_Proyectos.Fill(), "Nombre", "IdProyecto", 0, 6, 7, 8)
        'cbProyectos.EditValue = 0
    End Sub

    Sub MostrarDatos()
        If IdRemision = 0 Then
            Numero.Text = db_Remisiones.GetNumero()
            tTasa.EditValue = GetTasaCambioDia(Fecha.DateTime.Date)
        Else
            obj = db_Remisiones.Detalles(IdRemision)

            Numero.Text = obj.NoRemision
            Fecha.DateTime = obj.Fecha
            cbProyectos.EditValue = obj.IdProyecto
            cbCliente.EditValue = obj.IdCliente
            ANombre.Text = obj.ANombre
            cbMoneda.EditValue = obj.Moneda
            tTasa.EditValue = obj.TCambio
            cbSucursal.EditValue = IIf(EmpresaActual = 1, obj.Sucursal, obj.Bodega)
            txtDireccion.Text = obj.Direccion
            txtReferencia.Text = obj.Referencia
            txtNoPlaca.Text = obj.Placa
            txtTransporte.Text = obj.Transporte
            txtConductor.Text = obj.Conductor
            txtObservaciones.Text = obj.Concepto
            chkExento.Checked = obj.Exento
            '
            If obj.Estado <> "P" Then
                bGuardar.Enabled = False
                If obj.Estado = "E" Then
                    cbProyectos.Properties.ReadOnly = True
                    cbCliente.Properties.ReadOnly = True
                End If
            End If
        End If
    End Sub

    Public Sub Cargar()
        DT_OT = db_RemisionesDetalle.Listar(IdRemision)
        iVista.PopulateColumns()
        iGrid.DataSource = DT_OT
        FormatoGrid(iVista, 4, 0, False, True, False)

        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
        Next

        iVista.Columns("IdDetalle").Visible = False
        iVista.Columns("Tipo").Visible = False
        iVista.Columns("IVA").Visible = False
        iVista.Columns("Precio").Visible = False
        iVista.Columns("Precio U$").Visible = False
        iVista.Columns("Costo").Visible = False
        iVista.Columns("SubTotal").Visible = False
        iVista.Columns("Exento").Visible = False
        '
        iVista.Columns("Producto").OptionsColumn.AllowEdit = True
        iVista.Columns("Cantidad").OptionsColumn.AllowEdit = True
        iVista.Columns("Precio").OptionsColumn.AllowEdit = True
        iVista.Columns("Precio U$").OptionsColumn.AllowEdit = True
        iVista.Columns("Agrupar").OptionsColumn.AllowEdit = True

        iVista.Columns("Producto").ColumnEdit = cbItems
        iVista.Columns("Cantidad").ColumnEdit = tMonto
        iVista.Columns("Precio").ColumnEdit = tMonto
        iVista.Columns("Precio U$").ColumnEdit = tMonto
        iVista.Columns("IVA").ColumnEdit = tMonto
        iVista.Columns("Existencia").ColumnEdit = tMonto

        iVista.Columns("Producto").VisibleIndex = 0
        iVista.Columns("Nombre").VisibleIndex = 1
        iVista.Columns("Existencia").VisibleIndex = 2
        iVista.Columns("Cantidad").VisibleIndex = 3
        iVista.Columns("Factor").VisibleIndex = 4
        iVista.Columns("Real").VisibleIndex = 5
        iVista.Columns("Precio U$").VisibleIndex = 6
        iVista.Columns("Precio").VisibleIndex = 7
        iVista.Columns("SubTotal").VisibleIndex = 8

        If EmpresaActual <> 1 Then
            iVista.Columns("Factor").Visible = False
            iVista.Columns("Real").Visible = False
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
        If iVista.DataRowCount = 0 Then
            XtraMsg("Debe agregar al menos 1 Producto!", MessageBoxIcon.Error)
            Exit Sub
        End If
        '      
        'Validar Limite de Credito
        DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cbCliente.EditValue)
        '
        If DetallesCliente.ValidarLimite Then
            Dim Saldo As Double = ObtieneDatos("SELECT isnull(dbo.fn_JAR_GetSaldoCliente(" & cbCliente.EditValue & "," & EmpresaActual & "),0.00) Saldo").Rows.Item(0)("Saldo")
            '
            If MonedaBase = DetallesCliente.Moneda Then
                If Saldo <= 0 Then
                    lyMsg.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    lblMsg.Text = "El Cliente No Tiene Saldo Disponible para facturación, Saldo = C$: " & Saldo.ToString("n2")
                    XtraMsg("El Cliente No Tiene Saldo Disponible para facturación, Saldo = C$: " & Saldo.ToString("n2"), MessageBoxIcon.Warning)
                    Exit Sub
                Else
                    If CDbl(tTotal.Text) > Saldo Then
                        lyMsg.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                        lblMsg.Text = "El Cliente No Tiene Saldo Disponible para facturación, Saldo = C$: " & Saldo.ToString("n2")
                        XtraMsg("El Cliente No Tiene Saldo Disponible para facturación, Saldo = C$: " & Saldo.ToString("n2"), MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End If
            Else
                If Saldo <= 0 Then
                    lyMsg.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    lblMsg.Text = "El Cliente No Tiene Saldo Disponible para facturación, Saldo = U$: " & Saldo.ToString("n2")
                    XtraMsg("El Cliente No Tiene Saldo Disponible para facturación, Saldo = U$: " & Saldo.ToString("n2"), MessageBoxIcon.Warning)
                    Exit Sub
                Else
                    If CDbl(tTotalU.Text) > Saldo Then
                        lyMsg.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                        lblMsg.Text = "El Cliente No Tiene Saldo Disponible para facturación, Saldo = U$: " & Saldo.ToString("n2")
                        XtraMsg("El Cliente No Tiene Saldo Disponible para facturación, Saldo = U$: " & Saldo.ToString("n2"), MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End If
            End If
        Else
            lyMsg.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lblMsg.Text = ""
        End If

        obj.IdRemision = IdRemision
        obj.NoOrden = ""
        obj.NoRemision = Numero.Text
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
        obj.Exento = chkExento.Checked
        obj.Bodega = cbSucursal.EditValue
        obj.ANombre = ANombre.Text

        If IdRemision = 0 Then
            ShowSplash("Guardando Remisión...")

            IdRemision = db.Insertar(obj)

            Dim _DT_DTL As DataTable = DT_OT.GetChanges(DataRowState.Added Or DataRowState.Modified)

            If Not _DT_DTL Is Nothing Then
                For i As Integer = 0 To _DT_DTL.Rows.Count - 1
                    obj_detalle.IdRemision = IdRemision
                    obj_detalle.Tipo = _DT_DTL.Rows.Item(i)("Tipo")
                    obj_detalle.Producto = _DT_DTL.Rows.Item(i)("Producto")
                    obj_detalle.Cantidad = _DT_DTL.Rows.Item(i)("Cantidad")
                    obj_detalle.Precio = IsNull(_DT_DTL.Rows.Item(i)("Precio"), 0.00)
                    obj_detalle.IVA = IIf(chkExento.Checked, 0.00, IsNull(_DT_DTL.Rows.Item(i)("IVA"), 0.00))
                    obj_detalle.Descuento = 0.00
                    obj_detalle.Total = IsNull(_DT_DTL.Rows.Item(i)("SubTotal"), 0.00)
                    obj_detalle.Agrupar = IsNull(_DT_DTL.Rows.Item(i)("Agrupar"), "")

                    db_detalle.Insertar(obj_detalle)
                Next
            End If

            HideSplash()

            XtraMsg("La Remisión No. " + db_Remisiones.Detalles(IdRemision).NoRemision + " se ha creado con exito!")
            Imprimir()

            Close()
            If frmRemisionesCliente.Created Then frmRemisionesCliente.Cargar()
        Else
            ShowSplash("Actualizando Orden...")

            db.Actualizar(obj)

            Dim _DT_UPD As DataTable = DT_OT.GetChanges(DataRowState.Modified)

            If Not _DT_UPD Is Nothing Then
                For i As Integer = 0 To _DT_UPD.Rows.Count - 1
                    obj_detalle.IdDetalle = _DT_UPD.Rows.Item(i)("IdDetalle")
                    obj_detalle.IdRemision = IdRemision
                    obj_detalle.Tipo = _DT_UPD.Rows.Item(i)("Tipo")
                    obj_detalle.Producto = _DT_UPD.Rows.Item(i)("Producto")
                    obj_detalle.Cantidad = _DT_UPD.Rows.Item(i)("Cantidad")
                    obj_detalle.Precio = IsNull(_DT_UPD.Rows.Item(i)("Precio"), 0.00)
                    obj_detalle.IVA = IIf(chkExento.Checked, 0.00, IsNull(_DT_UPD.Rows.Item(i)("IVA"), 0.00))
                    obj_detalle.Descuento = 0.00
                    obj_detalle.Total = IsNull(_DT_UPD.Rows.Item(i)("SubTotal"), 0.00)
                    obj_detalle.Agrupar = IsNull(_DT_UPD.Rows.Item(i)("Agrupar"), "")

                    db_detalle.Actualizar(obj_detalle)
                Next
            End If
            ''
            'Agregar Nuevos Registros
            Dim _DT_NEW As DataTable = DT_OT.GetChanges(DataRowState.Added)

            If Not _DT_NEW Is Nothing Then
                For i As Integer = 0 To _DT_NEW.Rows.Count - 1
                    obj_detalle.IdRemision = IdRemision
                    obj_detalle.Tipo = _DT_NEW.Rows.Item(i)("Tipo")
                    obj_detalle.Producto = _DT_NEW.Rows.Item(i)("Producto")
                    obj_detalle.Cantidad = _DT_NEW.Rows.Item(i)("Cantidad")
                    obj_detalle.Precio = IsNull(_DT_NEW.Rows.Item(i)("Precio"), 0.00)
                    obj_detalle.IVA = IIf(chkExento.Checked, 0.00, IsNull(_DT_NEW.Rows.Item(i)("IVA"), 0.00))
                    obj_detalle.Descuento = 0.00
                    obj_detalle.Total = IsNull(_DT_NEW.Rows.Item(i)("SubTotal"), 0.00)
                    obj_detalle.Agrupar = IsNull(_DT_NEW.Rows.Item(i)("Agrupar"), "")

                    db_detalle.Insertar(obj_detalle)
                Next
            End If
            ''
            'Borrar Linea
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
            If frmRemisionesCliente.Created Then frmRemisionesCliente.Cargar()
        End If
    End Sub

    Sub Imprimir()
        ShowSplash("Imprimiendo...")

        'Dim Cadena As String, Tamano As Integer
        'Dim Temp As Boolean = False
        'Dim Data() As Byte

        'Try
        '    Data = CType(ObtieneDatos("sp_get_formato_imprimir", 10, EmpresaActual).Rows(0).Item(0), Byte())
        '    Temp = True
        '    '
        '    Tamano = Data.GetUpperBound(0)
        '    Cadena = Application.StartupPath & "\rptRemisiones.repx"
        '    If File.Exists(Cadena) Then Kill(Cadena)
        '    Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
        '    Archivo.Write(Data, 0, Tamano)
        '    Archivo.Close()
        'Catch ex As Exception
        '    Temp = False
        'End Try

        Dim Temp As Boolean = db_Formatos.FormatoImpreso(10, "rptRemisiones")

        Dim rpt As rptRemisiones

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptRemisiones.repx", True)
        Else
            rpt = New rptRemisiones
        End If

        rpt.DT_ROL = DT_ROL
        'rpt.DataSource = ObtieneDatos("sp_sel_Remisiones_Imprimir", IdRemision, EmpresaActual)
        VistaPreviaDX(rpt, db_Remisiones.Imprimir(IdRemision), "Remisión de Bodega No. " & Numero.Text)
        HideSplash()


        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        ''
        'HideSplash()
        'rpt.ShowRibbonPreview()
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, "Detalle de Remisión No. " + Numero.Text)
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

                iVista.SetRowCellValue(e.RowHandle, "Nombre", DR.Item("Nombre"))
                iVista.SetRowCellValue(e.RowHandle, "Precio", DR.Item("Precio"))
                iVista.SetRowCellValue(e.RowHandle, "Precio U$", DR.Item("Precio") / tTasa.EditValue)
                iVista.SetRowCellValue(e.RowHandle, "Tipo", DR.Item("Tipo"))
                iVista.SetRowCellValue(e.RowHandle, "Cantidad", 1.0)
                iVista.SetRowCellValue(e.RowHandle, "Factor", DR.Item("Factor"))
                iVista.SetRowCellValue(e.RowHandle, "Real", DR.Item("Factor"))
                iVista.SetRowCellValue(e.RowHandle, "Fisico", 0.00)
                iVista.SetRowCellValue(e.RowHandle, "Autorizado", 0.00)
                iVista.SetRowCellValue(e.RowHandle, "Entregado", 0.00)
                iVista.SetRowCellValue(e.RowHandle, "IVA", IIf(chkExento.Checked, 0.00, IIf(DR.Item("Exento"), 0.00, CDbl(DR.Item("Precio") * (ConfigDetalles.IVA / 100)))))
                iVista.SetRowCellValue(e.RowHandle, "SubTotal", DR.Item("Precio"))

                If EmpresaActual = 1 Then
                    Dim DT_PROD As DataTable = ObtieneDatos("sp_GetExistenciaRemisiones", e.Value, cbSucursal.EditValue, EmpresaActual)
                    If DT_PROD.Rows.Count > 0 Then iVista.SetRowCellValue(e.RowHandle, "Existencia", DT_PROD.Rows.Item(0)("Existencia"))
                    If DT_PROD.Rows.Count = 0 Then iVista.SetRowCellValue(e.RowHandle, "Existencia", 0.00)
                Else
                    Dim DT_PROD As DataTable = ObtieneDatos("sp_GetExistenciaOrdenEntrega", e.Value, cbSucursal.EditValue, EmpresaActual)
                    If DT_PROD.Rows.Count > 0 Then iVista.SetRowCellValue(e.RowHandle, "Existencia", DT_PROD.Rows.Item(0)("Existencia"))
                    If DT_PROD.Rows.Count = 0 Then iVista.SetRowCellValue(e.RowHandle, "Existencia", 0.00)
                End If

                Temp = False
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

            iVista.SetRowCellValue(e.RowHandle, "Real", IsNull(iVista.GetRowCellValue(e.RowHandle, "Cantidad"), 1.0) * IsNull(iVista.GetRowCellValue(e.RowHandle, "Factor"), 1.0))

            iVista.SetRowCellValue(e.RowHandle, "SubTotal", (IsNull(iVista.GetRowCellValue(e.RowHandle, "Real"), 1.0)) *
                                                             IsNull(iVista.GetRowCellValue(e.RowHandle, "Precio"), 0.0))

            If chkExento.Checked Then
                iVista.SetRowCellValue(e.RowHandle, "IVA", 0.0)
            Else
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
        '  If frmRemisionesCliente.Created Then frmRemisionesCliente.Cargar()
    End Sub

    Private Sub frmOrdenesEntregaRemision_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '  If e.KeyCode = Keys.Escape Then Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If IdRemision <> 0 Then Imprimir()
    End Sub

    Private Sub chkExento_CheckedChanged(sender As Object, e As EventArgs) Handles chkExento.CheckedChanged
        If Not Inicio Then ReCalcularIVA()
    End Sub

    Sub ReCalcularIVA()
        For i As Integer = 0 To iVista.DataRowCount - 1

            Dim DR As DataRowView = cbItems.GetRowByKeyValue(iVista.GetRowCellValue(i, "Item"))

            ' Dim Config As New VB.SysContab.ConfiguracionDB
            Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
            ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails
            DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cbCliente.EditValue)

            If DetallesCliente.Excento = True Then
                iVista.SetRowCellValue(i, "IVA", 0.0)
            Else
                If chkExento.Checked Then
                    iVista.SetRowCellValue(i, "IVA", 0.0)
                Else
                    If Not DR Is Nothing Then
                        If DR.Item("Exento") = False Then
                            iVista.SetRowCellValue(i, "IVA", IsNull(iVista.GetRowCellValue(i, "SubTotal") * (ConfigDetalles.IVA / 100.0), 0))
                        Else
                            iVista.SetRowCellValue(i, "IVA", 0.0)
                        End If
                    End If
                End If
            End If
            'If CheckEdit1.Checked Then iVista.SetRowCellValue(i, "IVA", 0.0)
        Next
        '
        If iVista.DataRowCount > 0 Then
            iVista.RefreshData()
            iVista.UpdateTotalSummary()
            Totales()
        End If
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