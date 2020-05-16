Public Class frmAsociarPagos

    Public Comp_No As Integer = 0, Per_Id As Integer = 0, Mes As Integer = 0, IdPago As Integer = 0, Fecha As Date

    Private Sub frmAsociarPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SearchLookUp(cbProveedor, ObtieneDatos("JAR_GetProveedoresList", EmpresaActual, 1), "NOMBRE", "CODIGO", 0)
        cbProveedor.EditValue = 0
        '
        Cargar()
        Formato()
    End Sub

    Sub Cargar()
        dgDatos.DataSource = ObtieneDatos("JAR_GetFacturasComprasPendientes", cbProveedor.EditValue, EmpresaActual)
    End Sub

    Sub Formato()
        vDatos.PopulateColumns()
        FormatoGrid(vDatos, 2, 0, False)
        '
        For i As Integer = 0 To vDatos.Columns.Count - 1
            vDatos.Columns(i).OptionsColumn.AllowEdit = False
        Next
        '
        vDatos.Columns("Aplicar").OptionsColumn.AllowEdit = True
        vDatos.Columns("Monto Aplicar").ColumnEdit = rMonto
        '
        vDatos.Columns("No. Factura").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        vDatos.Columns("No. Factura").SummaryItem.DisplayFormat = "{0:n0}"
        '
        vDatos.Columns("Comp_No").Visible = False
        vDatos.Columns("Mes").Visible = False
        vDatos.Columns("Per_Id").Visible = False
        vDatos.Columns("Proveedor_ID").Visible = False

        vDatos.Columns("Proveedor").Width = 250

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If txtMonto.EditValue <= 0.0 Then
            XtraMsg("El Monto Aplicar debe ser Mayor que Cero (0)", MessageBoxIcon.Error)
            txtMonto.Focus()
            txtMonto.SelectAll()
            Exit Sub
        End If

        Dim selec As Boolean = False

        For i As Integer = 0 To vDatos.DataRowCount - 1
            If vDatos.GetRowCellValue(i, "Aplicar") Then selec = True
        Next

        If Not selec Then
            XtraMsg("Debe Seleccionar al menos 1 factura para aplicar el Pago", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If Math.Round(vDatos.Columns("Monto Aplicar").SummaryItem.SummaryValue, 2) > Math.Round(txtMonto.EditValue, 2) Then
            XtraMsg("No se puede aplicar un monto mayor al Pago", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        For i As Integer = 0 To vDatos.DataRowCount - 1
            If vDatos.GetRowCellValue(i, "Aplicar") Then
                If vDatos.GetRowCellValue(i, "Monto Aplicar") > 0.0 Then
                    If Guardar("JAR_AsociarPago", vDatos.GetRowCellValue(i, "Comp_No"), _
                                                   vDatos.GetRowCellValue(i, "Per_Id"), _
                                                   vDatos.GetRowCellValue(i, "Mes"), _
                                                   Comp_No, _
                                                   Per_Id, _
                                                   Mes, _
                                                   Fecha, _
                                                   vDatos.GetRowCellValue(i, "Monto Aplicar"), _
                                                   vDatos.GetRowCellValue(i, "No. Factura"), _
                                                   vDatos.GetRowCellValue(i, "Proveedor_ID"), _
                                                   IdPago, _
                                                   EmpresaActual) Then
                    End If
                End If
            End If
        Next

        XtraMsg("El Pago se ha Asociado Correctamente!")

        txtMonto.EditValue = 0.0
        Comp_No = 0.0
        Per_Id = 0.0
        Mes = 0.0
        IdPago = 0.0

        ShowSplash()
        Cargar()
        HideSplash()



        'With frmCKAsociarList
        '    .ProveedorID = vDatos.GetFocusedRowCellValue("Proveedor_ID")
        '    .ShowDialog()
        '    If .Comp_No <> 0 Then
        '        'Dim variables As New ArrayList, datos As New ArrayList
        '        ' ''
        '        'variables.Add("Comp_No")
        '        'variables.Add("Per_Id")
        '        'variables.Add("Mes")
        '        'variables.Add("Comp_No1")
        '        'variables.Add("Per_Id1")
        '        'variables.Add("Mes1")
        '        'variables.Add("Fecha")
        '        'variables.Add("Monto")
        '        'variables.Add("Factura")
        '        'variables.Add("Proveedor")
        '        'variables.Add("Proveedor")
        '        'variables.Add("Empresa")

        '        'datos.Add(vDatos.GetFocusedRowCellValue("Comp_No"))
        '        'datos.Add(vDatos.GetFocusedRowCellValue("Per_Id"))
        '        'datos.Add(vDatos.GetFocusedRowCellValue("Mes"))
        '        'datos.Add(.Comp_No)
        '        'datos.Add(.Per_Id)
        '        'datos.Add(.Mes)
        '        'datos.Add(.Fecha)
        '        'datos.Add(IIf(Math.Round(CDbl(vDatos.GetFocusedRowCellValue("Saldo")), 2) >= .Monto, .Monto, Math.Round(CDbl(vDatos.GetFocusedRowCellValue("Saldo")), 2)))
        '        'datos.Add(vDatos.GetFocusedRowCellValue("No. Factura"))
        '        'datos.Add(vDatos.GetFocusedRowCellValue("Proveedor_ID"))
        '        'datos.Add(EmpresaActual)

        '        'If Guardar("JAR_AsociarPago", vDatos.GetFocusedRowCellValue("Comp_No"), _
        '        '                                vDatos.GetFocusedRowCellValue("Per_Id"), _
        '        '                                vDatos.GetFocusedRowCellValue("Mes"), _
        '        '                                .Comp_No, _
        '        '                                .Per_Id, _
        '        '                                .Mes, _
        '        '                                .Fecha, _
        '        '                                IIf(Math.Round(CDbl(vDatos.GetFocusedRowCellValue("Saldo")), 2) >= .Monto, .Monto, Math.Round(CDbl(vDatos.GetFocusedRowCellValue("Saldo")), 2)), _
        '        '                                vDatos.GetFocusedRowCellValue("No. Factura"), _
        '        '                                vDatos.GetFocusedRowCellValue("Proveedor_ID"), _
        '        '                                .IdPago, _
        '        '                                EmpresaActual) Then
        '        '    XtraMsg("El Pago se ha Asociado Correctamente!")
        '        '    ShowSplash()
        '        '    Cargar()
        '        '    HideSplash()
        '        'End If

        '        'If ProcedureSave(datos, variables, "JAR_AsociarPago") Then
        '        '    XtraMsg("El Pago se ha Asociado Correctamente!")
        '        '    ShowSplash()
        '        '    Cargar()
        '        '    HideSplash()
        '        'End If
        '    End If
        '    .Dispose()
        'End With
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        frmExportarImprimir.Mostrar(dgDatos)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Close()
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        If vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If
        '
        With frmCKAsociarList
            .ProveedorID = vDatos.GetFocusedRowCellValue("Proveedor_ID")
            .ShowDialog()
            If .Comp_No <> 0 Then
                txtMonto.EditValue = .Monto
                Comp_No = .Comp_No
                Per_Id = .Per_Id
                Mes = .Mes
                IdPago = .IdPago
                Fecha = .Fecha

                Distribuir()
                'If Guardar("JAR_AsociarPago", vDatos.GetFocusedRowCellValue("Comp_No"), _
                '                                vDatos.GetFocusedRowCellValue("Per_Id"), _
                '                                vDatos.GetFocusedRowCellValue("Mes"), _
                '                                .Comp_No, _
                '                                .Per_Id, _
                '                                .Mes, _
                '                                .Fecha, _
                '                                IIf(Math.Round(CDbl(vDatos.GetFocusedRowCellValue("Saldo")), 2) >= .Monto, .Monto, Math.Round(CDbl(vDatos.GetFocusedRowCellValue("Saldo")), 2)), _
                '                                vDatos.GetFocusedRowCellValue("No. Factura"), _
                '                                vDatos.GetFocusedRowCellValue("Proveedor_ID"), _
                '                                .IdPago, _
                '                                EmpresaActual) Then
                '    XtraMsg("El Pago se ha Asociado Correctamente!")
                '    ShowSplash()
                '    Cargar()
                '    HideSplash()
                'End If
            Else
                txtMonto.EditValue = 0.0
                Comp_No = 0.0
                Per_Id = 0.0
                Mes = 0.0
                IdPago = 0.0
            End If

            .Dispose()
        End With
    End Sub

    Private Sub cbProveedor_EditValueChanged(sender As Object, e As EventArgs) Handles cbProveedor.EditValueChanged
        Cargar()
    End Sub

    Private Sub vDatos_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vDatos.CellValueChanged
        If e.Column.FieldName = "Aplicar" Then
            vDatos.SetRowCellValue(e.RowHandle, "Monto Aplicar", 0)

            Distribuir()

        End If
    End Sub

    Private Sub Distribuir()

        Dim Total As Double = txtMonto.EditValue
        Dim Valor As Double = 0

        With vDatos
            For i As Integer = 0 To vDatos.DataRowCount - 1
                If .GetRowCellValue(i, "Aplicar") = True Then

                    If .GetRowCellValue(i, "Saldo") >= Total Then
                        Valor = Total
                        Total -= Total
                    Else
                        If .GetRowCellValue(i, "Saldo") >= Total Then
                            Valor = Total
                            Total -= Total
                        Else
                            Valor = .GetRowCellValue(i, "Saldo")
                            Total -= .GetRowCellValue(i, "Saldo")
                        End If
                    End If

                    .SetRowCellValue(i, "Monto Aplicar", Valor)
                End If
            Next
        End With
    End Sub

    Private Sub vDatos_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles vDatos.RowCellStyle
        If e.Column.FieldName = "Monto Aplicar" Then
            If vDatos.GetRowCellValue(e.RowHandle, "Monto Aplicar") > 0 Then
                e.Appearance.BackColor = Color.Salmon
                e.Appearance.ForeColor = Color.Navy
                e.Appearance.Font = New Font("Tahoma", 8, FontStyle.Bold)
            End If
        End If
    End Sub
End Class