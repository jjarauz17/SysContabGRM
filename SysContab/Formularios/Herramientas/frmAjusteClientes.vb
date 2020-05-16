Public Class frmAjusteClientes 

    Private Sub frmAjusteClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = f.Date

        Combo(cbSucursal, ObtieneDatos("sp_GetSucursalesClientes", EmpresaActual))
        cbSucursal.ItemIndex = 0

        iGrid.DataSource = ObtieneDatos("JAR_BuscarDiferenciasClientes", Desde.DateTime.Date.AddMonths(2), Hasta.DateTime.Date, IIf(cbSucursal.ItemIndex = 0, "%", cbSucursal.EditValue), EmpresaActual)
        iVista.PopulateColumns()
        FormatoGrid(iVista)
    End Sub

    Sub Cargar()
        iGrid.DataSource = ObtieneDatos("JAR_BuscarDiferenciasClientes", Desde.DateTime.Date, Hasta.DateTime.Date, IIf(cbSucursal.ItemIndex = 0, "%", cbSucursal.EditValue), EmpresaActual)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash("Generando Saldos...")
        Cargar()
        HideSplash()
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid)
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Close()
    End Sub
End Class