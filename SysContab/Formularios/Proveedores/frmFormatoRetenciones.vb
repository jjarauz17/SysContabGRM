Public Class frmFormatoRetenciones

    Public Desde As Date,
        Hasta As Date

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        With frmExportarImprimir
            .Mostrar(iGrid)
        End With
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Close()
    End Sub

    Private Sub frmFormatoRetenciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cargar()

    End Sub
End Class