Public Class frmDiseñoFacturaCliente 

    Public ok As String = ""

    Private Sub frmDiseñoFacturaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        ok = "SI"
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        ok = "NO"
        Me.Close()
    End Sub
End Class