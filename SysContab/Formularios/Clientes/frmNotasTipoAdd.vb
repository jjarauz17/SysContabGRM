Imports ClasesBLL
Public Class frmNotasTipoAdd

    Public IdTipo As Integer = 0
    Dim obj As New TipoNotasCD
    Dim db As New db_TipoNotasCD

    Private Sub frmNotasTipoAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IdTipo > 0 Then
            obj = db_TipoNotasCD.Detalles(IdTipo)
            '
            txtNombre.Text = obj.Nombre
            txtDescripcion.Text = obj.Descripcion
            chkListaNegra.Checked = IIf(obj.ListaNegra = 1, True, False)
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        obj.IdTipo = IdTipo
        obj.Nombre = txtNombre.Text
        obj.Descripcion = txtDescripcion.Text
        obj.ListaNegra = IIf(chkListaNegra.Checked, 1, 0)

        If IdTipo = 0 Then db.Insertar(obj)
        If IdTipo <> 0 Then db.Actualizar(obj)

        frmNotasTipo.Cargar()
        Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Close()
    End Sub

    Private Sub frmNotasTipoAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
End Class