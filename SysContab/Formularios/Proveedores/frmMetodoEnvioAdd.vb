Public Class frmMetodoEnvioAdd

    Public IdDetalle As Integer = 0
    Public Ok As String = "NO"

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If txtNombre.Text.Trim.Length = 0 Then
            XtraMsg("Introduzca el Nombre")
            txtNombre.Focus()
            Exit Sub
        End If
        '
        If IdDetalle = 0 Then   'Editar
            GuardaDatos("INSERT INTO Metodos_Envio (Nombre, Descripcion, Empresa) " & _
                        "VALUES ('" & txtNombre.Text & "','" & txtDescripcion.Text & "'," & EmpresaActual & ")")
            Ok = "SI"
            Close()
        Else                    'Actualizar
            GuardaDatos("UPDATE Metodos_Envio SET Nombre = '" & txtNombre.Text & "'," & _
                        " Descripcion = '" & txtDescripcion.Text & "'" & _
                        " WHERE IdDetalle = " & IdDetalle)
            Ok = "SI"
            Close()
        End If

    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Ok = "NO"
        Close()
    End Sub
End Class