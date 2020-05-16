Public Class frmGraficosDinamicos 

    Private Sub rgTipos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgTipos.SelectedIndexChanged
        Cargar()

        If Me.rgTipos.EditValue = "B" Then
            Me.iGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
        ElseIf Me.rgTipos.EditValue = "P" Then
            Me.iGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Pie)
        ElseIf Me.rgTipos.EditValue = "A" Then
            Me.iGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Area)
        ElseIf Me.rgTipos.EditValue = "L" Then
            Me.iGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Line)
        End If
    End Sub

    Sub Cargar()
        Me.iGrafico.SeriesDataMember = "Series"
        Me.iGrafico.SeriesTemplate.ArgumentDataMember = "Arguments"
        Me.iGrafico.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Values"})
    End Sub

    Private Sub frmGraficosDinamicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
        'Me.grafico.ExportToMht()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        iGrafico.ShowPrintPreview()

        'DevExpress.XtraCharts.Printing.PrintSizeMode.Stretch
        'DevExpress.XtraCharts.Printing.PrintSizeMode.Stretch()

        'Dim Extension As String = "*.mht"
        'Guardar.Filter = "(" & Extension & ")|" & Extension

        'If Me.Guardar.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    Me.grafico.ExportToMht(Me.Guardar.FileName)
        '    Process.Start(Me.Guardar.FileName)
        'End If
        ''My.Forms.frmExportarGrafico.ShowDialog()
    End Sub
End Class