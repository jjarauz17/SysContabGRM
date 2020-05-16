Public Class frmConciliacion_NoEncontrados 

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        frmExportarImprimir.Mostrar(dgDatos)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub
End Class