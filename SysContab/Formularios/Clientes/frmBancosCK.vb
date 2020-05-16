Imports ClasesBLL
Public Class frmBancosCK

    Dim obj As New BancosCK
    Dim db As New db_BancosCK

    Public IdBanco As Integer = 0
    Public Ok As String = "NO"

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        obj.IdBanco = IdBanco
        obj.Nombre = txtBanco.Text

        If IdBanco = 0 Then
            db.Insertar(obj)
            Ok = "SI"

            Close()
        Else
            db.Actualizar(obj)
            Ok = "SI"

            Close()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Ok = "NO"
        Close()
    End Sub

    Private Sub frmBancosCK_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class