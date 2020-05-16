Public Class frmDetalleDePagosFC

    Private Sub frmDetalleDePagosFC_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Desde.DateTime = New DateTime(f.Year, f.Month, 1)
        Hasta.DateTime = f.Date
        '
        GetMonedasList(cbMoneda)
        '
        cbRubro.Properties.DataSource = ObtieneDatos("sp_GetTiposProveedores", EmpresaActual)
        cbRubro.Properties.ValueMember = "CUENTA"
        cbRubro.Properties.DisplayMember = "Display"
        cbRubro.Properties.PopulateColumns()
        cbRubro.Properties.Columns("Display").Visible = False
        cbRubro.ItemIndex = 0

        dgDatos.DataSource = VB.SysContab.ProveedoresDB.RelacionDeSaldos(Desde.DateTime.AddMonths(2).Date,
                                                                         Hasta.DateTime.Date,
                                                                         cbRubro.EditValue,
                                                                         cbMoneda.EditValue)
        vDatos.PopulateColumns()
        FormatoGrid(vDatos)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        ShowSplash("Generando Reporte...")

        dgDatos.DataSource = VB.SysContab.ProveedoresDB.RelacionDeSaldos(Desde.DateTime.Date,
                                                                         Hasta.DateTime.Date,
                                                                         cbRubro.EditValue,
                                                                         cbMoneda.EditValue)

        HideSplash()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        frmExportarImprimir.Mostrar(dgDatos, "Relación de Saldo de Proveedores", "Del Periodo: " & Desde.DateTime.ToShortDateString & " Al " & Hasta.DateTime.ToShortDateString)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Close()
    End Sub
End Class