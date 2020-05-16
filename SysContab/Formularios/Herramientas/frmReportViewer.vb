Public Class frmReportViewer

    Private Sub frmReportViewer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dispose()
        End If
    End Sub

End Class