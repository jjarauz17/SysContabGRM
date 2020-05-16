Imports System.IO
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors.Repository
Public Class frmDinamicoDevoluciones

    Dim Clientes As VB.SysContab.ClientesDB

    Private Sub frmDinamicoCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Desde.DateTime = New DateTime(f.Year, f.Month, 1)
        Hasta.DateTime = f.Date
        '
        GetMonedasList(cbMoneda)
        '
        LlenarGrid()
        FormatoPivot(iPivotGrid)
    End Sub

    Private Sub LlenarGrid()
        Dim DT As DataTable =
            VB.SysContab.ClientesDB _
            .DinamicoDevoluciones(
            Desde.DateTime.Date.AddMonths(2).Date,
            Hasta.DateTime.Date,
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
        iPivotGrid.Fields("Centro Costo").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Código").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Descripción").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea

        iPivotGrid.Fields("Cantidad").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Precio").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Descuento").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("SubTotal").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("IVA").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Total").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea


        iPivotGrid.Fields("Año").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        iPivotGrid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea

        iPivotGrid.Fields("Centro Costo").Width = 200
        iPivotGrid.Fields("Descripción").Width = 200
        iPivotGrid.Fields("Cliente").Width = 200

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
            .etTitulo.Text = "Gráfico Dinámico de Devoluciones"

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
        frmExportarImprimir.Mostrar(iPivotGrid, "Dinámico de Devoluciones")
    End Sub

    Private Sub iPivotGrid_CustomAppearance(sender As Object, e As DevExpress.XtraPivotGrid.PivotCustomAppearanceEventArgs) Handles iPivotGrid.CustomAppearance
        If e.DataField.FieldName = "Variación" And
            e.ColumnValueType = PivotGridValueType.Value And
            e.RowValueType = PivotGridValueType.Value Then

            If Not e.Value Is Nothing And Convert.ToDecimal(e.Value) < 0 Then
                e.Appearance.BackColor = Color.Yellow
                ' e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
                e.Appearance.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash("Generando Reporte...")
        Dim DT As DataTable =
            VB.SysContab.ClientesDB _
            .DinamicoDevoluciones(
            Desde.DateTime.Date,
            Hasta.DateTime.Date,
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

    Private Sub cbMoneda_EditValueChanged(sender As Object, e As EventArgs) Handles cbMoneda.EditValueChanged
        If etInicio.Text = "0" Then Exit Sub
        Try
            ShowSplash("Generando Reporte...")
            Dim DT As DataTable =
                VB.SysContab.ClientesDB.DinamicoDevoluciones(Desde.DateTime.Date, Hasta.DateTime.Date, cbMoneda.EditValue)
            iPivotGrid.DataSource = DT
            HideSplash()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        Me.iPivotGrid.OptionsView.ShowRowTotals = Me.CheckEdit2.Checked

        If CheckEdit2.Checked Then
            CheckEdit2.Text = "Ocultar Sub Totales"
        Else
            CheckEdit2.Text = "Mostrar Sub Totales"
        End If

    End Sub

    Private Sub iPivotGrid_CellDoubleClick(sender As Object, e As PivotCellEventArgs) Handles iPivotGrid.CellDoubleClick

    End Sub
End Class