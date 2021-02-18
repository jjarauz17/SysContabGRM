Imports DevExpress.XtraPivotGrid

Public Class frmPresupuestoVer

    Dim IdPresupuesto As Integer = 0

    Private Sub frmPresupuestoVer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then Cargar()
    End Sub

    Sub Mostrar(ID As Integer, Sucursal As String, CentroCosto As String, Periodo As String, Cultivo As String)

        IdPresupuesto = ID

        txtPeriodo.Text = Periodo
        txtCultivo.Text = Cultivo
        txtNumero.Text = db_Presupuesto.Detalles(IdPresupuesto).Codigo

        If Not EmpresaActual.Equals("1") Then
            lySucursal.Text = "Centro de Costo:"
            txtSucursal.Text = CentroCosto
            lyCultivo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Else
            lySucursal.Text = "Sucursal:"
            txtSucursal.Text = Sucursal
        End If

    End Sub
    Private Sub frmPresupuestoVer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarGrid()
        FormatoPivot(iPivotGrid)
        '
        iPivotGrid.OptionsSelection.MultiSelect = True
        iPivotGrid.OptionsView.ShowRowTotals = True
        iPivotGrid.OptionsView.ShowRowGrandTotals = True
    End Sub

    Sub LlenarGrid()
        Dim DT As DataTable = db_Presupuesto.ReporteDinamico(IdPresupuesto)
        '
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
        iPivotGrid.Fields("Descripción").Width = 200

        iPivotGrid.Fields("Codigo").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Descripción").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea

        If EmpresaActual.Equals("1") Then
            iPivotGrid.Fields("Clase").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            'iPivotGrid.Fields("Presentacion").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Else
            iPivotGrid.Fields("Linea").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        End If
        '
        iPivotGrid.Fields("Año").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        iPivotGrid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea

        'iPivotGrid.Fields("Precio U$").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Cantidad").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Real").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Variación").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
    End Sub

    Private Sub bGrafico_Click(sender As Object, e As EventArgs) Handles bGrafico.Click
        With frmGraficosDinamicos

            .iGrafico.DataSource = iPivotGrid
            .iGrafico.SeriesDataMember = "Series"
            .iGrafico.SeriesTemplate.ArgumentDataMember = "Arguments"
            .iGrafico.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Values"})
            .iGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
            .etTitulo.Text = "Gráfico Dinámico de Presupuesto"

            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub bActualizar_Click(sender As Object, e As EventArgs) Handles bActualizar.Click
        Cargar()
    End Sub

    Sub Cargar()
        ShowSplash("Actualizando Datos...")
        Dim DT As DataTable = db_Presupuesto.ReporteDinamico(IdPresupuesto)
        iPivotGrid.DataSource = DT
        HideSplash()
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

            If System.IO.File.Exists(NombreArchivo) Then
                iPivotGrid.RestoreLayoutFromXml(NombreArchivo)
                iPivotGrid.Refresh()
            End If
        End If
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iPivotGrid, "Presupuesto")
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub iPivotGrid_CustomAppearance(sender As Object, e As PivotCustomAppearanceEventArgs) Handles iPivotGrid.CustomAppearance
        If e.DataField.ToString() = "Variación" Then
            e.Appearance.Font = New Font("Thaoma", 8, FontStyle.Bold)
            If (e.GetFieldValue(e.DataField) < 0.00) Then
                e.Appearance.ForeColor = Color.DarkRed
            ElseIf ((e.GetFieldValue(e.DataField) > 0.00) And e.GetFieldValue(iPivotGrid.Fields.Item("Cantidad"))) > 0 Then
                e.Appearance.ForeColor = Color.DarkGreen
            Else
                e.Appearance.ForeColor = Color.Navy
            End If
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        iPivotGrid.OptionsView.ShowRowTotals = Not CheckEdit1.Checked
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        iPivotGrid.OptionsView.ShowRowGrandTotals = Not CheckEdit2.Checked
    End Sub
End Class