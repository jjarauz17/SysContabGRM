Public Class frmAsociarPagosClientes

    Dim IdNota As Integer = 0

    Private Sub frmAsociarPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date
        GetCatalogoClientes(cbCliente, iVista)
        cbCliente.Properties.PopupFormSize = New Point(900, 0)
    End Sub

    Sub Cargar()
        GridDetalle.DataSource = ObtieneDatos("JAR_GetFacturasComprasPendientes " & EmpresaActual)
        vDatos.PopulateColumns()
        FormatoGrid(vDatos)
        '
        vDatos.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        vDatos.Columns("Monto").DisplayFormat.FormatString = "n2"
        vDatos.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        vDatos.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"

        'vDatos.Columns("Descuento").Width = 100
        vDatos.Columns("Descuento").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        vDatos.Columns("Descuento").DisplayFormat.FormatString = "n2"
        vDatos.Columns("Descuento").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        vDatos.Columns("Descuento").SummaryItem.DisplayFormat = "{0:n2}"

        'vDatos.Columns("Sub Total").Width = 100
        vDatos.Columns("Sub Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        vDatos.Columns("Sub Total").DisplayFormat.FormatString = "n2"
        vDatos.Columns("Sub Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        vDatos.Columns("Sub Total").SummaryItem.DisplayFormat = "{0:n2}"

        'vDatos.Columns("IVA").Width = 100
        vDatos.Columns("IVA").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        vDatos.Columns("IVA").DisplayFormat.FormatString = "n2"
        vDatos.Columns("IVA").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        vDatos.Columns("IVA").SummaryItem.DisplayFormat = "{0:n2}"

        'vDatos.Columns("Total").Width = 100
        vDatos.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        vDatos.Columns("Total").DisplayFormat.FormatString = "n2"
        vDatos.Columns("Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        vDatos.Columns("Total").SummaryItem.DisplayFormat = "{0:n2}"
        '
        vDatos.Columns("Saldo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        vDatos.Columns("Saldo").DisplayFormat.FormatString = "n2"
        vDatos.Columns("Saldo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        vDatos.Columns("Saldo").SummaryItem.DisplayFormat = "{0:n2}"
        '
        vDatos.Columns("No. Factura").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        vDatos.Columns("No. Factura").SummaryItem.DisplayFormat = "{0:n0}"
        '
        vDatos.Columns("Comp_No").Visible = False
        vDatos.Columns("Mes").Visible = False
        vDatos.Columns("Per_Id").Visible = False
        vDatos.Columns("Proveedor_ID").Visible = False
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If txttotal.EditValue <= 0 Then
            XtraMsg("El Monto debe ser Mayor que Cero (0)", MessageBoxIcon.Warning)
            Exit Sub
        End If
        ''
        Dim Datos As New ArrayList
        Dim Variables As New ArrayList
        Dim Ok As Boolean = False

        Variables.Clear()
        Variables.Add("IdNota")
        Variables.Add("Factura")
        Variables.Add("Monto")
        Variables.Add("Fecha")
        Variables.Add("Empresa")
        Variables.Add("Mnto")

        With vDatos
            For i As Integer = 0 To .DataRowCount - 1
                If .GetRowCellValue(i, "Facturar") = True And IsNull(.GetRowCellValue(i, "Cobro"), 0) > 0 Then
                    Datos.Clear()
                    Datos.Add(IdNota)
                    Datos.Add(.GetRowCellValue(i, "No Factura"))
                    Datos.Add(.GetRowCellValue(i, "Cobro"))
                    Datos.Add(.GetRowCellValue(i, "Fecha"))
                    Datos.Add(EmpresaActual)
                    Datos.Add(.GetRowCellValue(i, "Monto_Mantenimiento"))
                    '
                    ProcedureSave(Datos, Variables, "SP_GuardaDetalleNotasCD")

                    Ok = True
                End If
            Next
        End With
        ''
        If Ok Then
            XtraMsg("La(s) Factura(s) se asociaron Correctamente!")
            IdNota = 0
            txttotal.EditValue = 0.0
            GetData()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        frmExportarImprimir.Mostrar(GridDetalle)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Close()
    End Sub

    Private Sub cbCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cbCliente.EditValueChanged
        ShowSplash("Cargando Facturas...")
        GetData()
        HideSplash()
    End Sub

    Private Sub GetData()
        Try
            If cbCliente.EditValue Is Nothing Then Exit Sub

            Dim Datos As New ArrayList
            Dim Variables As New ArrayList
            Variables.Add("Cliente")
            Variables.Add("Empresa")
            Variables.Add("Fecha")
            'Datos.Add(cmbclientes.EditValue)
            Datos.Add(cbCliente.EditValue)
            Datos.Add(EmpresaActual)
            Datos.Add(Fecha.DateTime.Date)
            GridDetalle.DataSource = ProcedureParameters(Datos, Variables, "SP_GetListFacturasXCliente")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Fecha_EditValueChanged(sender As Object, e As EventArgs) Handles Fecha.EditValueChanged
        GetData()
    End Sub

    Private Sub vDatos_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vDatos.CellValueChanged
        If e.Column.FieldName = "Facturar" Then
            vDatos.SetRowCellValue(e.RowHandle, "Cobro", 0)
            Distribuir()
        End If
        ''
        If e.Column.FieldName = "Monto_Mantenimiento" Then
            Distribuir()
        End If

        If e.Column.FieldName = "Cobro" Then
            vDatos.SetRowCellValue(e.RowHandle, "Saldo", vDatos.GetRowCellValue(e.RowHandle, "Total") - _
                                      vDatos.GetRowCellValue(e.RowHandle, "Abono") - _
                                      vDatos.GetRowCellValue(e.RowHandle, "Cobro"))
        End If
    End Sub

    Private Sub Distribuir()
        Dim Total As Double = txttotal.EditValue
        Dim Valor As Double = 0

        'Aqui si Entra, Siempre se van a realizar abonos a las facturas.
        With vDatos
            ''Restar al Total lo que ya esta marcado
            For i As Integer = 0 To vDatos.DataRowCount - 1
                If .GetRowCellValue(i, "Facturar") = True Then
                    If (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono")) >= Total Then
                        Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
                        Total -= Total
                    Else
                        If ((.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono")) >= (Total - .GetRowCellValue(i, "Monto_Mantenimiento"))) Then
                            Valor = Total - .GetRowCellValue(i, "Monto_Mantenimiento")
                            Total -= Total
                        Else
                            Valor = (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono"))
                            Total -= (.GetRowCellValue(i, "Total") - .GetRowCellValue(i, "Abono") + .GetRowCellValue(i, "Monto_Mantenimiento"))
                        End If
                    End If
                    .SetRowCellValue(i, "Cobro", Valor)
                End If

                'If .GetRowCellValue(i, "IVA") > 0 Then
                '    .SetRowCellValue(i, "IVAParcial", IIf(chknoiva.Checked, 0, (.GetRowCellValue(i, "Cobro") / IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1))) * (ConfigDetalles.IVA / 100)))
                'End If

                'If VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio) Is Nothing Then
                '    MsgBox("Al cliente aún no se le ha asignado un municipio, para efectos del Impuesto Municipal Sobre Ventas", MsgBoxStyle.Critical, "STS.Contab")
                'End If

                'If Me.chknoiralcaldia.Checked Then
                '    .SetRowCellValue(i, "IrAlcaldia", 0)
                'Else
                '    If Valor >= VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio).Impuesto_SVenta_Min Then
                '        .SetRowCellValue(i, "IrAlcaldia", (.GetRowCellValue(i, "Cobro") / IIf(.GetRowCellValue(i, "IVA") > 0, IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1)), 1)) * (VB.SysContab.MunicipiosDB.GetDetails(VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Departamento, VB.SysContab.ClientesDB.GetDetails(Me.cbClientes.EditValue).Municipio).Impuesto_SVenta / 100))
                '    End If
                'End If

                'If Valor >= ConfigDetalles.MontoIR Then
                '    .SetRowCellValue(i, "IrParcial", IIf(chknoir.Checked, 0, (.GetRowCellValue(i, "Cobro") / IIf(.GetRowCellValue(i, "IVA") > 0, IIf(chknoiva.Checked, 1, ((ConfigDetalles.IVA / 100) + 1)), 1)) * (ConfigDetalles.IRProd / 100)))
                'End If
            Next
            vDatos.RefreshData()
        End With

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If cbCliente.EditValue Is Nothing Then Exit Sub

        frmSaldosAFavorClientes.etCliente.Text = "CLIENTE: " & cbCliente.Text.ToUpper
        frmSaldosAFavorClientes.IdCliente = cbCliente.EditValue
        frmSaldosAFavorClientes.Fecha = Fecha.DateTime.Date
        frmSaldosAFavorClientes.ShowDialog()

        txttotal.EditValue = frmSaldosAFavorClientes.Monto
        IdNota = frmSaldosAFavorClientes.IdNota

        frmSaldosAFavorClientes.Dispose()
    End Sub
End Class