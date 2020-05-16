Imports System.IO

Public Class frmDinamicoProduccion

    Public IdPlanNegocio As Integer = 0
    Dim Ban As Integer = 0
    Dim Tasa As New VB.SysContab.Tasa_CambioDB

    Private Sub frmPlanNegocioPivot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Desde.DateTime = New DateTime(f.Year, f.Month, 1)
        Hasta.DateTime = f.Date

        Combo(cbEstado, db_Prod_EstadoProduccion.Listar(-1))
        cbEstado.ItemIndex = 0
        '
        'Cargar Pivot Inicial
        LlenarGrid(Desde.DateTime.AddMonths(2).Date, Hasta.DateTime.Date)
        FormatoPivot(iPivotGrid)
        Ban = 1
    End Sub

    Private Sub LlenarGrid(Inicio As Date, Fin As Date)
        Dim DT As DataTable = ObtieneDatos("sp_Produccion_Dinamico", Inicio.Date, Fin.Date, cbEstado.EditValue, EmpresaActual)
        iPivotGrid.DataSource = DT

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
            iPivotGrid.Fields("Formula").Width = 200
            iPivotGrid.Fields("Producto").Width = 250

            iPivotGrid.Fields("Formula").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            iPivotGrid.Fields("Codigo").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            iPivotGrid.Fields("Producto").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea

            iPivotGrid.Fields("Cantidad").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            iPivotGrid.Fields("Costo").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            iPivotGrid.Fields("Total").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea


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
            .etTitulo.Text = "Gráfico Dinámico de Producción"

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
        If dGuardar.ShowDialog = DialogResult.OK Then
            iPivotGrid.SaveLayoutToXml(dGuardar.FileName)
        End If
    End Sub

    Private Sub bRestaurarEsquema_Click(sender As Object, e As EventArgs) Handles bRestaurarEsquema.Click
        If dAbrir.ShowDialog = DialogResult.OK Then
            CargarEsquemaDefault(dAbrir.FileName)
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
        Buscar()
    End Sub

    Sub Buscar()
        ShowSplash("Generando Reporte...")
        Dim DT As DataTable = ObtieneDatos("sp_Produccion_Dinamico", Desde.DateTime.Date, Hasta.DateTime.Date, cbEstado.EditValue, EmpresaActual)
        iPivotGrid.DataSource = DT
        'LlenarGrid(Desde.DateTime.Date, Hasta.DateTime.Date)
        'FormatoPivot(iPivotGrid)
        HideSplash()
    End Sub

    Private Sub iPivotGrid_CellDoubleClick(sender As Object, e As DevExpress.XtraPivotGrid.PivotCellEventArgs) Handles iPivotGrid.CellDoubleClick
        FrmDetalleCrossTabDinamicos.Dispose()

        With FrmDetalleCrossTabDinamicos
            .Text = "Detalle Producción"
            .StartPosition = FormStartPosition.CenterParent
            .GridControl1.DataSource = e.CreateDrillDownDataSource()
            .GridView1.PopulateColumns()
            FormatoGrid(.GridView1)
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If Not XtraMsg2("Se actualizarán los costos de la materia prima segun el ultimo Costo Promedio de cada producto." & vbCrLf & "Esta Seguro de Actualizarlos?") Then
            Exit Sub
        End If

        If Guardar("sp_Actualizar_Costos", Desde.DateTime.Date, Hasta.DateTime.Date, cbEstado.EditValue, EmpresaActual) Then
            Buscar()
        End If
    End Sub
End Class