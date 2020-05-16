Public Class frmAprobarPedido

    Public Ok As String = "NO"

    Private Sub frmAprobarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Ok = "SI"
        Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Ok = "NO"
        Close()
    End Sub
End Class