Imports System.Drawing.Printing

Public Class rptEstadoResultadoPorLinea

    Public DT As DataTable

    Private Sub rptEstadoResultadoPorLinea_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        iPivotMes.DataSource = DT
    End Sub
End Class