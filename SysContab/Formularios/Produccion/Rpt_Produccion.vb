Public Class Rpt_Produccion
    'Color Blanco por default
    Public _Etiqueta As String = "255, 255, 255"
    Private Sub Rpt_Produccion_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeforePrint
        Try
            Estado.BackColor = System.Drawing.ColorTranslator.FromHtml(_Etiqueta)
        Catch ex As Exception
        End Try

    End Sub
End Class