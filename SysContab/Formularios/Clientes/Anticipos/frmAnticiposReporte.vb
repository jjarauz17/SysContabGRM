Imports ClasesBLL
Public Class frmAnticiposReporte
    Private Sub frmAnticiposReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(f).Date

        GetMonedasList(cbMoneda)

        Cargar()
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False)

        iVista.Columns("Codigo").Visible = False
        iVista.Columns("Comp_No").Visible = False
        iVista.Columns("Cliente").Group()
        iVista.ExpandAllGroups()
    End Sub

    Sub Cargar()
        iGrid.DataSource =
            db_AnticiposClientes.ReporteAuxiliar(
            Desde.DateTime.Date,
            Hasta.DateTime.Date,
            cbMoneda.EditValue)

        iVista.ExpandAllGroups()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Cargar()
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        VistaPrevia(iGrid, Me.Text, "Desde: " & Desde.DateTime.ToShortDateString & " Hasta: " & Hasta.DateTime.ToShortDateString)
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text, "Desde: " & Desde.DateTime.ToShortDateString & " Hasta: " & Hasta.DateTime.ToShortDateString)
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then iVista.ShowCustomization()
        If Not CheckEdit1.Checked Then iVista.DestroyCustomization()
    End Sub

    Private Sub iVista_HideCustomizationForm(sender As Object, e As EventArgs) Handles iVista.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub

End Class