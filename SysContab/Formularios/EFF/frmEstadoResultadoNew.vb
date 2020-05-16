Public Class frmEstadoResultadoNew
    Private Sub frmEstadoResultadoNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        '
        GetMonedasList(cbMoneda)

        Dim Fechas As New VB.SysContab.FechasdeOperacion
        '
        Desde.Properties.MinValue = Fechas.FechaMinima
        Desde.Properties.MaxValue = Fechas.FechaMaxima
        Hasta.Properties.MinValue = Fechas.FechaMinima
        Hasta.Properties.MaxValue = Fechas.FechaMaxima
        '
        Desde.DateTime = New DateTime(f.Year, f.Month, 1)
        Hasta.DateTime = UltimoDiaDelMes(f.Date).Date
    End Sub

    Private Sub bGenear_Click(sender As Object, e As EventArgs) Handles bGenear.Click
        If RadioGroup1.EditValue = 1 Then
            ShowSplash("Generando Informe...")
            '
            Dim DT_ER As DataTable = ObtieneDatos("JAR_EstadoDeResultado_V2", Desde.DateTime.Date, Hasta.DateTime.Date, cbMoneda.EditValue, EmpresaActual)
            Dim rpt As New rptEstadoResultadoTrandicional
            '
            'Try
            '    Dim DT_LOGO As DataTable = VB.SysContab.EmpresasDB.GetLogoEmpresa().Tables(0)
            '    Dim _logo As Byte() = DirectCast(DT_LOGO.Rows.Item(0)("Logo"), Byte())
            '    Dim ms As New System.IO.MemoryStream(_logo)
            '    rpt.pLogo.Image = Image.FromStream(ms)
            'Catch ex As Exception
            'End Try
            '
            rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image
            DocumentViewer1.PrintingSystem = rpt.PrintingSystem
            rpt.DataSource = DT_ER
            rpt.ShowPrintMarginsWarning = False
            rpt.CreateDocument()
            '
            HideSplash()

        ElseIf RadioGroup1.EditValue = 2 Then
            ShowSplash("Generando Informe...")

            Dim DT_ER As DataTable = ObtieneDatos("JAR_EstadoDeResultado", Hasta.DateTime.Date, cbMoneda.EditValue, EmpresaActual, IIf(chkComparativo.Checked, 1, 0))

            If chkComparativo.Checked Then
                Dim rpt As New rptEstadoResultado
                '
                rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image
                DocumentViewer1.PrintingSystem = rpt.PrintingSystem
                rpt.DataSource = DT_ER
                rpt.CreateDocument()

                'rpt.ShowPrintMarginsWarning = False
                'rpt.BringToFront()
                'rpt.ShowRibbonPreview()

                HideSplash()
                '
                'If chkUtilidadLinea.Checked Then
                '    Dim rptUL As New rptEstadoResultadoPorLinea
                '    rptUL.DataSource = DT_ER
                '    rptUL.BringToFront()
                '    rptUL.ShowRibbonPreview()
                'End If
            Else
                Dim rpt As New rptEstadoResultadoGeneral

                rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image
                DocumentViewer1.PrintingSystem = rpt.PrintingSystem
                rpt.DataSource = DT_ER
                rpt.CreateDocument()

                HideSplash()
                'rpt.ShowPrintMarginsWarning = False
                'rpt.BringToFront()
                'rpt.ShowRibbonPreview()

                'If chkUtilidadLinea.Checked Then
                '    Dim rptUL As New rptEstadoResultadoPorLinea
                '    rptUL.DT = DT_ER
                '    rptUL.DataSource = DT_ER
                '    rptUL.BringToFront()
                '    rptUL.ShowRibbonPreview()
                'End If
            End If
        End If
    End Sub
End Class