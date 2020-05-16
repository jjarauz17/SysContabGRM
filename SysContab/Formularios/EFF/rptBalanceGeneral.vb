Public Class rptBalanceGeneral

    Private Sub rptBalanceGeneral_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeforePrint

    End Sub

    Private Sub rptBalanceGeneral_DataSourceRowChanged(sender As Object, e As DevExpress.XtraReports.UI.DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        Dim Fila As DataRowView = GetCurrentRow()

        If Fila.Item("Nombre3") = "" Then
            Nombre3.Visible = False
            Cargo3.Visible = False
        End If
        '
    End Sub
End Class