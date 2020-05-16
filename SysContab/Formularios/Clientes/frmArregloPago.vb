Public Class frmArregloPago 

    Private Sub frmArregloPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Public Sub Cargar()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmArregloPagoAdd.Dispose()
        frmArregloPagoAdd.MdiParent = Me.MdiParent
        frmArregloPagoAdd.Text = "Nuevo Arreglo de Pago"
        frmArregloPagoAdd.IdArreglo = 0
        frmArregloPagoAdd.Show()
        frmArregloPagoAdd.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        frmExportarImprimir.Mostrar(iGrid, "Arreglos de Pagos")
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Close()
    End Sub
End Class