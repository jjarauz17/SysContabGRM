Public Class frmEntregarProducto

    Public NoFactura As String = vbNullString
    Dim DT As DataTable

    Private Sub frmEntregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchLookUp(cbCliente, ObtieneDatos("SP_GetClientes", EmpresaActual, 1), "Nombre", "Codigo", 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)
        LookUp(cbFormaPago, ObtieneDatos("_FormaPagoList", EmpresaActual), "Nombre", "Codigo", "[Forma de Pago]", 0, 2, 3)
        GetBodegasList(cbBodega)
        GetMonedasList(cbMoneda)
        GetVendedores(cbVendedor)

        DT = ObtieneDatos("JAR_FacturaDetalle", NoFactura, EmpresaActual)

        If DT.Rows.Count = 0 Then
            XtraMsg("Esta Factura no contiene productos", MessageBoxIcon.Hand)
            Dispose()
        End If

        If DT.Rows.Item(0)("Estado") Then
            XtraMsg("La Factura se encuentra *Anulada*", MessageBoxIcon.Hand)
            Dispose()
        End If

        If DT.Rows.Count > 0 Then
            If Not DT.Rows.Item(0)("Estado") Then

                Factura.Text = NoFactura
                cbCliente.EditValue = DT.Rows.Item(0)("Cliente")
                ANombre.Text = DT.Rows.Item(0)("Nombre_Cliente")
                Fecha.DateTime = DT.Rows.Item(0)("Fecha")
                cbFormaPago.EditValue = DT.Rows.Item(0)("Tipo_Factura")
                cbBodega.EditValue = DT.Rows.Item(0)("Bodega")
                NoRemision.Text = IsNull(DT.Rows.Item(0)("Remision"), "")
                cbVendedor.EditValue = DT.Rows.Item(0)("Vendedor")
                cbMoneda.EditValue = DT.Rows.Item(0)("mon_mtto")

                iGrid.DataSource = DT
                iVista.PopulateColumns()
                FormatoGrid(iVista, 4, 0, False, False, False)
                '
                For i As Integer = 0 To iVista.Columns.Count - 1
                    iVista.Columns(i).Visible = False
                    iVista.Columns(i).OptionsColumn.AllowEdit = False
                Next
                '
                Me.iVista.Columns("Item").Visible = True
                Me.iVista.Columns("Descripcion").Visible = True
                Me.iVista.Columns("Cantidad").Visible = True
                Me.iVista.Columns("Precio").Visible = True
                Me.iVista.Columns("Iva").Visible = True
                Me.iVista.Columns("Monto").Visible = True
                Me.iVista.Columns("Descuento").Visible = True
                Me.iVista.Columns("Total").Visible = True
                iVista.Columns("Entregado").Visible = True
                iVista.Columns("Cant. Entregada").Visible = True

                '
                Me.iVista.Columns("Item").VisibleIndex = 0
                Me.iVista.Columns("Descripcion").VisibleIndex = 1
                Me.iVista.Columns("Cantidad").VisibleIndex = 2
                Me.iVista.Columns("Precio").VisibleIndex = 3
                Me.iVista.Columns("Monto").VisibleIndex = 4
                Me.iVista.Columns("Descuento").VisibleIndex = 5
                Me.iVista.Columns("Iva").VisibleIndex = 6
                Me.iVista.Columns("Total").VisibleIndex = 7

                iVista.Columns("Cant. Entregada").OptionsColumn.AllowEdit = True
                iVista.Columns("Entregado").OptionsColumn.AllowEdit = True
                iVista.Columns("Descuento").ColumnEdit = rDescuento
                iVista.Columns("Cant. Entregada").ColumnEdit = rCantidad
                iVista.Columns("Entregado").ColumnEdit = rEntregar
                Me.iVista.Columns("Descripcion").Width = 200
            End If
        End If

    End Sub

    Sub Cargar()
        DT = ObtieneDatos("JAR_FacturaDetalle", NoFactura, EmpresaActual)
        iGrid.DataSource = DT
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Dim NoEntregado As Integer = 0

        For i As Integer = 0 To iVista.DataRowCount - 1
            If Not iVista.GetRowCellValue(i, "Entregado") Then NoEntregado += 1
        Next

        If NoEntregado > 0 Then
            If Not XtraMsg2("Existen (" & NoEntregado & ") producto(s) sin Entregar, Esta seguro?") Then
                Exit Sub
            End If
        End If

        For i As Integer = 0 To iVista.DataRowCount - 1
            Guardar("JAR_MarcarProductoEntregado", iVista.GetRowCellValue(i, "Numero"), _
                    IIf(iVista.GetRowCellValue(i, "Entregado"), 1, 0), _
                    EmpresaActual, _
                    iVista.GetRowCellValue(i, "Cant. Entregada"))
        Next

        XtraMsg("Datos de Factura Actualizados con Exito!")
        Cargar()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        For i As Integer = 0 To iVista.DataRowCount - 1
            iVista.SetRowCellValue(i, "Cant. Entregada", iVista.GetRowCellValue(i, "Cantidad"))
            iVista.SetRowCellValue(i, "Entregado", True)
        Next
        iVista.RefreshData()
    End Sub

    Private Sub iVista_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles iVista.ValidateRow
        If iVista.GetRowCellValue(iVista.FocusedRowHandle, "Cant. Entregada") < iVista.GetRowCellValue(iVista.FocusedRowHandle, "Cantidad") Then
            iVista.SetRowCellValue(e.RowHandle, "Entregado", False)
        ElseIf iVista.GetRowCellValue(iVista.FocusedRowHandle, "Cant. Entregada") = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Cantidad") Then
            iVista.SetRowCellValue(e.RowHandle, "Entregado", True)
        Else
            e.ErrorText = "No se puede Entregar más producto de lo facturado." & vbCrLf
            e.Valid = False
        End If
    End Sub
End Class