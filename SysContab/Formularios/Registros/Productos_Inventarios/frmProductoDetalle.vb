Public Class frmProductoDetalle

    Public Codigo As String = String.Empty
    Public Tipo As String = String.Empty

    Private Sub frmProductoDetalle_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Dispose()
    End Sub

    Private Sub frmProductoDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ShowSplash()
        Dim _DT As DataTable = ObtieneDatos("sp_ARTICULOS_GetTarjeta",
                                            Tipo,
                                            Codigo,
                                            EmpresaActual)
        HideSplash()

        If _DT.Rows.Count > 0 Then
            tCodigo.Text = _DT.Rows.Item(0)("Codigo")
            NoParte.Text = _DT.Rows.Item(0)("NoParte")
            Descripcion.Text = _DT.Rows.Item(0)("Descripcion")
            DesProv.Text = _DT.Rows.Item(0)("DescProveedor")
            Proveedor.Text = _DT.Rows.Item(0)("Proveedor")
            Fabricante.Text = _DT.Rows.Item(0)("Fabricante")
            Linea.Text = _DT.Rows.Item(0)("Linea")
            Grupo.Text = _DT.Rows.Item(0)("Grupo")
            lUrl.Text = _DT.Rows.Item(0)("URL")

            If _DT.Rows.Item(0)("Foto") IsNot DBNull.Value Then
                Foto.Image = Bytes2Image(CType(_DT.Rows.Item(0)("Foto"), Byte()))
            End If

            lblUltimoCierre.Text = IsNull(_DT.Rows.Item(0)("UltimoCierre"), "")
            lblUltimaCompra.Text = IsNull(_DT.Rows.Item(0)("UltimaCompra"), "")
            lblUltimaVenta.Text = IsNull(_DT.Rows.Item(0)("UltimaVenta"), "")

            iGrid.DataSource = _DT
            iVista.Focus()
        End If
    End Sub

    Private Sub Url_Click(sender As Object, e As EventArgs)
        Try
            Process.Start(sender.Text)
        Catch ex As Exception
            XtraMsg("URL inválida: " + ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lUrl_Click(sender As Object, e As EventArgs) Handles lUrl.Click
        Try
            Process.Start(lUrl.Text)
        Catch ex As Exception
            XtraMsg("URL inválida: " + ex.Message,
                    MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lblKardex_Click(sender As Object, e As EventArgs) Handles lblKardex.Click
        ShowSplash()
        frmKardexProducto.Dispose()
        frmKardexProducto.Text = "Kardex del " & Me.Text
        frmKardexProducto.Producto = Codigo
        frmKardexProducto.Bodega = "KARDEX"
        frmKardexProducto.Show()
        HideSplash()
    End Sub

    Private Sub iGrid_Click(sender As Object, e As EventArgs) Handles iGrid.Click

    End Sub
End Class