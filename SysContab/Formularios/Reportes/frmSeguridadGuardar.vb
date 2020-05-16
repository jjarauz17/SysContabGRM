Public Class frmSeguridadGuardar 

    Public Ok As String
    Dim Codigo As String = "xxxxxxxxxx"

    Private Sub frmSeguridadGuardar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Codigo = CStr(ObtieneDatos("SELECT Codigo FROM CodigoFactura WHERE Tipo = 2").Rows.Item(0)("Codigo"))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Ok = "NO"
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If Me.txtCodigo.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        If Me.txtCodigo.Text.Equals(Codigo) Then
            Ok = "SI"
            Me.Close()
        Else
            Me.txtCodigo.Text = vbNullString
            Me.txtCodigo.Focus()
            MsgBox("Código Inválido, Consulte con el Administrador del Sistema", MsgBoxStyle.Critical)
        End If
    End Sub
End Class