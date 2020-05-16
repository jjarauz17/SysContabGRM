Imports DevExpress.XtraSplashScreen

Module Globales

    Public WaitTitulo As String = "Cargando..."

    Sub ShowSplash(Optional ByVal sTitulo As String = "")
        Try
            If sTitulo <> "" Then WaitTitulo = sTitulo
            If sTitulo = "" Then WaitTitulo = "Cargando..."
            SplashScreenManager.ShowForm(GetType(WaitForm))
        Catch ex As Exception
        End Try
    End Sub

    Sub HideSplash()
        Try
            SplashScreenManager.CloseForm()
        Catch ex As Exception
        End Try
    End Sub

End Module
