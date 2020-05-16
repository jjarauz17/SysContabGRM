Public Class FrmRequisasCrossTab

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdGrafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrafico.Click

        Dim f As New frmGraficosDinamicos

        f.iGrafico.DataSource = PivotGrid
        f.iGrafico.SeriesDataMember = "Series"
        f.iGrafico.SeriesTemplate.ArgumentDataMember = "Arguments"
        f.iGrafico.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Values"})
        f.iGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
        f.etTitulo.Text = "Gráfico Dinámico de Inventario"
        f.MdiParent = Me.MdiParent

        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexportar.Click
        'Dim forma As New frmexportaciongrid
        'forma.Mostrar(PivotGrid)
        frmExportarImprimir.Mostrar(PivotGrid, "Dinamico de Movimientos")
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        ShowSplash()
        PivotGrid.DataSource = ObtieneDatos("sp_requisacrosstab",
                                            sel1.Value.Date,
                                            sel3.Value.Date,
                                            EmpresaActual,
                                            cbMoneda.EditValue)
        HideSplash()
    End Sub

    Private Sub FrmRequisasCrossTab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        sel1.Value = New DateTime(f.Year, f.Month, 1).Date
        sel3.Value = f.Date

        GetMonedasList(cbMoneda)
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        Me.PivotGrid.OptionsView.ShowRowTotals = Not Me.CheckEdit1.Checked
    End Sub

    Private Sub CheckEdit2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit2.CheckedChanged
        Me.PivotGrid.OptionsView.ShowRowGrandTotals = Not Me.CheckEdit2.Checked
    End Sub

    Private Sub PivotGrid_CellDoubleClick(sender As Object, e As DevExpress.XtraPivotGrid.PivotCellEventArgs) Handles PivotGrid.CellDoubleClick
        FrmDetalleCrossTabDinamicos.Dispose()

        With FrmDetalleCrossTabDinamicos
            .Text = "Detalle de Movimientos de Inventario"
            .StartPosition = FormStartPosition.CenterParent
            .GridControl1.DataSource = e.CreateDrillDownDataSource()
            .GridView1.PopulateColumns()
            FormatoGrid(.GridView1)

            .GridView1.Columns("Cantidad").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .GridView1.Columns("Cantidad").DisplayFormat.FormatString = "{0:n4}"
            .GridView1.Columns("Cantidad").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .GridView1.Columns("Cantidad").SummaryItem.DisplayFormat = "{0:n4}"
            '
            .GridView1.Columns("Costo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .GridView1.Columns("Costo").DisplayFormat.FormatString = "{0:n6}"
            .GridView1.Columns("Costo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .GridView1.Columns("Costo").SummaryItem.DisplayFormat = "{0:n6}"
            '
            .GridView1.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .GridView1.Columns("Total").DisplayFormat.FormatString = "{0:n6}"
            .GridView1.Columns("Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .GridView1.Columns("Total").SummaryItem.DisplayFormat = "{0:n6}"

            .Show()
            .WindowState = FormWindowState.Maximized
        End With

        'With frmDetallesCrosstab
        '    .Text = "Detalle de Movimientos de Inventario"
        '    .dgDatos.DataSource = e.CreateDrillDownDataSource
        '    FormatoGrid(.vDatos)

        '    .vDatos.Columns("Cantidad").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '    .vDatos.Columns("Cantidad").DisplayFormat.FormatString = "{0:n4}"
        '    .vDatos.Columns("Cantidad").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '    .vDatos.Columns("Cantidad").SummaryItem.DisplayFormat = "{0:n4}"
        '    '
        '    .vDatos.Columns("Costo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '    .vDatos.Columns("Costo").DisplayFormat.FormatString = "{0:n6}"
        '    .vDatos.Columns("Costo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '    .vDatos.Columns("Costo").SummaryItem.DisplayFormat = "{0:n6}"
        '    '
        '    .vDatos.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '    .vDatos.Columns("Total").DisplayFormat.FormatString = "{0:n6}"
        '    .vDatos.Columns("Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '    .vDatos.Columns("Total").SummaryItem.DisplayFormat = "{0:n6}"


        '    .ShowDialog()
        '    .Dispose()
        'End With
    End Sub
End Class