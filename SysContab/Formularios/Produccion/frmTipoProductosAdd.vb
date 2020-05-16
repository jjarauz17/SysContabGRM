Public Class frmTipoProductosAdd

    Dim obj As New Prod_TipoProductos
    Dim db As New db_Prod_TipoProductos

    Public ID As Integer = 0
    Public Ok As String = "NO"

    Private Sub frmResponsablesAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmTipoProductos.Cargar()
    End Sub

    Private Sub frmResponsablesAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        '
        If ID <> 0 Then
            obj = db_Prod_TipoProductos.Detalles(ID)

            If Not obj Is Nothing Then
                txtNombre.Text = obj.NombreTipoProd
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate() Then Exit Sub
        '
        obj.CodTipoProd = ID
        obj.Empresa = EmpresaActual
        obj.NombreTipoProd = txtNombre.Text


        If ID = 0 Then
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