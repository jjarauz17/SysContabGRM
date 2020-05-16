Public Class frmAgregarGrupoPNR

    Public IdGrupo As Integer = 0
    Public Ok As String = "NO"

    Private Sub frmAgregarGrupoPNR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        If IdGrupo > 0 Then
            Dim DT As DataTable = ObtieneDatos("PRN_sel_grupos " & IdGrupo & "," & EmpresaActual)

            txtNombre.Text = DT.Rows.Item(0)("Nombre")
            txtUnidad.Text = DT.Rows.Item(0)("Unidad")
        End If
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        If IdGrupo = 0 Then     'Guardar
            GuardaDatos("INSERT INTO PNR_Grupos (Empresa,Nombre,Unidad) VALUES (" & EmpresaActual & ",'" & txtNombre.Text & "','" & txtUnidad.Text & "')")
        Else                    'Actualizar
            GuardaDatos("UPDATE PNR_Grupos SET Nombre = '" & txtNombre.Text & "', Unidad = '" & txtUnidad.Text & "' WHERE IdGrupo = " & IdGrupo)
        End If

        Ok = "SI"
        Close()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Ok = "NO"
        Close()
    End Sub
End Class