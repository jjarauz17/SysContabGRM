Imports System.IO
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors.Repository
Public Class frmReporteAntiguedadInventarios

    Dim Clientes As VB.SysContab.ClientesDB
    Public SucID As String = "%", Moneda As String = "01"

    Private Sub frmDinamicoCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = UltimoCierreInventario().Date 'VerificarCierre()

        'Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Hasta.DateTime = f.AddDays(-1).Date

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
        Dim DT As DataTable = VB.SysContab.ArticulosDB.AntiguedadInventario(
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
        iPivotGrid.Fields("Proveedor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Cantidad").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Total").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea

        'iPivotGrid.Fields("30 Dias").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("60 Dias").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("90 Dias").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("120 Dias").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("150 Dias").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("180 Dias").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("360 Dias").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("Mas 360").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("Total").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea

        iPivotGrid.Fields("Costo Promedio").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        iPivotGrid.Fields("Precio 1").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        iPivotGrid.Fields("Precio 2").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        iPivotGrid.Fields("Precio U$ 1").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        iPivotGrid.Fields("Precio U$ 2").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        
        iPivotGrid.Fields("Bodega").Width = 150
        iPivotGrid.Fields("Proveedor").Width = 300

        iPivotGrid.OptionsSelection.MultiSelect = True
        iPivotGrid.OptionsView.ShowRowTotals = True
        iPivotGrid.OptionsView.ShowRowGrandTotals = True
    End Sub

    Private Sub bGrafico_Click(sender As Object, e As EventArgs) Handles bGrafico.Click
        With frmGraficosDinamicos

            .iGrafico.DataSource = iPivotGrid
            .iGrafico.SeriesDataMember = "Series"
            .iGrafico.SeriesTemplate.ArgumentDataMember = "Arguments"
            .iGrafico.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Values"})
            .iGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
            .etTitulo.Text = "Gráfico Dinámico de Antiguedad del Inventario"

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
        frmExportarImprimir.Mostrar(iPivotGrid, "Dinámico de Antiguedad del Inventario")
    End Sub

    Private Sub iPivotGrid_CellDoubleClick(sender As Object, e As PivotCellEventArgs) Handles iPivotGrid.CellDoubleClick
        FrmDetalleCrossTabDinamicos.Dispose()

        With FrmDetalleCrossTabDinamicos
            .Text = "Detalle Antiguedad Inventario"
            .StartPosition = FormStartPosition.CenterParent
            .GridControl1.DataSource = e.CreateDrillDownDataSource()
            .GridView1.PopulateColumns()
            FormatoGrid(.GridView1)
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub iPivotGrid_CustomAppearance(sender As Object, e As DevExpress.XtraPivotGrid.PivotCustomAppearanceEventArgs) Handles iPivotGrid.CustomAppearance
        'If e.DataField.FieldName = "Variación" And e.ColumnValueType = PivotGridValueType.Value _
        '  And e.RowValueType = PivotGridValueType.Value Then
        '    If Not e.Value Is Nothing And Convert.ToDecimal(e.Value) < 0 Then
        '        e.Appearance.BackColor = Color.Yellow
        '        ' e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
        '        e.Appearance.ForeColor = Color.Red
        '    End If
        'End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash("Generando Reporte...")
        'Dim DT As DataTable = ObtieneDatos("JAR_AntiguedadInventario", Hasta.DateTime.Date, cbBodegas.EditValue, EmpresaActual)
        Dim DT As DataTable =
            VB.SysContab.ArticulosDB _
            .AntiguedadInventario(
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