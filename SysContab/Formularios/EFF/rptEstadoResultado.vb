Public Class rptEstadoResultado

    Private Sub rptEstadoResultado_DataSourceRowChanged(sender As Object, e As DevExpress.XtraReports.UI.DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        Dim Fila As DataRowView = GetCurrentRow()

        If Fila.Item("Nombre3") = "" Then
            Nombre3.Visible = False
            Cargo3.Visible = False
        End If
    End Sub
End Class