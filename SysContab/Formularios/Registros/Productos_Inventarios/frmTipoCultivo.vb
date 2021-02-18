Public Class frmTipoCultivo

    Public ok As String = ""

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        ok = "NO"
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If Me.TextEdit1.Text.Trim.Length = 0 Then
            XtraMsg("Escriba el Código del Cultivo", MessageBoxIcon.Error)
            TextEdit1.Focus()
            Exit Sub
        End If

        If Not IsNumeric(TextEdit1.Text) Then
            XtraMsg("El Código del Cultivo es inválido, debe ser un valor numerico.", MessageBoxIcon.Error)
            TextEdit1.Focus()
            Exit Sub
        End If

        If Me.MemoEdit1.Text.Trim.Length = 0 Then
            XtraMsg("Describa el Tipo de Cultivo", MessageBoxIcon.Error)
            Me.MemoEdit1.Focus()
            Exit Sub
        End If

        If ObtieneDatos("SELECT * FROM TipoCultivo tc WHERE Codigo = '" & Me.TextEdit1.Text.Trim & "' AND Empresa = " & EmpresaActual).Rows.Count > 0 Then
            XtraMsg("El Código del Cultivo ya Existe", MessageBoxIcon.Warning)
            Me.TextEdit1.Focus()
            Me.TextEdit1.SelectAll()
            Exit Sub
        End If

        If GuardaDatos("INSERT INTO TipoCultivo VALUES ('" & Me.TextEdit1.Text.Trim & "'," & EmpresaActual & ",'" & Me.MemoEdit1.Text.Trim & "')") Then
            ok = "SI"
            Me.Close()
        Else
            ok = "NO"
            ' XtraMsg("Error al Realizar Transacción, Consulte con el Administrador del Sistema", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmTipoCultivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class