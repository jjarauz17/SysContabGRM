Imports DevExpress.XtraReports.UI

Public Class frmReporteAuxiliarProyectos
    Private Sub frmReporteAuxiliarProyectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(f.Date)
        '
        Cargar(Desde.DateTime.Date, Hasta.DateTime.AddYears(-1).Date)
        Grid()
    End Sub

    Sub Cargar(fDesde As Date, fHasta As Date)
        iGrid.DataSource = db_Proyectos.Reporte(fDesde, fHasta)
    End Sub

    Sub Grid()
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False)
        iVista.Columns("Proyecto").Group()
        iVista.ExpandAllGroups()
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        ShowSplash()
        Cargar(Desde.DateTime.Date, Hasta.DateTime.Date)
        iVista.ExpandAllGroups()
        HideSplash()
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        ShowSplash("Imprimiendo Auxiliar...")
        Dim rpt As New rptReporteAuxilarProyecto
        rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image

        VistaPreviaDX(rpt,
                      db_Proyectos.ReporteImprimir(Desde.DateTime.Date, Hasta.DateTime.Date),
                      "Reporte Auxliar de Proyectos")

        HideSplash()

        'rpt.DataSource = db_Proyectos.ReporteImprimir(Desde.DateTime.Date, Hasta.DateTime.Date)

        'Try
        '    Dim DT_LOGO As DataTable = VB.SysContab.EmpresasDB.GetLogoEmpresa().Tables(0)
        '    Dim _logo As Byte() = DirectCast(DT_LOGO.Rows.Item(0)("Logo"), Byte())
        '    Dim ms As New System.IO.MemoryStream(_logo)
        '    rpt.pLogo.Image = Image.FromStream(ms)

        'Catch ex As Exception
        'End Try

        'HideSplash()
        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        'rpt.ShowRibbonPreview()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text, "Del " & Desde.DateTime.ToShortDateString & "Al " & Hasta.DateTime.ToShortDateString)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Close()
    End Sub
End Class