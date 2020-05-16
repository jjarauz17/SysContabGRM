Public Class frmArregloPagoAdd 

    Public IdArreglo As Integer = 0

    Dim obj As New ArregloPago
    Dim db As New db_ArregloPago

    Dim obj_Detalle As New ArregloPagoDetalle
    Dim db_Detalle As New db_ArregloPagoDetalle

    'Dim obj_Detalle As New ArregloPago

    Dim obj_Intereses As New Clientes_Intereses
    Dim DT_DETALLE As DataTable

    Private Sub cbCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cbCliente.EditValueChanged
       
    End Sub

    Sub Grid()
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False)
        iVista.Columns("IdDetalle").Visible = False        

        iVista.Columns("Factura").OptionsColumn.AllowEdit = False
        iVista.Columns("Vencimiento").OptionsColumn.AllowEdit = False
        iVista.Columns("Saldo U$").OptionsColumn.AllowEdit = False

        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
        Next

        iVista.Columns("Seleccionar").OptionsColumn.AllowEdit = True
        iVista.Columns("Seleccionar").ColumnEdit = rCheck
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        If IdArreglo = 0 Then
            ShowSplash()
            iGrid.DataSource = ObtieneDatos("JAR_GetFacturasSaldosAP", cbCliente.EditValue, FechaCorte.DateTime.Date, EmpresaActual)
            HideSplash()
        End If
    End Sub

    Private Sub frmArregloPagoAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SearchLookUp(cbCliente, ObtieneDatos("SP_GetClientes", EmpresaActual, 1), "Nombre", "Codigo", 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Fecha.DateTime = f.Date
        FechaInicial.DateTime = f.Date
        FechaCorte.DateTime = f.Date

        CargarCombos()

        If IdArreglo = 0 Then
            ' tNumero.EditValue = db_ArregloPago.GetNumero(cbSucursal.EditValue)

            obj_Intereses = db_Clientes_Intereses.Detalles()
            sInteres.EditValue = obj_Intereses.Corriente
            '
            iGrid.DataSource = ObtieneDatos("JAR_GetFacturasSaldosAP", -1, VB.SysContab.Rutinas.Fecha().Date, EmpresaActual)
            Grid()
        Else
            cbSucursal.Properties.ReadOnly = True
            cbCliente.Properties.ReadOnly = True
        End If

        DT_DETALLE = db_ArregloPagoDetalle.Listar(IdArreglo)
        iGridAP.DataSource = DT_DETALLE
        GridAP()
    End Sub

    Sub GridAP()
        iVistaAP.PopulateColumns()
        FormatoGrid(iVistaAP, 2, 0, False)
        iVistaAP.Columns("IdDetalle").Visible = False

        'For i As Integer = 0 To iVista.Columns.Count - 1
        '    iVista.Columns(i).OptionsColumn.AllowEdit = False
        'Next

        'iVista.Columns("Seleccionar").OptionsColumn.AllowEdit = True
        'iVista.Columns("Seleccionar").ColumnEdit = rCheck
    End Sub

    Sub CargarCombos()
        Application.DoEvents()
        SearchLookUp(cbCliente, ObtieneDatos("PNR_GetClientes", EmpresaActual), _
                   "Nombre", "Codigo", "[Seleccione Cliente]")
        cbCliente.Properties.PopupFormSize = New Point(900, 0)

        Application.DoEvents()
        Combo(cbSucursal, ObtieneDatos("sp_GetSucursalesxUsuario", EmpresaActual, Usuario_ID))
    End Sub

    Private Sub iVista_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVista.CellValueChanged
        CalcularSaldoAP()
    End Sub

    Sub CalcularSaldoAP()
        Dim Saldo As Double = 0.0
        For i As Integer = 0 To iVista.DataRowCount - 1
            If iVista.GetRowCellValue(i, "Seleccionar") Then
                Saldo += iVista.GetRowCellValue(i, "Saldo U$")
            End If
        Next

        lblSaldo.Text = "Saldo U$: " & Saldo.ToString("n2")
        tMonto.EditValue = Saldo
    End Sub

    Private Sub cbSucursal_EditValueChanged(sender As Object, e As EventArgs) Handles cbSucursal.EditValueChanged
        If IdArreglo = 0 Then tNumero.EditValue = db_ArregloPago.GetNumero(IIf(cbSucursal.EditValue Is Nothing, "", cbSucursal.EditValue))
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        For i As Integer = 0 To iVista.DataRowCount - 1
            iVista.SetRowCellValue(i, "Seleccionar", CheckEdit1.Checked)
        Next
        CalcularSaldoAP()
    End Sub

    Private Sub bGenerarTabla_Click(sender As Object, e As EventArgs) Handles bGenerarTabla.Click
        Try
            Dim FechaPago As Date = FechaInicial.DateTime.Date
            DT_DETALLE.Clear()
            '
            For i As Integer = 0 To CInt(sCuotas.EditValue) - 1
                Dim dr As DataRow = DT_DETALLE.NewRow

                dr("Numero") = i + 1
                dr("FechaPago") = FechaPago
                dr("Vencimiento") = FechaPago.AddDays(sDiasGracia.EditValue).Date
                dr("Cuota") = Math.Round(tMonto.EditValue / sCuotas.EditValue, 2)
                dr("Interes") = Math.Round((tMonto.EditValue / sCuotas.EditValue) * sInteres.EditValue, 2)
                dr("Aplicada") = False

                DT_DETALLE.Rows.Add(dr)

                FechaPago = FechaPago.AddMonths(1).Date
            Next

            iGridAP.DataSource = DT_DETALLE
            iGridAP.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub sCuotas_EditValueChanged(sender As Object, e As EventArgs) Handles sCuotas.EditValueChanged

    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If cbSucursal.EditValue Is Nothing Then
            XtraMsg("Seleccione la Sucursal!")
            Exit Sub
        End If
        '
        If cbCliente.EditValue Then
            XtraMsg("Seleccione el Cliente")
            Exit Sub
        End If

        Dim selec As Boolean = False

        For i As Integer = 0 To iVista.DataRowCount - 1
            If iVista.GetRowCellValue(i, "Seleccionar") Then selec = True
        Next

        If Not selec Then
            XtraMsg("Debe Seleccionar una factura al menos!", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        obj.IdArreglo = IdArreglo
        obj.Numero = IIf(IdArreglo = 0, db_ArregloPago.GetNumero(cbSucursal.EditValue), tNumero.EditValue)
        obj.IdCliente = cbCliente.EditValue
        obj.FechaSolicitud = Fecha.DateTime.Date
        obj.FechaInicio = FechaInicial.DateTime.Date
        obj.FechaCorte = FechaCorte.DateTime.Date
        obj.DiasGracia = sDiasGracia.EditValue
        obj.NoCuotas = sCuotas.EditValue
        obj.Interes = sInteres.EditValue
        obj.Monto = tMonto.EditValue

        If IdArreglo = 0 Then
            IdArreglo = db.Insertar(obj)

            For i As Integer = 0 To iVista.DataRowCount - 1

            Next
        End If




    End Sub
End Class