Imports System.IO
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors.Repository

Public Class frmPlanNegocioPivotConsolidado

    Public IdPlanNegocio As Integer = 0

    Private Sub frmPlanNegocioPivotConsolidado_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ShowSplash("Actualizando Datos...")
            Cargar()
            HideSplash()
        End If
    End Sub

    Private Sub frmPlanNegocioPivot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.DoEvents()
        Combo(cbPeriodo, db_PNR_PlanNegocio.GetPeriodos())
        cbPeriodo.EditValue = VB.SysContab.Rutinas.Fecha().Year

        LlenarGrid()
        FormatoPivot(iPivotGrid)

        iPivotGrid.OptionsSelection.MultiSelect = True
        iPivotGrid.OptionsView.ShowRowTotals = True
        iPivotGrid.OptionsView.ShowRowGrandTotals = True
    End Sub

    Private Sub LlenarGrid()
        Dim DT As DataTable = db_PNR_Reportes.Reporte_PivotConsolidado(cbPeriodo.EditValue)

        iPivotGrid.DataSource = DT
        iPivotGrid.Fields.Clear()
        '
        For i As Integer = 0 To DT.Columns.Count - 1
            Dim Campo As New PivotGridField
            iPivotGrid.Fields.AddRange(New PivotGridField() {Campo})
            Campo.FieldName = DT.Columns(i).Caption.ToString
            Campo.Name = "Field" & DT.Columns(i).Caption.ToString
        Next
        '       
        iPivotGrid.Fields("Cliente").Width = 250

        iPivotGrid.Fields("Periodo").Area = PivotArea.ColumnArea

        iPivotGrid.Fields("Sucursal").Area = PivotArea.RowArea
        iPivotGrid.Fields("Cultivo").Area = PivotArea.RowArea
        iPivotGrid.Fields("Cliente").Area = PivotArea.RowArea

        iPivotGrid.Fields("Venta_Anterior").Area = PivotArea.DataArea
        iPivotGrid.Fields("Ventas").Area = PivotArea.DataArea
        iPivotGrid.Fields("Preyección").Area = PivotArea.DataArea
        iPivotGrid.Fields("Proyección Q1").Area = PivotArea.DataArea
        iPivotGrid.Fields("Real Q1").Area = PivotArea.DataArea
        iPivotGrid.Fields("Proyección Q2").Area = PivotArea.DataArea
        iPivotGrid.Fields("Real Q2").Area = PivotArea.DataArea
        iPivotGrid.Fields("Proyección Q3").Area = PivotArea.DataArea
        iPivotGrid.Fields("Real Q3").Area = PivotArea.DataArea
        iPivotGrid.Fields("Proyección Q4").Area = PivotArea.DataArea
        iPivotGrid.Fields("Real Q4").Area = PivotArea.DataArea
        iPivotGrid.Fields("Porcentaje").Area = PivotArea.DataArea

        Dim riProgressBar As RepositoryItemProgressBar = New RepositoryItemProgressBar()
        riProgressBar.PercentView = True

        iPivotGrid.Fields("Porcentaje").FieldEdit = riProgressBar
        iPivotGrid.Fields("Porcentaje").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        iPivotGrid.Fields("Participacion").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        iPivotGrid.Fields("Cumplimiento").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average

        iPivotGrid.Fields("Participacion").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iPivotGrid.Fields("Participacion").CellFormat.FormatString = "{0:P}"

        iPivotGrid.Fields("Cumplimiento").ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iPivotGrid.Fields("Cumplimiento").ValueFormat.FormatString = "{0:P}"

        iPivotGrid.Fields("Potencial_Anterior").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        iPivotGrid.Fields("Potencial").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        iPivotGrid.Fields("MZ").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        iPivotGrid.Fields("MZ_Anterior").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average

        If DT.Rows.Count > 0 Then

            iPivotGrid.Fields("Potencial_Anterior").Caption = "Potencial " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            iPivotGrid.Fields("Potencial").Caption = "Potencial " & (DT.Rows.Item(0)("Periodo")).ToString
            iPivotGrid.Fields("MZ_Anterior").Caption = "MZ " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            iPivotGrid.Fields("MZ").Caption = "MZ " & (DT.Rows.Item(0)("Periodo")).ToString
            iPivotGrid.Fields("Preyección").Caption = "Preyección " & DT.Rows.Item(0)("Periodo").ToString
            iPivotGrid.Fields("Venta_Anterior").Caption = "Venta " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            iPivotGrid.Fields("Ventas").Caption = "Venta " & DT.Rows.Item(0)("Periodo").ToString


            'iPivotGrid.Fields("Mz_Anterior").Caption = "MZ " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            'iPivotGrid.Fields("Total_Mz").Caption = "MZ " & DT.Rows.Item(0)("Periodo").ToString
            'iPivotGrid.Fields("PBS_Anterior").Caption = "PBR " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            'iPivotGrid.Fields("PBS").Caption = "PBR " & DT.Rows.Item(0)("Periodo").ToString
            'iPivotGrid.Fields("Ventas_Anterior").Caption = "Venta " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            'iPivotGrid.Fields("Ventas").Caption = "Venta " & DT.Rows.Item(0)("Periodo").ToString
            'iPivotGrid.Fields("Preyección").Caption = "Preyección " & DT.Rows.Item(0)("Periodo").ToString
            'iPivotGrid.Fields("Participacion_Anterior").Caption = "Participacion % " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            'iPivotGrid.Fields("Participacion_Anterior").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
            'iPivotGrid.Fields("Participacion_Anterior").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            'iPivotGrid.Fields("Participacion_Anterior").CellFormat.FormatString = "{0:P}"
            'iPivotGrid.Fields("Participacion").Caption = "Participacion % " & DT.Rows.Item(0)("Periodo").ToString
            'iPivotGrid.Fields("Participacion").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        End If

        'iPivotGrid.Fields("Cumplimiento").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'iPivotGrid.Fields("Cumplimiento").CellFormat.FormatString = "{0:P}"
        'iPivotGrid.Fields("Cumplimiento").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average

        ' iPivotGrid.Fields("Mz_Anterior").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        ' iPivotGrid.Fields("Total_Mz").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea

        'iPivotGrid.Fields("PBS_Anterior").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("PBS").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("Ventas_Anterior").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("Ventas").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("Preyección").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("Participacion_Anterior").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("Participacion").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("Cumplimiento").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'iPivotGrid.Fields("Porcentaje").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea

        'iPivotGrid.Fields("Cantidad_Aterior").AllowedAreas = PivotGridAllowedAreas.RowArea
        'iPivotGrid.Fields("Cantidad").AllowedAreas = PivotGridAllowedAreas.RowArea
        'iPivotGrid.Fields("Variación").AllowedAreas = PivotGridAllowedAreas.RowArea

        'Dim riProgressBar As RepositoryItemProgressBar = New RepositoryItemProgressBar()
        '' riProgressBar.ShowTitle = True
        'riProgressBar.PercentView = True
        'riProgressBar.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'riProgressBar.EditFormat.FormatString = "{0:n4}"
        ''  iPivotGrid.Fields("Porcentaje").FieldEdit = riProgressBar

        'iPivotGrid.Fields("Participacion").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'iPivotGrid.Fields("Participacion").CellFormat.FormatString = "{0:P}"

        'iPivotGrid.Fields("Participacion").ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'iPivotGrid.Fields("Participacion").ValueFormat.FormatString = "{0:P}"

        'iPivotGrid.Fields("Porcentaje").FieldEdit = riProgressBar
        'iPivotGrid.Fields("Porcentaje").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average

        'iPivotGrid.Fields("Porcentaje").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'iPivotGrid.Fields("Porcentaje").CellFormat.FormatString = "{0:n4}"
        ' riProgressBar.ShowTitle = True

        'iPivotGrid.RepositoryItems.Add(riProgressBar)

        'fieldPercents.FieldEdit = riProgressBar
        '
        ' iPivotGrid.OptionsSelection.MultiSelect = True
        'iPivotGrid.OptionsView.ShowRowTotals = False

        ' iPivotGrid.Fields("Mz_Anterior").Visible = False
        ' iPivotGrid.Fields("Total_Mz").Visible = False

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

        If XtraMsg2("El Proceso de Actualización de Venta en los PNR puede demorar algunos minutos " & vbCrLf _
                        & "ya que actualiza todas las ventas del periodo actual y anterior de cada uno de los productos contenidos en cada PNR." & vbCrLf _
                        & "Desea Actulizarlo ?") Then

            ShowSplash("Actualizando Ventas...")

            If db_PNR_Reportes.Actualizar_Ventas_PNR(cbPeriodo.EditValue, EmpresaActual) Then
                LlenarGrid()
                FormatoPivot(iPivotGrid)
            End If

            HideSplash()
        End If


    End Sub

    Private Sub iPivotGrid_CustomAppearance(sender As Object, e As DevExpress.XtraPivotGrid.PivotCustomAppearanceEventArgs) Handles iPivotGrid.CustomAppearance

        'Try
        '    ' If e.DataField Is Variacion And e.ColumnValueType = PivotGridValueType.Value _
        '    If e.DataField.FieldName = "Variación" And e.ColumnValueType = PivotGridValueType.Value _
        '    And e.RowValueType = PivotGridValueType.Value Then
        '        If Not e.Value Is Nothing And Convert.ToDecimal(e.Value) < 0 Then
        '            e.Appearance.BackColor = Color.Yellow
        '            ' e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
        '            e.Appearance.ForeColor = Color.Red
        '        End If
        '    End If
        'Catch ex As Exception

        'End Try


        'Try
        '    If e.RowField.FieldName = "Variación" Then
        '        Dim Valor As String = e.RowField.GetValueText(e.RowFieldIndex)
        '        '  XtraMsg(Valor)
        '        If CDbl(Valor) < 0 Then
        '            e.Appearance.BackColor = Color.Yellow
        '            ' e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
        '            e.Appearance.ForeColor = Color.Red
        '        End If

        '        'If Not e.Value Is Nothing And Convert.ToDecimal(e.Value) < 0 Then
        '        '    e.Appearance.BackColor = Color.Yellow
        '        '    ' e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
        '        '    e.Appearance.ForeColor = Color.Red
        '        'End If
        '    End If
        'Catch ex As Exception

        'End Try


    End Sub

    Private Sub cbPeriodo_EditValueChanged(sender As Object, e As EventArgs) Handles cbPeriodo.EditValueChanged
        If Inicio Then Exit Sub
        '
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub

    Sub Cargar()
        Dim DT As DataTable = db_PNR_Reportes.Reporte_PivotConsolidado(cbPeriodo.EditValue)
        iPivotGrid.DataSource = DT
        '
        If DT.Rows.Count > 0 Then

            iPivotGrid.Fields("Potencial_Anterior").Caption = "Potencial " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            iPivotGrid.Fields("Potencial").Caption = "Potencial " & (DT.Rows.Item(0)("Periodo")).ToString
            iPivotGrid.Fields("MZ_Anterior").Caption = "MZ " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            iPivotGrid.Fields("MZ").Caption = "MZ " & (DT.Rows.Item(0)("Periodo")).ToString
            iPivotGrid.Fields("Preyección").Caption = "Preyección " & DT.Rows.Item(0)("Periodo").ToString
            iPivotGrid.Fields("Venta_Anterior").Caption = "Venta " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            iPivotGrid.Fields("Ventas").Caption = "Venta " & DT.Rows.Item(0)("Periodo").ToString


            '    iPivotGrid.Fields("MZ_Anterior").Caption = "MZ " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            '    iPivotGrid.Fields("Total_Mz").Caption = "MZ " & DT.Rows.Item(0)("Periodo").ToString

            '    iPivotGrid.Fields("PBS_Anterior").Caption = "PBR " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            '    iPivotGrid.Fields("PBS").Caption = "PBR " & DT.Rows.Item(0)("Periodo").ToString

            '    iPivotGrid.Fields("Ventas_Anterior").Caption = "Venta " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            '    iPivotGrid.Fields("Ventas").Caption = "Venta " & DT.Rows.Item(0)("Periodo").ToString
            '    iPivotGrid.Fields("Preyección").Caption = "Preyección " & DT.Rows.Item(0)("Periodo").ToString

            '    iPivotGrid.Fields("Participacion_Anterior").Caption = "Participacion % " & (DT.Rows.Item(0)("Periodo") - 1).ToString
            '    iPivotGrid.Fields("Participacion_Anterior").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
            '    iPivotGrid.Fields("Participacion_Anterior").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            '    iPivotGrid.Fields("Participacion_Anterior").CellFormat.FormatString = "{0:P}"

            '    iPivotGrid.Fields("Participacion").Caption = "Participacion % " & DT.Rows.Item(0)("Periodo").ToString
            '    iPivotGrid.Fields("Participacion").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash("Actualizando Campos...")
        LlenarGrid()
        FormatoPivot(iPivotGrid)
        HideSplash()
    End Sub

    Private Sub CheckEdit1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        iPivotGrid.OptionsView.ShowRowTotals = Not CheckEdit1.Checked
    End Sub

    Private Sub CheckEdit2_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        iPivotGrid.OptionsView.ShowRowGrandTotals = Not CheckEdit2.Checked
    End Sub
End Class