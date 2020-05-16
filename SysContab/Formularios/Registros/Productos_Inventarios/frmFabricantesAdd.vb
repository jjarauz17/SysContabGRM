Imports ClasesBLL
Public Class frmFabricantesAdd

    Dim obj As New Articulos_Fabricantes
    Dim db As New db_Articulos_Fabricantes

    Public ID As Integer = 0
    Public Ok As String = "NO"

    Private Sub frmResponsablesAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' frmTipoCostos.Cargar()
    End Sub

    Private Sub frmResponsablesAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        '
        If ID <> 0 Then
            obj = db_Articulos_Fabricantes.Detalles(ID)
            '
            If Not obj Is Nothing Then
                txtNombre.Text = obj.Nombre
                txtDescripcion.Text = obj.Descripcion
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate() Then Exit Sub
        '
        obj.IdFabricante = ID
        obj.Nombre = txtNombre.Text
        obj.Descripcion = txtDescripcion.Text
        '
        If ID = 0 Then
            db.Insertar(obj)
            Ok = "SI"
        Else
            db.Actualizar(obj)
            Ok = "SI"
        End If
        '
        Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Ok = "NO"
        Close()
    End Sub
End Class