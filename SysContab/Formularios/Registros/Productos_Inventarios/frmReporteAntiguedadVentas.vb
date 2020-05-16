Imports System.IO
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors.Repository
Public Class frmReporteAntiguedadVentas

    Dim Clientes As VB.SysContab.ClientesDB
    Public SucID As String = "%", Moneda As String = "01"

    Private Sub frmDinamicoCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(f).Date

        'Dim f As Date = BuscarUltimoCierre().Date
        'Hasta.Properties.MaxValue = f.Date
        'Hasta.DateTime = f.Date

        Dim Detalle As VB.SysContab.ConfiguracionDetails
        Detalle = VB.SysContab.ConfiguracionDB.GetConfigDetails()
        '       
        'GetBodegasList(cbBodegas)
        GetBodegasxUsuario(cbBodegas)
        cbBodegas.SetEditValue(Detalle.Bodega)
        GetMonedasList(cbMoneda)
        '
        LlenarGrid()
        FormatoPivot(iPivotGrid)
    End Sub

    Private Sub LlenarGrid()
        'Dim DT As DataTable = ObtieneDatos("JAR_AntiguedadInventario", Hasta.DateTime.Date.AddYears(-50).Date, cbBodegas.EditValue, EmpresaActual)
        Dim DT As DataTable =
            VB.SysContab.ArticulosDB _
            .AntiguedadDeLoVendido(
            Desde.DateTime.Date,
            Hasta.DateTime.Date.AddYears(-50).Date,
            cbBodegas.EditValue,
            cbMoneda.EditValue)

        iPivotGrid.DataSource = DT
        iPivotGrid.Fields.Clear()
        '
        For i As Integer = 0 To DT.Columns.Count - 1
            Dim Campo As New DevExpress.XtraPivotGrid.PivotGridField
            iPivotGrid.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Campo})
            Campo.FieldName = DT.Columns(i).Caption.ToString
            Campo.Name = "Field" & DT.Columns(i).Caption.ToString
        Next
        '

        iPivotGrid.Fields("Antiguedad").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea

        iPivotGrid.Fields("Bodega").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Codigo").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Item").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea

        iPivotGrid.Fields("Costo Total").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea

        'iPivotGrid.Fields("Corriente").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("30 Dias").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("60 Dias").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("90 Dias").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("120 Dias").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("150 Dias").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("180 Dias").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("270 Dias").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("1 Año").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("2 Años").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("3 Años").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("4 Años").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("5 Años").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("Mas 5 Años").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("Total").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea

        iPivotGrid.Fields("Precio").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        iPivotGrid.Fields("Costo Unitario").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average

        'iPivotGrid.Fields("Precio 1").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        'iPivotGrid.Fields("Precio 2").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        'iPivotGrid.Fields("Precio U$ 1").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        'iPivotGrid.Fields("Precio U$ 2").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average

        iPivotGrid.Fields("Bodega").Width = 150
        iPivotGrid.Fields("Proveedor").Width = 250
        iPivotGrid.Fields("Item").Width = 250

        iPivotGrid.OptionsSelection.MultiSelect = True
        iPivotGrid.OptionsView.ShowRowTotals = True
        'iPivotGrid.OptionsView.ShowRowTotals = False
        iPivotGrid.OptionsView.ShowRowGrandTotals = True
    End Sub

    Private Sub bGrafico_Click(sender As Object, e As EventArgs) Handles bGrafico.Click
        With frmGraficosDinamicos

            .iGrafico.DataSource = iPivotGrid
            .iGrafico.SeriesDataMember = "Series"
            .iGrafico.SeriesTemplate.ArgumentDataMember = "Arguments"
            .iGrafico.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Values"})
            .iGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
            .etTitulo.Text = "Gráfico Dinámico de Antiguedad de lo Vendido"

            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub bGuardarEsquema_Click(sender As Object, e As EventArgs) Handles bGuardarEsquema.Click
        If Guardar.ShowDialog = DialogResult.OK Then
            iPivotGrid.SaveLayoutToXml(Guardar.FileName)
        End If
    End Sub

    Private Sub bRestaurarEsquema_Click(sender As Object, e As EventArgs) Handles bRestaurarEsquema.Click
        If Abrir.ShowDialog = DialogResult.OK Then
            CargarEsquemaDefault(Abrir.FileName)
        End If
    End Sub

    Private Sub CargarEsquemaDefault(ByVal NombreArchivo As String)
        If Not NombreArchivo.ToString = vbNullString Then

            If File.Exists(NombreArchivo) Then
                iPivotGrid.RestoreLayoutFromXml(NombreArchivo)
                iPivotGrid.Refresh()
            End If
        End If
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iPivotGrid, "Dinámico de Antiguedad de lo Vendido")
    End Sub

    Private Sub iPivotGrid_CellDoubleClick(sender As Object, e As PivotCellEventArgs) Handles iPivotGrid.CellDoubleClick
        FrmDetalleCrossTabDinamicos.Dispose()
        '
        With FrmDetalleCrossTabDinamicos
            .Text = "Detalle Antiguedad de lo Vendido"
            .StartPosition = FormStartPosition.CenterParent
            .GridControl1.DataSource = e.CreateDrillDownDataSource()
            .GridView1.PopulateColumns()
            FormatoGrid(.GridView1)
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash("Generando Reporte...")
        'Dim DT As DataTable = ObtieneDatos("JAR_AntiguedadInventario", Hasta.DateTime.Date, cbBodegas.EditValue, EmpresaActual)
        Dim DT As DataTable =
            VB.SysContab.ArticulosDB.AntiguedadDeLoVendido(
            Desde.DateTime.Date,
            Hasta.DateTime.Date,
            cbBodegas.EditValue,
            cbMoneda.EditValue)

        iPivotGrid.DataSource = DT
        HideSplash()
    End Sub

    Private Sub bActualizar_Click(sender As Object, e As EventArgs) Handles bActualizar.Click
        LlenarGrid()
        FormatoPivot(iPivotGrid)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        iPivotGrid.OptionsView.ShowRowTotals = Not CheckEdit1.Checked
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        iPivotGrid.OptionsView.ShowRowGrandTotals = Not CheckEdit2.Checked
    End Sub
End Class