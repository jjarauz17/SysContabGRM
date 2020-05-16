Public Class frmTipoFacturaAdd

    Public ok As String = ""

    Dim obj As New TipoFacturas
    Dim db As New db_TipoFacturas

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        ok = "NO"
        Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click

        If Me.TextEdit1.Text.Trim.Length = 0 Then
            XtraMsg("Escriba el Nombre", MessageBoxIcon.Error)
            TextEdit1.Focus()
            Exit Sub
        End If

        obj.Empresa = EmpresaActual
        obj.Nombre = TextEdit1.Text

        db.Insertar(obj)
        
        ok = "SI"
        Close()
    End Sub

    Private Sub frmTipoCultivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class