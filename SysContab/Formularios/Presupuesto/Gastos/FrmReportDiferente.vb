Imports ClasesBLL
Imports DevExpress.XtraEditors.Repository

Public Class FrmReportDiferente

    Public Sub cargargridreport(codpresu As Integer, opc As Integer)
        ' Me.Dispose()
        Dim DT As New DataTable
        'DT = fn.ObtieneDatos("sp_sel_PresupuestoGastoDetalle", 0, 5)
        If opc = 1 Then

            DT = fn.ObtieneDatos("sp_sel_PresupuestoGastoDetalle", codpresu, 4)

        End If

        If opc = 2 Then

            DT = fn.ObtieneDatos("sp_sel_PresupuestoGastoDetalle", 0, 5)

        End If

        PivotGridControl1.DataSource = DT
        PivotGridControl1.OptionsSelection.MultiSelect = True


        For i As Integer = 0 To DT.Columns.Count - 1
            Dim Campo As New DevExpress.XtraPivotGrid.PivotGridField
            PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Campo})
            Campo.FieldName = DT.Columns(i).Caption.ToString
            Campo.Caption = DT.Columns(i).Caption.ToString
            Campo.Name = "Field" & DT.Columns(i).Caption.ToString
        Next
        '
        'PivotGridControl1.Fields("Periodo").Visible = False
        'PivotGridControl1.Fields("Enero").Visible = False
        '
        PivotGridControl1.Fields("Centro de Costo").Width = 180
        'PivotGridControl1.Fields("Mayor").Width = 200

        PivotGridControl1.Fields("Centro de Costo").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        PivotGridControl1.Fields("# Cuenta Contable").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        PivotGridControl1.Fields("Cuenta Contable").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea

        '
        PivotGridControl1.Fields("Periodo").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        PivotGridControl1.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea

        PivotGridControl1.Fields("Proyectado").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        PivotGridControl1.Fields("Real").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        PivotGridControl1.Fields("Diferencia").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea

        'PivotGridControl1.Fields("Enero").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'PivotGridControl1.Fields("Febrero").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'PivotGridControl1.Fields("Marzo").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'PivotGridControl1.Fields("Abril").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'PivotGridControl1.Fields("Mayo").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'PivotGridControl1.Fields("Junio").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'PivotGridControl1.Fields("Julio").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'PivotGridControl1.Fields("Agosto").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'PivotGridControl1.Fields("Septiembre").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'PivotGridControl1.Fields("Octubre").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'PivotGridControl1.Fields("Noviembre").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        'PivotGridControl1.Fields("Diciembre").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea

        '
        PivotGridControl1.OptionsSelection.MultiSelect = True
        PivotGridControl1.OptionsView.ShowRowTotals = True
        PivotGridControl1.OptionsView.ShowRowGrandTotals = True

        FormatoPivot(PivotGridControl1)
    End Sub


    Private Sub pivotGridControl1_CustomAppearance(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomAppearanceEventArgs) Handles PivotGridControl1.CustomAppearance

        'If (e.GetFieldValue(e.ColumnField).ToString = "01.Enero" Or e.GetFieldValue(e.ColumnField).ToString = "02.Febrero" Or e.GetFieldValue(e.ColumnField).ToString = "03.Marzo" Or e.GetFieldValue(e.ColumnField).ToString = "04.Abril" Or e.GetFieldValue(e.ColumnField).ToString = "05.Mayo" Or e.GetFieldValue(e.ColumnField).ToString = "06.Junio" Or e.GetFieldValue(e.ColumnField).ToString = "07.Julio" Or e.GetFieldValue(e.ColumnField).ToString = "08.Agosto" Or e.GetFieldValue(e.ColumnField).ToString = "09.Septiembre" Or e.GetFieldValue(e.ColumnField).ToString = "10.Octubre" Or e.GetFieldValue(e.ColumnField).ToString = "11.Noviembre" Or e.GetFieldValue(e.ColumnField).ToString = "12.Diciembre" Or e.GetFieldValue(e.ColumnField).ToString = "Total") Then
        'e.DataField.ToString = "Real" Or e.DataField.ToString = "Proyectado" Or 
        If e.DataField.ToString = "Diferencia" Then
            e.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            If (e.GetFieldValue(e.DataField) < 0) Then
                e.Appearance.ForeColor = Color.Red
                'e.Appearance.BackColor2 = System.Drawing.Color.Yellow
            End If
            If (e.GetFieldValue(e.DataField) > 0) Then
                e.Appearance.ForeColor = Color.Green
                'e.Appearance.BackColor = System.Drawing.Color.Green
                ' e.Appearance.BackColor2 = System.Drawing.Color.Azure
            End If
            'If (e.GetFieldValue(e.DataField) = 0) Then
            '    e.Appearance.ForeColor = Color.Yellow
            'End If
        Else

        End If


    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        My.Forms.frmExportarImprimir.Mostrar(
                PivotGridControl1,
                NombreEmpresaActual,
                "Reporte General de Presupuesto")
    End Sub

    Private Sub FrmReportDiferente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub
End Class