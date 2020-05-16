Public Class frmProformaCondicionesAdd

    Public _Codigo As Integer = 0
    Private ObjEstados As New ProformaCondicionesCLS

    Private Sub frmProformaEstados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmCondicionesVenta.Cargar()
    End Sub

    Private Sub frmProformaEstados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _Codigo > 0 Then
            ObjEstados.Load(_Codigo)

            txtNombre.Text = ObjEstados.Nombre
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate Then Exit Sub

        ObjEstados.IdCondicion = _Codigo
        ObjEstados.Nombre = txtNombre.Text
        
        If ObjEstados.Save() Then
            ObjEstados.Dispose()
            Close()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub
End Class