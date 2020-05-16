Public Class frmCuentasxCobrar 

    Private Sub frmCuentasxCobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMonedasList(cbMoneda)        

        LookUp(cbSucursal, ObtieneDatos("JAR_GetSucursalesxUsuario", EmpresaActual), "Nombre", "Sucursal", "[Seleccione Surusal]", 0)
        cbSucursal.ItemIndex = 0

        Dim fa As Date = VB.SysContab.Rutinas.Fecha().Date

        Desde.DateTime = New DateTime(fa.Year, fa.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(fa.Date).Date
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash("Generando Informe...")
        '
        Dim DT As DataTable = ObtieneDatos("JAR_InformeCuentasxCobrar", Desde.DateTime.Date, _
                                           Hasta.DateTime.Date, _
                                           cbMoneda.EditValue, _
                                           cbSucursal.EditValue, _
                                           EmpresaActual)

        iGrid.DataSource = DT
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False)
        '
        HideSplash()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        frmExportarImprimir.Mostrar(iGrid, "CUENTAS POR COBRAR CLIENTES " & cbSucursal.Text.ToUpper, "Del Periodo " & Desde.DateTime.ToShortDateString & " Al " & Hasta.DateTime.ToShortDateString)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub
End Class

