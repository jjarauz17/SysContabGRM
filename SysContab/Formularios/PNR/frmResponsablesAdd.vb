Public Class frmResponsablesAdd

    Dim obj As New PNR_Responsables
    Dim db As New db_PNR_Responsables

    Public IdResponsable As Integer = 0
    Public Ok As String = "NO"

    Private Sub frmResponsablesAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmResponsables.Cargar()
    End Sub

    Private Sub frmResponsablesAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        '
        If IdResponsable <> 0 Then
            obj = db_PNR_Responsables.Detalles(IdResponsable)

            If Not obj Is Nothing Then
                txtNombre.Text = obj.Nombre
                txtCargo.Text = obj.Cargo
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate() Then Exit Sub
        '
        obj.IdResponsable = IdResponsable
        obj.Empresa = EmpresaActual
        obj.Nombre = txtNombre.Text
        obj.Cargo = txtCargo.Text

        If IdResponsable = 0 Then
            db.Insertar(obj)
            Ok = "SI"
        Else
            db.Actualizar(obj)
        End If

        Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Ok = "NO"
        Close()
    End Sub
End Class