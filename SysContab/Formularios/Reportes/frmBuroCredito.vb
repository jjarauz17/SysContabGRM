Public Class frmBuroCredito 

    Private Sub frmBuroCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AlCorte.DateTime = UltimoDiaDelMes(VB.SysContab.Rutinas.Fecha().Date).Date
        '
        GetMonedasList(cbMoneda)
        '
        Combo(cbSucursal, ObtieneDatos("JAR_GetSucursalesClientes", EmpresaActual))
        cbSucursal.ItemIndex = 0
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        ShowSplash("Generando Informe...")

        Dim DT As DataTable = ObtieneDatos("JAR_ReporteBuroCredito", AlCorte.DateTime.Date, _
                                           cbMoneda.EditValue, _
                                           cbSucursal.EditValue, _
                                           EmpresaActual)

        iGrid.DataSource = DT
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False)
        '
        HideSplash()
    End Sub

    Private Sub cmdAyuda_Click(sender As Object, e As EventArgs) Handles cmdAyuda.Click
        frmExportarImprimir.Mostrar(iGrid, "Reporte Buro de Crédito al :" & AlCorte.DateTime.ToShortDateString)
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Close()
    End Sub
End Class