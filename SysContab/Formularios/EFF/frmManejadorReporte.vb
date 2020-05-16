Public Class frmManejadorReporte

    Public CerrarMDI As Boolean

    Private Sub PrintPreviewBarItem27_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintPreviewBarItem27.ItemClick
        If CerrarMDI Then
            Dispose()
            frmMDIReporte.Dispose()
        End If

    End Sub
End Class