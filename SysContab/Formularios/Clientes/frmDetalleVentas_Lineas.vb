Public Class frmDetalleVentas_Lineas

    Public Ok As Boolean = False

    Private Sub frmDetalleVentas_Lineas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub


        Ok = True
        Close()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Ok = False
        Close()
    End Sub
End Class