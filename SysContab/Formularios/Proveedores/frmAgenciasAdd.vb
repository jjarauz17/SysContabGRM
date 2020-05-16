Public Class frmAgenciasAdd

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
            GuardaDatos("INSERT INTO Agencias (Nombre,	Descripcion, Tiempo, Empresa) " & _
                        "VALUES ('" & txtNombre.Text & "','" & txtDescripcion.Text & "'," & IIf(sTiempo.EditValue Is Nothing, 0, sTiempo.EditValue) & ", " & EmpresaActual & ")")
            Ok = "SI"
            Close()
        Else                    'Actualizar
            GuardaDatos("UPDATE Agencias SET Nombre = '" & txtNombre.Text & "'," & _
                        " Descripcion = '" & txtDescripcion.Text & "'," & _
                        " Tiempo = '" & IIf(sTiempo.EditValue Is Nothing, 0, sTiempo.EditValue) & "'" & _
                        " WHERE IdDetalle = " & IdDetalle)
            Ok = "SI"
            Close()
        End If

    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Ok = "NO"
        Close()
    End Sub

    Private Sub frmAgenciasAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class