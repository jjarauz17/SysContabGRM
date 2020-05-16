﻿Imports System.IO
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors.Repository
Public Class frmReporteAntiguedadClientesProximasVencer

    Dim Clientes As VB.SysContab.ClientesDB
    Public SucID As String = "XX", Moneda As String = "01"

    Private Sub frmDinamicoCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        'Desde.DateTime = New DateTime(f.Year, f.Month, 1)
        'Hasta.DateTime = f.Date
        '       
        CargarCombos()
        LlenarGrid()
        FormatoPivot(iPivotGrid)
    End Sub

    Public Sub CargarCombos()

        GetMonedasList(cbMoneda)
        cbMoneda.EditValue = Moneda

        Combo(cbSucursal, ObtieneDatos("JAR_GetSucursalesxUsuario", EmpresaActual))
        cbSucursal.CheckAll()

        'LookUp(cbSucursal, ObtieneDatos("JAR_GetSucursalesxUsuario", EmpresaActual), "Nombre", "Sucursal", "[Seleccione Surusal]", 0)
        'cbSucursal.ItemIndex = 0

        'Combo(cbSucursal, ObtieneDatos("sp_GetSucursalesClientes", EmpresaActual))
        'cbSucursal.EditValue = SucID
        'cbSucursal.ItemIndex = 0
    End Sub

    Private Sub LlenarGrid()
        Dim DT As DataTable = VB.SysContab.ClientesDB.DinamicoClientesAntiguedadProxima(Hasta.DateTime.Date, _
                                                                                        Moneda, _
                                                                                        SucID, _
                                                                                        IIf(chkRetencion.Checked, 1, 0))

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
        iPivotGrid.Fields("Rubro").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Cliente").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Corte").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea

        'iPivotGrid.Fields("Original").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        ' iPivotGrid.Fields("Total").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        ' iPivotGrid.Fields("Año").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea

        iPivotGrid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        iPivotGrid.Fields("Rubro").Width = 270
        iPivotGrid.Fields("Cliente").Width = 250

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
            .etTitulo.Text = "Gráfico Dinámico de Vencimiento de Facturas"

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
        frmExportarImprimir.Mostrar(iPivotGrid, "Dinámico de Facturas Próximas a Vencer")
    End Sub

    Private Sub iPivotGrid_CellDoubleClick(sender As Object, e As PivotCellEventArgs) Handles iPivotGrid.CellDoubleClick
        FrmDetalleCrossTabDinamicos.Dispose()

        With FrmDetalleCrossTabDinamicos
            .Text = "Detalle Facturas de Clientes"
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
        Buscar()
    End Sub

    Sub Buscar()
        ShowSplash("Generando Reporte...")

        Dim DT As DataTable =
            VB.SysContab _
            .ClientesDB _
            .DinamicoClientesAntiguedadProxima(
            Hasta.DateTime.Date,
            cbMoneda.EditValue,
            IIf(cbSucursal.EditValue Is Nothing, "XX", cbSucursal.EditValue),
            IIf(chkRetencion.Checked, 1, 0))

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
        iPivotGrid.OptionsView.ShowRowTotals = CheckEdit1.Checked
    End Sub

    Private Sub cbMoneda_EditValueChanged(sender As Object, e As EventArgs) Handles cbMoneda.EditValueChanged
        If etInicio.Text = "0" Then Exit Sub
        Try
            Buscar()
            'ShowSplash("Generando Reporte...")
            'Dim DT As DataTable = VB.SysContab.ClientesDB.DinamicoClientesAntiguedadProxima(Hasta.DateTime.Date, _
            '                                                                            cbMoneda.EditValue, _
            '                                                                            IIf(cbSucursal.EditValue Is Nothing, "XX", cbSucursal.EditValue), _
            '                                                                            IIf(chkRetencion.Checked, 1, 0))
            'iPivotGrid.DataSource = DT
            'HideSplash()
        Catch ex As Exception
        End Try
    End Sub
End Class