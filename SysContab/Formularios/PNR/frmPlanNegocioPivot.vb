Imports System.IO
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors.Repository

Public Class frmPlanNegocioPivot

    Public IdPlanNegocio As Integer = 0

    Private Sub frmPlanNegocioPivot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarGrid()
        FormatoPivot(iPivotGrid)

        iPivotGrid.OptionsSelection.MultiSelect = True
        iPivotGrid.OptionsView.ShowRowTotals = True
        iPivotGrid.OptionsView.ShowRowGrandTotals = True
    End Sub

    Private Sub LlenarGrid()
        Dim DT As DataTable = db_PNR_Reportes.Reporte_Pivot(IdPlanNegocio)

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
        iPivotGrid.Fields("Producto").Width = 200
        iPivotGrid.Fields("Cliente").Width = 150
        
        iPivotGrid.Fields("Cantidad_Aterior").Caption = (DT.Rows.Item(0)("Periodo") - 1).ToString       '"Cantidad " + (DT.Rows.Item(0)("Periodo") - 1).ToString
        iPivotGrid.Fields("Cantidad").Caption = DT.Rows.Item(0)("Periodo").ToString  '"Cantidad " + DT.Rows.Item(0)("Periodo").ToString

        'iPivotGrid.Fields("CantidadQ1").Caption = "Cantidad"
        'iPivotGrid.Fields("CantidadQ2").Caption = "Cantidad"
        'iPivotGrid.Fields("CantidadQ3").Caption = "Cantidad"
        'iPivotGrid.Fields("CantidadQ4").Caption = "Cantidad"
        'iPivotGrid.Fields("Cantidad_Aterior").Width = 150
        'iPivotGrid.Fields("Cantidad").Width = 150

        iPivotGrid.Fields("Cliente").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Cultivo").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Producto").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Cantidad_Aterior").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Cantidad").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Variación").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea

        iPivotGrid.Fields("Cantidad KG/L").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Ventas YTD").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Porcentaje").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea

        'iPivotGrid.Fields("CantidadQ1").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        '' iPivotGrid.Fields("Q2").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("CantidadQ2").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        '' iPivotGrid.Fields("Q3").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("CantidadQ3").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        '' iPivotGrid.Fields("Q4").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("CantidadQ4").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea

        iPivotGrid.Fields("Periodo").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        iPivotGrid.Fields("Trimestre").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea

        iPivotGrid.Fields("Cantidad_Aterior").AllowedAreas = PivotGridAllowedAreas.RowArea        
        iPivotGrid.Fields("Cantidad").AllowedAreas = PivotGridAllowedAreas.RowArea        
        iPivotGrid.Fields("Variación").AllowedAreas = PivotGridAllowedAreas.RowArea

        Dim riProgressBar As RepositoryItemProgressBar = New RepositoryItemProgressBar()
        ' riProgressBar.ShowTitle = True
        riProgressBar.PercentView = True
        'riProgressBar.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'riProgressBar.EditFormat.FormatString = "{0:n4}"
        iPivotGrid.Fields("Porcentaje").FieldEdit = riProgressBar

        'iPivotGrid.Fields("Porcentaje").ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'iPivotGrid.Fields("Porcentaje").ValueFormat.FormatString = "{0:n4}"

        'iPivotGrid.Fields("Porcentaje").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'iPivotGrid.Fields("Porcentaje").CellFormat.FormatString = "{0:n4}"
        ' riProgressBar.ShowTitle = True
       
        'iPivotGrid.RepositoryItems.Add(riProgressBar)

        'fieldPercents.FieldEdit = riProgressBar
        '
        iPivotGrid.OptionsSelection.MultiSelect = True
        iPivotGrid.OptionsView.ShowRowTotals = False
        iPivotGrid.OptionsView.ShowRowGrandTotals = True
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs)
        '  iPivotGrid.OptionsView.ShowRowGrandTotals = Not Me.CheckEdit2.Checked
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs)
        '  iPivotGrid.OptionsView.ShowRowTotals = Not Me.CheckEdit1.Checked
    End Sub

    Private Sub bGrafico_Click(sender As Object, e As EventArgs) Handles bGrafico.Click    
        With frmGraficosDinamicos

            .iGrafico.DataSource = iPivotGrid
            .iGrafico.SeriesDataMember = "Series"
            .iGrafico.SeriesTemplate.ArgumentDataMember = "Arguments"
            .iGrafico.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Values"})
            .iGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
            .etTitulo.Text = "Gráfico Dinámico de Plan de Negocio"

            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iPivotGrid, "Plan de Negocio")
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
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

    Private Sub bActualizar_Click(sender As Object, e As EventArgs) Handles bActualizar.Click
        ShowSplash("Actualizando...")
        LlenarGrid()
        FormatoPivot(iPivotGrid)
        HideSplash()
    End Sub

    Private Sub iPivotGrid_CustomAppearance(sender As Object, e As DevExpress.XtraPivotGrid.PivotCustomAppearanceEventArgs) Handles iPivotGrid.CustomAppearance

        '    ' If e.DataField Is Variacion And e.ColumnValueType = PivotGridValueType.Value _
        '    If e.DataField.FieldName = "Variación" And e.ColumnValueType = PivotGridValueType.Value _
        '    And e.RowValueType = PivotGridValueType.Value Then
        '    If Not e.Value Is Nothing And Convert.ToDecimal(e.Value) < 0 Then
        '        e.Appearance.BackColor = Color.Yellow
        '        ' e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
        '        e.Appearance.ForeColor = Color.Red
        '    End If
        'End If

        'If e.RowField.FieldName = "Variación" Then
        '    Dim Valor As String = e.RowField.GetValueText(e.RowFieldIndex)
        '    '  XtraMsg(Valor)
        '    If CDbl(Valor) < 0 Then
        '        e.Appearance.BackColor = Color.Yellow
        '        ' e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
        '        e.Appearance.ForeColor = Color.Red
        '    End If

        '    'If Not e.Value Is Nothing And Convert.ToDecimal(e.Value) < 0 Then
        '    '    e.Appearance.BackColor = Color.Yellow
        '    '    ' e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
        '    '    e.Appearance.ForeColor = Color.Red
        '    'End If
        'End If
    End Sub
End Class