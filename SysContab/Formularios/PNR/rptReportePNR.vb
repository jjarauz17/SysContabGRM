Public Class rptReportePNR

    Public Periodo As Integer = VB.SysContab.Rutinas.Fecha().Year

    Private Sub rptReportePNR_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeforePrint
        'iVista.Columns("Producto").ColumnEdit = cbItems
        'iVista.Columns("Cantidad_Aterior").Caption = "Cantidad " & (Periodo - 1).ToString
        'iVista.Columns("Cantidad").Caption = "Cantidad " & Periodo.ToString
        ' iVista.OptionsView.ShowAutoFilterRow = False
        'For i As Integer = 0 To iVista.Columns.Count - 1
        '    If iVista.Columns(i).ColumnType.FullName = "System.Double" Or iVista.Columns(i).ColumnType.FullName = "System.Decimal" Then
        '        iVista.Columns(i).ColumnEdit = rMonto
        '    End If
        'Next
    End Sub
End Class