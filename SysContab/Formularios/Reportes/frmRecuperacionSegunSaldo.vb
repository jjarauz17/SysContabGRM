Imports System.IO
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors.Repository
Public Class frmRecuperacionSegunSaldo

    Dim Clientes As VB.SysContab.ClientesDB

    Private Sub frmDinamicoCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Desde.DateTime = New DateTime(f.Year, f.Month, 1)
        Hasta.DateTime = UltimoDiaDelMes(f).Date
        '       
        CargarCombos()
        LlenarGrid()
        FormatoPivot(iPivotGrid)
    End Sub

    Public Sub CargarCombos()
        GetMonedasList(cbMoneda)
        cbMoneda.ItemIndex = 0
        '
        Combo(cbSucursales, ObtieneDatos("sp_GetSucursalesxUsuario " & EmpresaActual & "," & Usuario_ID & ""))
        cbSucursales.CheckAll()
        '
        LookUp(cbRubro, ObtieneDatos("JAR_GetRubrosClientesxUsuario", EmpresaActual), "Display", "Cuenta", "[Seleccione Rubro]", 2)
        cbRubro.ItemIndex = 0
    End Sub

    Private Sub LlenarGrid()
        Dim DT As DataTable = VB.SysContab.ClientesDB.DinamicoRecuperacionxSaldo(Desde.DateTime.Date,
                                                                                Hasta.DateTime.Date,
                                                                                cbMoneda.EditValue,
                                                                                cbSucursales.EditValue,
                                                                                cbRubro.EditValue,
                                                                                True)

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
        If EmpresaActual = 1 Then iPivotGrid.Fields("Sucursal").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Cliente").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Factura").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea


        iPivotGrid.Fields("Al Corte").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Recuperación").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea

        If EmpresaActual = 1 Then iPivotGrid.Fields("Sucursal").Width = 200
        iPivotGrid.Fields("Cliente").Width = 300

        iPivotGrid.OptionsSelection.MultiSelect = True
        iPivotGrid.OptionsView.ShowRowTotals = False
        CheckEdit1.Checked = True
        'iPivotGrid.OptionsView.ShowRowGrandTotals = True
    End Sub

    Private Sub bGrafico_Click(sender As Object, e As EventArgs) Handles bGrafico.Click
        With frmGraficosDinamicos

            .iGrafico.DataSource = iPivotGrid
            .iGrafico.SeriesDataMember = "Series"
            .iGrafico.SeriesTemplate.ArgumentDataMember = "Arguments"
            .iGrafico.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Values"})
            .iGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
            .etTitulo.Text = "Gráfico Dinámico Recuperación por Saldo"

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
        frmExportarImprimir.Mostrar(iPivotGrid, "Dinámico de Recuperación por Saldo")
    End Sub

    Private Sub iPivotGrid_CellDoubleClick(sender As Object, e As PivotCellEventArgs) Handles iPivotGrid.CellDoubleClick
        FrmDetalleCrossTabDinamicos.Dispose()
        '
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
        ShowSplash("Generando Reporte...")
        Dim DT As DataTable = VB.SysContab.ClientesDB.DinamicoRecuperacionxSaldo(Desde.DateTime.Date,
                                                                                Hasta.DateTime.Date,
                                                                                cbMoneda.EditValue,
                                                                                cbSucursales.EditValue,
                                                                                cbRubro.EditValue)
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
        iPivotGrid.OptionsView.ShowRowTotals = Not CheckEdit1.Checked
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        iPivotGrid.OptionsView.ShowRowGrandTotals = Not CheckEdit2.Checked
    End Sub
End Class