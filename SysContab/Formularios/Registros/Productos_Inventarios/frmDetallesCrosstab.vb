Public Class frmDetallesCrosstab 

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then vDatos.ShowCustomization()
        If Not CheckEdit1.Checked Then vDatos.DestroyCustomization()
    End Sub

    Private Sub vDatos_HideCustomizationForm(sender As Object, e As EventArgs) Handles vDatos.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub

    Private Sub cmdexportar_Click(sender As Object, e As EventArgs) Handles cmdexportar.Click
        frmExportarImprimir.Mostrar(dgDatos)
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Close()
    End Sub
End Class