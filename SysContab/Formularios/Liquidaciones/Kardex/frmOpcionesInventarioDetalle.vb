Public Class frmOpcionesInventarioDetalle

    Dim ProductoN As String
    Dim Codigo As String
    Dim Desde As Date
    Dim Hasta As Date
    Dim Bodega As String
    Public frm As String = "SALDOS"
    Public Saldo As Double = 0.0

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Close()
        ''
        If Not RadioGroup1.EditValue Is Nothing Then

            If frm = "SALDOS" Then
                With frmSaldoInventarios
                    Codigo = .vInvent.GetFocusedRowCellValue("ITEM")
                    ProductoN = .vInvent.GetFocusedRowCellValue("DESCRIPCION")
                    Desde = .Desde.DateTime.Date
                    Hasta = .Hasta.DateTime.Date
                    ' Bodega = .cbBodegas.EditValue
                    Bodega = .vInvent.GetFocusedRowCellValue("CODIGO_BODEGA")
                End With
            ElseIf frm = "CONSULTA" Then
                With frmBuscarProducto
                    Codigo = .iVista.GetFocusedRowCellValue("ITEM")
                    ProductoN = .iVista.GetFocusedRowCellValue("DESCRIPCION")
                    Desde = .Desde.Date
                    Hasta = .Hasta.Date
                    ' Bodega = .cbBodegas.EditValue
                    Bodega = .iVista.GetFocusedRowCellValue("CODIGO_BODEGA")
                End With
            End If

            With frmDetalleMovimiento
                .dgDatos.DataSource = ObtieneDatos("SP_GetDetalleInventario",
                                                   Desde,
                                                   Hasta,
                                                   Bodega, Codigo, RadioGroup1.EditValue, EmpresaActual)
                .vDatos.PopulateColumns()
                '
                Select Case RadioGroup1.EditValue
                    Case 0
                        .etTitulo.Text = "DETALLE DE MOVIMIENTOS EN VENTAS. PRODUCTO: " + ProductoN
                        .GridVentas()
                        .ShowDialog()
                    Case 1
                        .etTitulo.Text = "DETALLE DE MOVIMIENTOS EN COMPRAS. PRODUCTO: " + ProductoN
                        .GridCompras()
                        .ShowDialog()
                    Case 2
                        .etTitulo.Text = "DETALLE DE MOVIMIENTOS EN TRASLADOS. PRODUCTO: " + ProductoN
                        .GridMovimientos()
                        .ShowDialog()
                    Case 3
                        .etTitulo.Text = "DETALLE DE MOVIMIENTOS EN CREDITOS. PRODUCTO: " + ProductoN
                        .GridMovimientos()
                        .ShowDialog()
                    Case 4
                        .etTitulo.Text = "DETALLE DE MOVIMIENTOS EN DEBITOS. PRODUCTO: " + ProductoN
                        .GridMovimientos()
                        .ShowDialog()
                    Case 5
                        .etTitulo.Text = "DETALLE DE MOVIMIENTOS EN AJUSTES. PRODUCTO: " + ProductoN
                        .GridMovimientos()
                        .ShowDialog()

                    Case 6
                        If Saldo > 0.0 Then
                            .etTitulo.Text = "DETALLE DE REMISIONES DE ENTRADA. PRODUCTO: " + ProductoN
                            'FormatoGrid(.vDatos, 4, 0, False, False, True)
                            .ShowDialog()
                        Else
                            XtraMsg("El Producto: " & ProductoN & " no tiene saldo", MessageBoxIcon.Warning)
                        End If
                    Case 7
                        .etTitulo.Text = "DETALLE DE ORDENES DE TRABAJO. PRODUCTO: " + ProductoN
                        .GridMovimientos()
                        .ShowDialog()
                End Select
            End With
        End If
    End Sub

    Sub Cargar()

    End Sub
End Class