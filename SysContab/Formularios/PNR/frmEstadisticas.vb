Public Class frmEstadisticas 

    Private Sub frmEstadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Desde.DateTime = New DateTime(f.Year, f.Month, 1)
        Hasta.DateTime = UltimoDiaDelMes(f.Date).Date

        LlenarGrid()
        FormatoPivot(iPivotGrid)
    End Sub

    Private Sub LlenarGrid()
        Dim DT As DataTable = db_PNR_Reportes.Estadisticas(Desde.DateTime.Date, Hasta.DateTime.Date)

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
        iPivotGrid.Fields("Usuario").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Nombre").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea

        iPivotGrid.Fields("Año").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        iPivotGrid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea

        iPivotGrid.Fields("Nuevo").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Actualizar").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Borrar").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea

        iPivotGrid.Fields("Nombre").Width = 200

        iPivotGrid.OptionsSelection.MultiSelect = True
        iPivotGrid.OptionsView.ShowRowTotals = False
        iPivotGrid.OptionsView.ShowRowGrandTotals = True
    End Sub

    Sub Buscar()
        ShowSplash()
        Dim DT As DataTable = db_PNR_Reportes.Estadisticas(Desde.DateTime.Date, Hasta.DateTime.Date)
        iPivotGrid.DataSource = DT
        HideSplash()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Buscar()
    End Sub

    Private Sub bActualizar_Click(sender As Object, e As EventArgs) Handles bActualizar.Click
        ShowSplash()
        LlenarGrid()
        FormatoPivot(iPivotGrid)
        HideSplash()
    End Sub

    Private Sub bGrafico_Click(sender As Object, e As EventArgs) Handles bGrafico.Click
        With frmGraficosDinamicos

            .iGrafico.DataSource = iPivotGrid
            .iGrafico.SeriesDataMember = "Series"
            .iGrafico.SeriesTemplate.ArgumentDataMember = "Arguments"
            .iGrafico.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Values"})
            .iGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
            .etTitulo.Text = "Uso de Herramienta PNR"

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

            If System.IO.File.Exists(NombreArchivo) Then
                iPivotGrid.RestoreLayoutFromXml(NombreArchivo)
                iPivotGrid.Refresh()
            End If
        End If
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iPivotGrid, "Dinámico de Rebajas a Productos")
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub
End Class