Public Class FrmDetalleCrossTabDinamicos 

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim forma As New frmExportarImprimir
        forma.Mostrar(GridControl1)
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub FrmDetalleCrossTabDinamicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then GridView1.ShowCustomization()
        If Not CheckEdit1.Checked Then GridView1.DestroyCustomization()
    End Sub

    Private Sub GridView1_HideCustomizationForm(sender As Object, e As EventArgs) Handles GridView1.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub
End Class