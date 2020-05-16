Imports System.IO

Public Class frmDinamicoContable

    Public IdPlanNegocio As Integer = 0
    Dim Ban As Integer = 0
    Dim Tasa As New VB.SysContab.Tasa_CambioDB

    Private Sub frmPlanNegocioPivot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Desde.DateTime = New DateTime(f.Year, f.Month, 1)
        Hasta.DateTime = f.Date

        GetTipoComprobantesList(cbTipo, 1)
        GetMonedasList(cbMoneda)

        ' Combo(cbMoneda, Tasa.GetListTasaCambioDisponibles.Tables("Tasa_Cambio"))
        'GetMonedas(cbMoneda)
        ' cbMoneda.EditValue = MonedaBase

        cbTipo.ItemIndex = 0
        '
        'Cargar Pivot Inicial
        LlenarGrid(Desde.DateTime.AddMonths(2).Date, Hasta.DateTime.Date)
        FormatoPivot(iPivotGrid)
        Ban = 1
    End Sub

    Private Sub LlenarGrid(Inicio As Date, Fin As Date)
        Dim DT As DataTable = ObtieneDatos("JAR_DinamicoContable",
                                           Inicio.Date,
                                           Fin.Date,
                                           cbTipo.EditValue,
                                           cbMoneda.EditValue,
                                           EmpresaActual)

        iPivotGrid.DataSource = DT

        'iPivotGrid.ExportToXls("", DevExpress.XtraPrinting.TextExportMode.Value)
        'iPivotGrid.ExportToXls("", DevExpress.XtraPrinting.TextExportMode.Value)

        If Ban = 0 Then 'Solo Arma el Grid la Primer vez
            iPivotGrid.Fields.Clear()
            '
            For i As Integer = 0 To DT.Columns.Count - 1
                Dim Campo As New DevExpress.XtraPivotGrid.PivotGridField
                iPivotGrid.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Campo})
                Campo.FieldName = DT.Columns(i).Caption.ToString
                Campo.Name = "Field" & DT.Columns(i).Caption.ToString
            Next
            '
            iPivotGrid.Fields("Tipo").Width = 200
            iPivotGrid.Fields("Beneficiario").Width = 250
            iPivotGrid.Fields("Cuenta Nombre").Width = 200

            iPivotGrid.Fields("Tipo").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            iPivotGrid.Fields("#Comprobante").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            iPivotGrid.Fields("Cuenta").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            iPivotGrid.Fields("Cuenta Nombre").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea

            iPivotGrid.Fields("Debito").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            iPivotGrid.Fields("Credito").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea


            iPivotGrid.Fields("Año").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            iPivotGrid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            '
            iPivotGrid.OptionsSelection.MultiSelect = True

        End If
    End Sub

    Private Sub bGrafico_Click(sender As Object, e As EventArgs) Handles bGrafico.Click
        With frmGraficosDinamicos

            .iGrafico.DataSource = iPivotGrid
            .iGrafico.SeriesDataMember = "Series"
            .iGrafico.SeriesTemplate.ArgumentDataMember = "Arguments"
            .iGrafico.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Values"})
            .iGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
            .etTitulo.Text = "Gráfico Dinámico Contable"

            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iPivotGrid)
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

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        Me.iPivotGrid.OptionsView.ShowRowTotals = Not Me.CheckEdit1.Checked
    End Sub

    Private Sub CheckEdit2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit2.CheckedChanged
        Me.iPivotGrid.OptionsView.ShowRowGrandTotals = Not Me.CheckEdit2.Checked
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash("Generando Reporte...")
        LlenarGrid(Desde.DateTime.Date, Hasta.DateTime.Date)
        HideSplash()
    End Sub

    Private Sub iPivotGrid_CellDoubleClick(sender As Object, e As DevExpress.XtraPivotGrid.PivotCellEventArgs) Handles iPivotGrid.CellDoubleClick
        FrmDetalleCrossTabDinamicos.Dispose()

        With FrmDetalleCrossTabDinamicos
            .Text = "Detalle Movimientos Contables"
            .StartPosition = FormStartPosition.CenterParent
            .GridControl1.DataSource = e.CreateDrillDownDataSource()
            .GridView1.PopulateColumns()
            FormatoGrid(.GridView1)
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        ShowSplash("Actualizando Reporte...")
        Ban = 0
        LlenarGrid(Desde.DateTime.Date, Hasta.DateTime.Date)
        FormatoPivot(iPivotGrid)
        Ban = 1
        HideSplash()
    End Sub
End Class