Imports System.Data.SqlClient
Imports ClasesBLL
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmAsociarAnticipo


    Public IdCliente As Integer = 0, IdAnticipo As Integer = 0
    Private Temp As Boolean = False, temp2 As Boolean = False

    Dim db_Notas As New db_MaestroNotasCD
    Dim tc As New db_TasaCambio

    Private DT As New DataTable
    Private obj As New AnticiposClientes
    'Dim db_Anticipo As New db_AnticiposClientes
    Private Sub frmAsociarPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        Fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date

        'db_AnticiposClientes.Listar(IdAnticipo, Now.Date, Now.Date)

        LoadClietes()
        GetTipoComprobantesList(cbTipo, 1)
        cbTipo.ItemIndex = 0
        SearchLookUp(cbCatalogo, ObtieneDatos("_GetCatalogo_CuentaActivo", EmpresaActual), "Display", "Cuenta", 2)
        '
        Referencia.Text = "NC" + db_MaestroNotasCD.GetNumero(1)
        GetTasaCambio()
        GetData()
        FormatoGrid(vDatos, 2, 0, False)
        '
        obj = db_AnticiposClientes.Detalles(IdAnticipo)
    End Sub

    Sub GetTasaCambio()
        tc.GetTasaCambio(MonedaBase, Fecha.DateTime.Date)
        txtTasa.EditValue = tc.TC_Oficial
    End Sub

    Sub LoadClietes()
        Dim DT_CLIENTE As DataTable = ObtieneDatos("_ClientesGetList", EmpresaActual, 1)

        SearchLookUp(cbCliente, DT_CLIENTE, "Nombre", "Codigo", 4, 5, 6, 7, 8)
        cbCliente.Properties.ReadOnly = True
        cbCliente.EditValue = IdCliente
    End Sub

    'Sub Cargar()
    '    GridDetalle.DataSource = ObtieneDatos("JAR_GetFacturasComprasPendientes " & EmpresaActual)
    '    vDatos.PopulateColumns()
    '    FormatoGrid(vDatos)
    '    '
    '    vDatos.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '    vDatos.Columns("Monto").DisplayFormat.FormatString = "n2"
    '    vDatos.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
    '    vDatos.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"

    '    'vDatos.Columns("Descuento").Width = 100
    '    vDatos.Columns("Descuento").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '    vDatos.Columns("Descuento").DisplayFormat.FormatString = "n2"
    '    vDatos.Columns("Descuento").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
    '    vDatos.Columns("Descuento").SummaryItem.DisplayFormat = "{0:n2}"

    '    'vDatos.Columns("Sub Total").Width = 100
    '    vDatos.Columns("Sub Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '    vDatos.Columns("Sub Total").DisplayFormat.FormatString = "n2"
    '    vDatos.Columns("Sub Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
    '    vDatos.Columns("Sub Total").SummaryItem.DisplayFormat = "{0:n2}"

    '    'vDatos.Columns("IVA").Width = 100
    '    vDatos.Columns("IVA").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '    vDatos.Columns("IVA").DisplayFormat.FormatString = "n2"
    '    vDatos.Columns("IVA").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
    '    vDatos.Columns("IVA").SummaryItem.DisplayFormat = "{0:n2}"

    '    'vDatos.Columns("Total").Width = 100
    '    vDatos.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '    vDatos.Columns("Total").DisplayFormat.FormatString = "n2"
    '    vDatos.Columns("Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
    '    vDatos.Columns("Total").SummaryItem.DisplayFormat = "{0:n2}"
    '    '
    '    vDatos.Columns("Saldo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '    vDatos.Columns("Saldo").DisplayFormat.FormatString = "n2"
    '    vDatos.Columns("Saldo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
    '    vDatos.Columns("Saldo").SummaryItem.DisplayFormat = "{0:n2}"
    '    '
    '    vDatos.Columns("No. Factura").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
    '    vDatos.Columns("No. Factura").SummaryItem.DisplayFormat = "{0:n0}"
    '    '
    '    vDatos.Columns("Comp_No").Visible = False
    '    vDatos.Columns("Mes").Visible = False
    '    vDatos.Columns("Per_Id").Visible = False
    '    vDatos.Columns("Proveedor_ID").Visible = False
    'End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ' If Not DxValidationProvider1.Validate Then Exit Sub

        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(Fecha.DateTime.Date) Then
            Exit Sub
        End If
        '---------------------------------------------------------------------

        If txttotal.EditValue <= 0 Then
            XtraMsg("El Monto debe ser Mayor que Cero (0)", MessageBoxIcon.Warning)
            Exit Sub
        End If
        ''
        If cbTipo.ItemIndex = 0 Then
            XtraMsg("Seleccione el Tipo de Comprobante")
            cbTipo.Focus()
            Exit Sub
        End If
        '
        If cbCatalogo.EditValue Is Nothing Then
            XtraMsg("Seleccione la Cuenta de Anticipo.")
            cbCatalogo.Focus()
            Exit Sub
        End If
        '
        If vDatos.DataRowCount = 0 Then
            XtraMsg("No existen Facturas con Saldos para aplicar este Anticipo", MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim MttoMonto As Double = 0, CobroTotal As Double = 0

        With vDatos
            For i As Integer = 0 To .DataRowCount - 1
                If .GetRowCellValue(i, "Facturar") = True Then 'And IsNull(.GetRowCellValue(i, "Cobro"), 0) > 0 Then
                    MttoMonto += .GetRowCellValue(i, "Monto_Mantenimiento")
                    CobroTotal += .GetRowCellValue(i, "Cobro")
                End If
            Next
        End With
        '

        If CobroTotal <= 0 Then
            XtraMsg("Debe Aplicar el anticipo al menos a 1 Factura.", MessageBoxIcon.Error)
            Exit Sub
        End If

        If Math.Round(txttotal.EditValue, 2) > Math.Round(CobroTotal + MttoMonto, 2) Then
            If Not XtraMsg2("Existe un Saldo a Favor de " + Math.Round(CDbl(txttotal.EditValue - (CobroTotal + MttoMonto)), 2).ToString("n2") + " despues de aplicar este Anticipo" & vbCrLf &
                        "Esta Seguro de Continuar?") Then
                Exit Sub
            End If
        End If
        '
        'TEMPORALMENTE MIENTRAS TERMINO LA PARTE DE LA CONTABILIZACION
        'Exit Sub

        'CONTABILIZAR LA NOTA DE CREDITO
        '*******************************  CONTABILIZAR    **********************************

        ShowSplash("Guardando...")

        Dim Per_Id As Integer = VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date)
        Dim Comp_No As Integer = 0
        Dim CuentaIMtto As String = "", CuentaEMtto As String = ""

        If Math.Round(MttoMonto, 2) <> 0 Then
            Try
                'Buscar las Cuentas de Matto Valor
                Dim DsPlantillas As DataSet = VB.SysContab.PlantillaDB.GetPlantillasDetails(7, 1).Detalles

                CuentaIMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
                CuentaEMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
            Catch ex As Exception
                XtraMsg("Hace Falta la Plantilla de Mantenimiento de Valor.", MessageBoxIcon.Error)
                HideSplash()
                Exit Sub
            End Try
        End If
        '
        Dim CuentaCliente As String = VB.SysContab.ClientesDB.GetDetails(cbCliente.EditValue).Cuenta

        If CuentaCliente.Trim.Length <= 1 Then
            XtraMsg("El Cliente no tiene Cuenta Contable Asignada", MessageBoxIcon.Error)
            HideSplash()
        End If
        '
        Try

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            Comp_No = VB.SysContab.ComprobanteDB.AddComprobante(cbTipo.EditValue, 1, Concepto.Text,
                                                                MonedaBase, Per_Id, Fecha.DateTime.Date, 0, "",
                                                                False, 0, "", 0, Referencia.Text, Fecha.DateTime.Date, 0,
                                                                OrigenComprobantes.NC_ANTICIPO)

            'Aplicar Debitos a Cuenta de Anticipo
            VB.SysContab.ComprobanteDB.AddComprobanteDetalles(Comp_No, cbCatalogo.EditValue, cbCliente.Text, Math.Round(CobroTotal + MttoMonto, 2), "", cbTipo.EditValue, "D", 0, 0, Fecha.DateTime.Date, 0)

            'Aplicar Credito al Cliente
            VB.SysContab.ComprobanteDB.AddComprobanteDetalles(Comp_No, CuentaCliente,
                                                              cbCliente.Text & ", " & Concepto.Text, Math.Round(CobroTotal, 2), "", cbTipo.EditValue, "C", 0, 0, Fecha.DateTime.Date, 0)

            If MttoMonto > 0 Then
                VB.SysContab.ComprobanteDB.AddComprobanteDetalles(Comp_No, CuentaIMtto, "Ingresos por Mantenimiento de Valor, N / C No. " & Referencia.Text, Math.Round(MttoMonto, 2), "",
                                                                  cbTipo.EditValue, "C", 0, 0, Fecha.DateTime.Date, 0)
            Else
                VB.SysContab.ComprobanteDB.AddComprobanteDetalles(Comp_No, CuentaEMtto, "Egresos por Mantenimiento de Valor, N / C No. " & Referencia.Text, Math.Round(MttoMonto * -1, 2), "",
                                                                 cbTipo.EditValue, "D", 0, 0, Fecha.DateTime.Date, 0)
            End If

            VB.SysContab.Rutinas.okTransaccion()
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            HideSplash()

            XtraMsg("Error al contabilizar: " & vbCrLf & ex.Message, MessageBoxIcon.Error)
            Exit Sub
        End Try

        'GUARDANDO LA NOTA DE CREDITO
        '*******************************  GUARDAR NOTA DE CREDITO    **********************************
        Dim IdNota As Integer = db_Notas.Guardar(Referencia.Text, cbCliente.EditValue, Fecha.DateTime.Date, cbTipo.EditValue,
                                    Math.Round(CobroTotal + MttoMonto, 2), Concepto.Text, 1, MonedaBase,
                                    Comp_No, Per_Id, Fecha.DateTime.Date.Month, Fecha.DateTime.Date, IdAnticipo)

        If IdNota > 0 Then
            'GUARDAR DETALLE DE LA NOTA DE CREDITO
            With vDatos
                For i As Integer = 0 To .DataRowCount - 1
                    If .GetRowCellValue(i, "Facturar") = True And IsNull(.GetRowCellValue(i, "Cobro"), 0) > 0 Then

                        db_Notas.GuardarDetalle(IdNota,
                                            .GetRowCellValue(i, "No Factura"),
                                            .GetRowCellValue(i, "Cobro"),
                                            .GetRowCellValue(i, "Fecha"),
                                            .GetRowCellValue(i, "Monto_Mantenimiento"))
                    End If
                Next
            End With
        End If
        '
        'GUARDAR ESTADO DEL ANTICIPO
        db_AnticiposClientes.UpdateEstado(IdAnticipo, "N", IdNota, Math.Round(CobroTotal + MttoMonto, 2))
        HideSplash()
        XtraMsg("El Anticipo ha sido aplicado Correctamente!")

        If frmAnticiposCliente.Created Then frmAnticiposCliente.Cargar()
        Close()

        'ShowSplash("Cargando Saldos...")
        'Referencia.Text = "NC" + db_MaestroNotasCD.GetNumero(1)
        'txttotal.EditValue = Math.Round(CDbl(txttotal.EditValue - (CobroTotal + MttoMonto)), 2)
        'GetData()
        'HideSplash()
        ''
        'If Ok Then
        '    XtraMsg("La(s) Factura(s) se asociaron Correctamente!")
        '    IdNota = 0
        '    txttotal.EditValue = 0.0
        '    GetData()
        'End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click, SimpleButton7.Click
        frmExportarImprimir.Mostrar(GridDetalle)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click, SimpleButton8.Click
        Close()
    End Sub

    'Private Sub cbCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cbCliente.EditValueChanged
    '    ShowSplash("Cargando Facturas...")
    '    GetData()
    '    HideSplash()
    'End Sub

    Private Sub GetData()
        Try
            If cbCliente.EditValue Is Nothing Then Exit Sub

            DT = VB.SysContab.Facturas_VentasDB.GetCobrosPendientesAnticipos(cbCliente.EditValue, Fecha.DateTime.Date)
            DT.AcceptChanges()
            GridDetalle.DataSource = DT

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Fecha_EditValueChanged(sender As Object, e As EventArgs) Handles Fecha.EditValueChanged
        If Inicio Then Exit Sub
        GetTasaCambio()
        ' GetData()
    End Sub

    Private Sub vDatos_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vDatos.CellValueChanged

        If e.Column.FieldName = "Facturar" And Not Temp Then
            vDatos.SetRowCellValue(e.RowHandle, "Cobro", 0.00)

            If obj.Moneda = MonedaBase Then DistribuirPago() Else DistribuirDolares()


            'DistribuirPago()
            'Temp = True
            'vDatos.SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", 0.00)
            'Temp = False
            ''
            'If vDatos.GetRowCellValue(e.RowHandle, "Facturar") Then CalcularDeslizamiento(e)
        End If
        ''
        If e.Column.FieldName = "Monto_Mantenimiento" And Not Temp Then

            temp2 = True
            If obj.Moneda = MonedaBase Then DistribuirPago() Else DistribuirDolares()
            temp2 = False


            'If Not vDatos.GetRowCellValue(e.RowHandle, "Facturar") Then
            '    Temp = True
            '    vDatos.SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", 0.00)
            '    Temp = False
            'Else
            '    If CDbl(vDatos.GetRowCellValue(e.RowHandle, "Saldo") - vDatos.GetRowCellValue(e.RowHandle, "Cobro")) > Math.Abs(CDbl(e.Value)) Then
            '        vDatos.SetRowCellValue(e.RowHandle, "Cobro", Math.Round(CDbl(vDatos.GetRowCellValue(e.RowHandle, "Cobro") - e.Value), 2))
            '    End If
            'End If
            'vDatos.SetRowCellValue(e.RowHandle, "Cobro", Math.Round(CDbl(vDatos.GetRowCellValue(e.RowHandle, "Cobro") - e.Value), 2))
            'DistribuierPago()
        End If

        If e.Column.FieldName = "Cobro" And Not Temp Then
            vDatos.SetRowCellValue(e.RowHandle, "Saldo", vDatos.GetRowCellValue(e.RowHandle, "Total") -
                                      vDatos.GetRowCellValue(e.RowHandle, "Abono") -
                                      vDatos.GetRowCellValue(e.RowHandle, "Cobro"))
        End If
        '
        vDatos.UpdateTotalSummary()
    End Sub

    Sub DistribuirPago()
        Dim Total As Double = txttotal.EditValue

        Dim Valor As Double = 0.00, Mntto As Double = 0.00  ', Equivalente As Double = 0.00
        Dim dm As New db_DeslizamientoMoneda

        With vDatos

            For i As Integer = 0 To .DataRowCount - 1
                If .GetRowCellValue(i, "Facturar") = True Then
                    If Math.Round(CDbl(.GetRowCellValue(i, "OtroSaldo")), 2) >= Math.Round(Total, 2) Then
                        Temp = True
                        'temp2 valida si el Delizamiento se cambio Manual
                        If Not temp2 Then
                            'Calcular el Deslizamiento por el Abono
                            dm.CalcularDeslizamiento(CDbl(Total / txtTCAnticipo.EditValue), .GetRowCellValue(i, "TC"), txtTCAnticipo.EditValue, 1)
                            .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
                        End If
                        '
                        Valor = Total - IIf(temp2, .GetRowCellValue(i, "Monto_Mantenimiento"), dm.Mantenimiento_Valor)
                        'Equivalente += (Total / IIf(.GetRowCellValue(i, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue))
                        '
                        'No entra cuando el Mantenimiento es Manual
                        'If Not temp2 Then
                        '    'Varificando si el cliente queda con saldo despues de la aplicacion.
                        '    ' If Math.Round(CDbl(.GetRowCellValue(i, "OtroSaldo")), 2) = Math.Round(Total + IIf(temp2, .GetRowCellValue(i, "Monto_Mantenimiento"), dm.Mantenimiento_Valor), 2) Then
                        '    Dim dif As Double = Math.Round(CDbl(.GetRowCellValue(i, "OtroSaldo")) - (Valor + IIf(temp2, .GetRowCellValue(i, "Monto_Mantenimiento"), dm.Mantenimiento_Valor)), 2)

                        '    If dif <> 0 Then
                        '        '  If dif > 0 Then
                        '        Valor = Math.Round(Valor + dif, 2)
                        '        .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor - dif)
                        '        ' End If
                        '    End If
                        '    ' End If
                        'End If
                        '
                        Total = 0.00
                        Temp = False
                    Else
                        Temp = True
                        If Not temp2 Then
                            'Calcular el Deslizamiento por el Abono
                            dm.CalcularDeslizamiento(CDbl(.GetRowCellValue(i, "OtroSaldo") / .GetRowCellValue(i, "TC")), .GetRowCellValue(i, "TC"), txtTCAnticipo.EditValue, 1)
                            .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
                        End If

                        Valor = .GetRowCellValue(i, "OtroSaldo") '- IIf(temp2, .GetRowCellValue(i, "Monto_Mantenimiento"), dm.Mantenimiento_Valor)

                        'If Not temp2 Then
                        '    'Varificando si el cliente queda con saldo despues de la aplicacion.                        
                        '    'Dim dif As Double = .GetRowCellValue(i, "OtroSaldo") - Valor
                        '    Dim dif As Double = Math.Round(CDbl(.GetRowCellValue(i, "OtroSaldo")) - (Valor + IIf(temp2, .GetRowCellValue(i, "Monto_Mantenimiento"), dm.Mantenimiento_Valor)), 2)

                        '    If dif <> 0 Then
                        '        Valor = Math.Round(Valor + dif, 2)
                        '        .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor - dif)
                        '    End If
                        'End If
                        '
                        'Equivalente += ((.GetRowCellValue(i, "OtroSaldo") + .GetRowCellValue(i, "Monto_Mantenimiento")) / IIf(.GetRowCellValue(i, "TC_Paralelo"), txtTasaParalela.EditValue, txtTasa.EditValue))
                        Total -= (.GetRowCellValue(i, "OtroSaldo") + .GetRowCellValue(i, "Monto_Mantenimiento"))
                        Temp = False
                    End If
                    '
                    If Valor > 0 Then
                        .SetRowCellValue(i, "Cobro", Valor)
                    Else
                        Temp = True
                        .SetRowCellValue(i, "Cobro", 0.00)
                        .SetRowCellValue(i, "Monto_Mantenimiento", 0.00)
                        .SetRowCellValue(i, "Facturar", False)
                        Temp = False
                    End If
                    Mntto += .GetRowCellValue(i, "Monto_Mantenimiento")
                Else
                    Temp = True
                    .SetRowCellValue(i, "Monto_Mantenimiento", 0.00)
                    Temp = False
                End If
            Next
            '
            'etMntto.Text = Math.Round(Mntto, 2).ToString("n2")
            'txtEquivalente.EditValue = Math.Round(Equivalente, 2)
            '
            .UpdateTotalSummary()
        End With
    End Sub

    Sub DistribuirDolares()

        Dim Total As Double = txtMontoU.EditValue
        'Dim TotalU As Double = txtMontoU.EditValue
        Dim Valor As Double = 0.00, Mntto As Double = 0.00
        Dim dm As New db_DeslizamientoMoneda
        '
        With vDatos
            For i As Integer = 0 To .DataRowCount - 1
                If .GetRowCellValue(i, "Facturar") = True Then
                    If Math.Round(CDbl(.GetRowCellValue(i, "SaldoU")), 2) >= Math.Round(Total, 2) Then
                        Temp = True

                        If Not temp2 Then
                            'Calcular el Deslizamiento por el Abono
                            dm.CalcularDeslizamiento(Total, .GetRowCellValue(i, "TC"), txtTCAnticipo.EditValue, 1)
                            .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
                        End If
                        '
                        Valor = (Total * txtTCAnticipo.EditValue) - IIf(temp2, .GetRowCellValue(i, "Monto_Mantenimiento"), dm.Mantenimiento_Valor)
                        'Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
                        '
                        'No entra cuando el Mantenimiento es Manual
                        If Not temp2 Then
                            'Varificando si el cliente queda con saldo despues de la aplicacion.
                            If Math.Round(CDbl(.GetRowCellValue(i, "SaldoU")), 2) = Math.Round(Total, 2) Then
                                Dim dif As Double = Math.Round(CDbl(.GetRowCellValue(i, "OtroSaldo")), 2) - Valor
                                If dif <> 0 Then
                                    '  If dif > 0 Then
                                    Valor = Math.Round(Valor + dif, 2)
                                    .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor - dif)
                                    ' End If
                                End If
                            End If
                        End If
                        '
                        Total = 0.00
                        Temp = False
                    Else
                        Temp = True

                        If Not temp2 Then
                            'Calcular el Deslizamiento por el Abono
                            dm.CalcularDeslizamiento(.GetRowCellValue(i, "SaldoU"), .GetRowCellValue(i, "TC"), txtTCAnticipo.EditValue, 1)
                            .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
                        End If

                        Valor = (.GetRowCellValue(i, "SaldoU") * txtTCAnticipo.EditValue) - IIf(temp2, .GetRowCellValue(i, "Monto_Mantenimiento"), dm.Mantenimiento_Valor)

                        If Not temp2 Then
                            'Varificando si el cliente queda con saldo despues de la aplicacion.                        
                            Dim dif As Double = .GetRowCellValue(i, "OtroSaldo") - Valor

                            If Math.Round(dif, 2) <> 0 Then
                                Valor = Math.Round(Valor + dif, 2)
                                .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor - dif)
                            End If
                        End If

                        'dm.CalcularDeslizamiento(.GetRowCellValue(i, "SaldoU"), .GetRowCellValue(i, "TC"), txtTCAnticipo.EditValue, 1)
                        '.SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
                        'TotalU -= (.GetRowCellValue(i, "SaldoU"))

                        ''
                        'If ((.GetRowCellValue(i, "OtroSaldo")) >= (Total - .GetRowCellValue(i, "Monto_Mantenimiento"))) Then
                        '    Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
                        '    Total -= Total
                        '    'TotalU -= TotalU
                        'Else
                        '    Valor = .GetRowCellValue(i, "OtroSaldo")
                        '    Total -= (.GetRowCellValue(i, "OtroSaldo") + dm.Mantenimiento_Valor)      '.GetRowCellValue(i, "Monto_Mantenimiento"))
                        '    'TotalU -= .GetRowCellValue(i, "SaldoU")
                        'End If

                        Total -= .GetRowCellValue(i, "SaldoU")
                        Temp = False
                    End If
                    If Valor > 0 Then
                        .SetRowCellValue(i, "Cobro", Valor)
                    Else
                        Temp = True
                        .SetRowCellValue(i, "Cobro", 0.00)
                        .SetRowCellValue(i, "Monto_Mantenimiento", 0.00)
                        .SetRowCellValue(i, "Facturar", False)
                        Temp = False
                    End If
                    Mntto += .GetRowCellValue(i, "Monto_Mantenimiento")
                Else
                    Temp = True
                    .SetRowCellValue(i, "Monto_Mantenimiento", 0.00)
                    Temp = False
                End If
            Next
            .UpdateTotalSummary()
        End With
    End Sub

    Sub CalcularDeslizamiento(e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)

        Dim TotalU As Double = txtMontoU.EditValue
        Dim Total As Double = txttotal.EditValue
        Dim dm As New db_DeslizamientoMoneda
        '
        For i As Integer = 0 To vDatos.DataRowCount - 1
            If e.RowHandle <> i Then If vDatos.GetRowCellValue(i, "Facturar") Then TotalU -= vDatos.GetRowCellValue(i, "SaldoU")
            If e.RowHandle <> i Then If vDatos.GetRowCellValue(i, "Facturar") Then Total -= (vDatos.GetRowCellValue(i, "Cobro") - vDatos.GetRowCellValue(i, "Monto_Mantenimiento"))
        Next
        '
        With vDatos
            'If (.GetRowCellValue(e.RowHandle, "SaldoU")) >= TotalU Then
            If (.GetRowCellValue(e.RowHandle, "OtroSaldo")) >= Total Then
                'Calcular el Deslizamiento por el Abono
                Temp = True
                dm.CalcularDeslizamiento(TotalU, .GetRowCellValue(e.RowHandle, "TC"), txtTCAnticipo.EditValue, 1)
                .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
                Temp = False
                '
                .SetRowCellValue(e.RowHandle, "Cobro", Math.Round((TotalU * txtTCAnticipo.EditValue) - dm.Mantenimiento_Valor, 2))
            Else
                'Calcular el Deslizamiento por el Abono
                Temp = True
                dm.CalcularDeslizamiento(.GetRowCellValue(e.RowHandle, "SaldoU"), .GetRowCellValue(e.RowHandle, "TC"), txtTCAnticipo.EditValue, 1)
                .SetRowCellValue(e.RowHandle, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
                Temp = False

                .SetRowCellValue(e.RowHandle, "Cobro", .GetRowCellValue(e.RowHandle, "OtroSaldo"))
            End If
            .RefreshData()
        End With

    End Sub



    Private Sub Distribuir(e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)

        '        'Dim Total As Double = txttotal.EditValue
        '        Dim TotalU As Double = txtMontoU.EditValue
        '        'Dim Valor As Double = 0
        '        Dim dm As New db_DeslizamientoMoneda
        '        Dim Total As Double = 0

        '        'Dim _dt As DataTable = DT.Select("Facturar = 1").CopyToDataTable

        '        For i As Integer = 0 To vDatos.DataRowCount - 1
        '            With vDatos
        '                If .GetRowCellValue(e.RowHandle, "Facturar") Then
        '                    Total += (.GetRowCellValue(e.RowHandle, "Cobro") - .GetRowCellValue(e.RowHandle, "Monto_Mantenimiento"))
        '                End If
        '            End With

        '            ' If PosLinea <> i Then If vDatos.GetRowCellValue(i, "Facturar") Then TotalU -= vDatos.GetRowCellValue(i, "SaldoU")
        '        Next
        '        '
        '        With vDatos
        '            If .GetRowCellValue(PosLinea, "Facturar") Then
        '                If (.GetRowCellValue(PosLinea, "SaldoU")) >= TotalU Then
        '                    'Calcular el Deslizamiento por el Abono
        '                    Temp = True
        '                    dm.CalcularDeslizamiento(TotalU, .GetRowCellValue(PosLinea, "TC"), txtTCAnticipo.EditValue, 1)
        '                    .SetRowCellValue(PosLinea, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
        '                    Temp = False

        '                    .SetRowCellValue(PosLinea, "Cobro", Math.Round((TotalU * txtTCAnticipo.EditValue) - dm.Mantenimiento_Valor, 2))
        '                Else
        '                    'Calcular el Deslizamiento por el Abono
        '                    Temp = True
        '                    dm.CalcularDeslizamiento(.GetRowCellValue(PosLinea, "SaldoU"), .GetRowCellValue(PosLinea, "TC"), txtTCAnticipo.EditValue, 1)
        '                    .SetRowCellValue(PosLinea, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
        '                    Temp = False

        '                    .SetRowCellValue(PosLinea, "Cobro", Math.Round(.GetRowCellValue(PosLinea, "SaldoU") * .GetRowCellValue(PosLinea, "TC"), 2))
        '                End If
        '            Else
        '                Temp = True
        '                .SetRowCellValue(PosLinea, "Monto_Mantenimiento", 0.00)
        '                GoTo DistribuirPagos
        '                Temp = False
        '            End If
        '            .RefreshData()
        '        End With

        'DistribuirPagos:

        '        With vDatos

        '            For i As Integer = 0 To vDatos.DataRowCount - 1
        '                If .GetRowCellValue(i, "Facturar") Then

        '                    If .GetRowCellValue(i, "Saldo") <> 0 Then

        '                    End If


        '                End If
        '            Next

        '        End With

        ''Aqui si Entra, Siempre se van a realizar abonos a las facturas.
        'With vDatos
        '    ''Restar al Total lo que ya esta marcado
        '    For i As Integer = 0 To vDatos.DataRowCount - 1

        '        If .GetRowCellValue(i, "Facturar") = True Then
        '            If (.GetRowCellValue(i, "SaldoU")) >= TotalU Then
        '                ' If .GetRowCellValue(i, "Monto_Mantenimiento") = 0 Then
        '                Temp = True
        '                'Calcular el Deslizamiento por el Abono
        '                dm.CalcularDeslizamiento(TotalU, .GetRowCellValue(i, "TC"), txtTCAnticipo.EditValue, 1)
        '                .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor)

        '                'Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
        '                Temp = False
        '                ' End If

        '                Valor = Total - dm.Mantenimiento_Valor
        '                Total -= Total
        '            Else
        '                ' If .GetRowCellValue(i, "Monto_Mantenimiento") = 0 Then

        '                dm.CalcularDeslizamiento(.GetRowCellValue(i, "SaldoU"), .GetRowCellValue(i, "TC"), txtTCAnticipo.EditValue, 1)
        '                Temp = True
        '                .SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
        '                TotalU -= (.GetRowCellValue(i, "SaldoU"))
        '                Temp = False

        '                ' End If
        '                '
        '                If ((.GetRowCellValue(i, "OtroSaldo")) >= (Total - .GetRowCellValue(i, "Monto_Mantenimiento"))) Then

        '                    'dm.CalcularDeslizamiento(Total, txtTCAnticipo.EditValue, txtTasa.EditValue, 1)
        '                    'Temp = True
        '                    '.SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
        '                    'Valor = Total - dm.Mantenimiento_Valor
        '                    'Temp = False

        '                    Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
        '                    Total -= Total
        '                Else
        '                    'dm.CalcularDeslizamiento(Total, txtTCAnticipo.EditValue, txtTasa.EditValue, 1)
        '                    'Temp = True
        '                    '.SetRowCellValue(i, "Monto_Mantenimiento", dm.Mantenimiento_Valor)
        '                    'Temp = False

        '                    Valor = .GetRowCellValue(i, "OtroSaldo")
        '                    Total -= (.GetRowCellValue(i, "OtroSaldo") + dm.Mantenimiento_Valor)      '.GetRowCellValue(i, "Monto_Mantenimiento"))
        '                End If
        '            End If
        '            'Temp = True
        '            .SetRowCellValue(i, "Cobro", Valor)
        '            'Temp = False
        '            'Else
        '            '    Temp = True
        '            '    If .GetRowCellValue(i, "Monto_Mantenimiento") <> 0 Then .SetRowCellValue(i, "Monto_Mantenimiento", 0.00)
        '            '    Temp = False
        '        End If

        '        'If .GetRowCellValue(i, "IVA") > 0 Then
        '        '    .SetRowCellValue(i, "IVAParcial", IIf(chknoiva.Checked, 0, (.GetRowCellValue(i, "Cobro") / IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1))) * (ConfigDetalles.IVA / 100)))
        '        'End If

        '        'If VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio) Is Nothing Then
        '        '    MsgBox("Al cliente aún no se le ha asignado un municipio, para efectos del Impuesto Municipal Sobre Ventas", MsgBoxStyle.Critical, "STS.Contab")
        '        'End If

        '        'If Me.chknoiralcaldia.Checked Then
        '        '    .SetRowCellValue(i, "IrAlcaldia", 0)
        '        'Else
        '        '    If Valor >= VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio).Impuesto_SVenta_Min Then
        '        '        .SetRowCellValue(i, "IrAlcaldia", (.GetRowCellValue(i, "Cobro") / IIf(.GetRowCellValue(i, "IVA") > 0, IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1)), 1)) * (VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio).Impuesto_SVenta / 100))
        '        '    End If
        '        'End If

        '        'If Valor >= ConfigDetalles.MontoIR Then
        '        '    .SetRowCellValue(i, "IrParcial", IIf(chknoir.Checked, 0, (.GetRowCellValue(i, "Cobro") / IIf(.GetRowCellValue(i, "IVA") > 0, IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1)), 1)) * (ConfigDetalles.IRProd / 100)))
        '        'End If
        '    Next
        '    vDatos.RefreshData()
        'End With

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        GetData()
    End Sub

    Private Sub frmAsociarAnticipo_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F3 Then vDatos.ShowCustomization()
    End Sub

    Private Sub vDatos_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles vDatos.RowCellStyle
        If e.Column.FieldName = "Monto_Mantenimiento" Then
            If vDatos.GetRowCellValue(e.RowHandle, "Facturar") Then
                If e.CellValue <> 0 Then
                    e.Appearance.BackColor = Color.Salmon
                    e.Appearance.BackColor2 = Color.Pink
                    e.Appearance.ForeColor = Color.Red
                End If
            End If
        End If
    End Sub
End Class