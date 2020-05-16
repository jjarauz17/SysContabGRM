Imports System.IO
Imports DevExpress.XtraPivotGrid
Imports ClasesBLL
Public Class frmDinamicoRemisiones

    Dim Clientes As VB.SysContab.ClientesDB

    Private Sub frmDinamicoCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Desde.DateTime = New DateTime(f.Year, f.Month, 1)
        Hasta.DateTime = UltimoDiaDelMes(f.Date)
        '
        GetMonedasList(cbMoneda)
        '
        LlenarGrid()
        FormatoPivot(iPivotGrid)
    End Sub

    Private Sub LlenarGrid()
        Dim DT As DataTable = db_Remisiones.Reporte(Desde.DateTime.Date.AddMonths(2).Date, Hasta.DateTime.Date, cbMoneda.EditValue)

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
        If EmpresaActual <> 1 Then iPivotGrid.Fields("Bodega").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        If EmpresaActual = 1 Then iPivotGrid.Fields("Sucursal").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Cliente").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Codigo").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Descripción").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea

        iPivotGrid.Fields("Cantidad").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea

        iPivotGrid.Fields("Año").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        iPivotGrid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea

        If EmpresaActual <> 1 Then iPivotGrid.Fields("Bodega").Width = 160
        If EmpresaActual = 1 Then iPivotGrid.Fields("Sucursal").Width = 180
        iPivotGrid.Fields("Descripción").Width = 250

        iPivotGrid.OptionsSelection.MultiSelect = True
        iPivotGrid.OptionsView.ShowRowTotals = False
        iPivotGrid.OptionsView.ShowRowGrandTotals = True
    End Sub

    Private Sub bGrafico_Click(sender As Object, e As EventArgs) Handles bGrafico.Click
        With frmGraficosDinamicos

            .iGrafico.DataSource = iPivotGrid
            .iGrafico.SeriesDataMember = "Series"
            .iGrafico.SeriesTemplate.ArgumentDataMember = "Arguments"
            .iGrafico.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Values"})
            .iGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
            .etTitulo.Text = "Gráfico Dinámico de Remisiones"

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
        frmExportarImprimir.Mostrar(iPivotGrid, "Dinámico de Remisiones")
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash("Generando Reporte...")
        Dim DT As DataTable = db_Remisiones.Reporte(Desde.DateTime.Date, Hasta.DateTime.Date, cbMoneda.EditValue)
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

    Private Sub CheckEdit4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit4.CheckedChanged
        iPivotGrid.OptionsView.ShowRowTotals = Not CheckEdit4.Checked
        '
        If CheckEdit4.Checked Then
            CheckEdit4.Text = "Mostrar Sub Totales"
        Else
            CheckEdit4.Text = "Quitar Sub Totales"
        End If
    End Sub

    Private Sub CheckEdit3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit3.CheckedChanged
        iPivotGrid.OptionsView.ShowRowGrandTotals = Not CheckEdit3.Checked
        '
        If CheckEdit3.Checked Then
            CheckEdit3.Text = "Mostrar Gran Total"
        Else
            CheckEdit3.Text = "Quitar Gran Total"
        End If
    End Sub

End Class