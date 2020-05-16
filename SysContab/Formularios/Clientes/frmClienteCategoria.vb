Public Class frmClienteCategoria

    Public Ok As String = "NO"

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Me.txtNombre.Text.Trim.Length = 0 Then
            XtraMsg("Describa el Nombre de la Categoria")
            Me.txtNombre.Focus()
            Exit Sub
        End If
        '
        Guardar()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Ok = "NO"
        Close()
    End Sub

    Sub Guardar()
        If txtCodigo.EditValue = 0 Then
            If GuardaDatos("INSERT INTO Clientes_Categorias (Nombre,Empersa) VALUES ('" & txtNombre.Text & "'," & EmpresaActual & ")") Then
                Ok = "SI"
                Me.Close()
            End If
        Else
            If GuardaDatos("UPDATE Clientes_Categorias SET Nombre = '" & txtNombre.Text & "', Empersa = " & EmpresaActual & " WHERE IdCategoria = " & txtCodigo.EditValue) Then
                Ok = "SI"
                Me.Close()
            End If
        End If
    End Sub

End Class