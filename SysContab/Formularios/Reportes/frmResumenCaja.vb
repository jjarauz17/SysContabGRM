Imports System.IO
Imports DevExpress.XtraPivotGrid

Public Class frmResumenCaja

    Private Sub btnquit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnquit.Click
        Me.Close()
    End Sub

    Private Sub frmResumenCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Desde.DateTime = f.Date
        Hasta.DateTime = f.Date

        'Dim Datos As New ArrayList
        'Dim Variables As New ArrayList

        'Variables.Add("Empresa")
        'Variables.Add("Desde")
        'Variables.Add("Hasta")

        'Datos.Add(EmpresaActual)
        'Datos.Add(Me.Desde.DateTime.Date.AddDays(1).Date)
        'Datos.Add(Me.Hasta.DateTime.Date)

        'LlenarGrid(ProcedureParameters(Datos, Variables, "_GetResumenCaja"))
        'FormatoPivot(iPivotGrid)
    End Sub

    Private Sub LlenarGrid(DT As DataTable)
        iPivotGrid.DataSource = DT
        'iPivotGrid.Fields.Clear()
        ''
        'For i As Integer = 0 To DT.Columns.Count - 1
        '    Dim Campo As New DevExpress.XtraPivotGrid.PivotGridField
        '    iPivotGrid.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Campo})
        '    Campo.FieldName = DT.Columns(i).Caption.ToString
        '    Campo.Name = "Field" & DT.Columns(i).Caption.ToString
        'Next
        '
        For i As Integer = 0 To iPivotGrid.Fields.Count - 1
            iPivotGrid.Fields(i).Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        Next
        '
        If Not CheckEdit3.Checked Then
            iPivotGrid.Fields("cj_Nombre").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            iPivotGrid.Fields("Tipo Ingreso").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Else
            iPivotGrid.Fields("UBICACION").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        End If

        iPivotGrid.Fields("Efectivo").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Cheque").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea

        If Not CheckEdit3.Checked Then
            iPivotGrid.Fields("Tarjeta").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            'iPivotGrid.Fields("Cheque").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            iPivotGrid.Fields("Transporte").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            iPivotGrid.Fields("Monto NC").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            iPivotGrid.Fields("Mnto. Valor").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            iPivotGrid.Fields("Total Ingreso").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea

            Dim field As PivotGridField = iPivotGrid.Fields("Tipo Ingreso")
            ' Lock the control to prevent excessive updates when multiple properties are modified.
            iPivotGrid.BeginUpdate()
            Try
                ' Clear the filter value collection and add two items to it.
                field.FilterValues.Clear()
                ' Specify that the control should only display the records 
                ' which contain the specified values in the Country field.
                field.FilterValues.FilterType = PivotFilterType.Excluded
            Finally
                ' Unlock the control.
                iPivotGrid.EndUpdate()
            End Try
        Else
            iPivotGrid.Fields("Transporte").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            iPivotGrid.Fields("Monto NC").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            iPivotGrid.Fields("Mnto. Valor").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            iPivotGrid.Fields("Total Ingreso").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Try
                iPivotGrid.Fields("Monto U$").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Catch ex As Exception
            End Try

            Dim field As PivotGridField = iPivotGrid.Fields("Tipo Ingreso")
            ' Lock the control to prevent excessive updates when multiple properties are modified.
            iPivotGrid.BeginUpdate()
            Try
                ' Clear the filter value collection and add two items to it.
                field.FilterValues.Clear()
                field.FilterValues.Add("RECIBOS DE CAJA")
                field.FilterValues.Add("NOTAS DE CREDITO")
                field.FilterValues.Add("FACTURACION DE CONTADO")
                ' Specify that the control should only display the records 
                ' which contain the specified values in the Country field.
                field.FilterValues.FilterType = PivotFilterType.Included
            Finally
                ' Unlock the control.
                iPivotGrid.EndUpdate()
            End Try

        End If

        iPivotGrid.Fields("Anio").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        iPivotGrid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea

        'iPivotGrid.Fields("cj_Nombre").Caption = "Caja"
        'iPivotGrid.Fields("Anio").Caption = "Año"
        'iPivotGrid.Fields("UBICACION").Caption = "Bodega"
        'iPivotGrid.Fields("FACTURA").Caption = "Factura"
        'iPivotGrid.Fields("RECIBO").Caption = "Recibo"
        'iPivotGrid.Fields("FECHA").Caption = "Fecha"
        'iPivotGrid.Fields("MONTO").Caption = "Monto"
        'iPivotGrid.Fields("SUBTOTAL").Caption = "SubTotal"
        'iPivotGrid.Fields("DESCUENTO").Caption = "Descuento"
        'iPivotGrid.Fields("IVA").Caption = "Iva"
        'iPivotGrid.Fields("RECARGO").Caption = "Recargo"
        'iPivotGrid.Fields("TOTAL").Caption = "Total Factura"
        'iPivotGrid.Fields("SALDO").Caption = "Saldo"
        'iPivotGrid.Fields("Monto NC").Caption = "N / C"

        'iPivotGrid.Fields("UBICACION").Width = 150
        'iPivotGrid.Fields("cj_Nombre").Width = 150
        'iPivotGrid.Fields("Tipo Ingreso").Width = 150
        'iPivotGrid.Fields("Cliente").Width = 200

        'iPivotGrid.OptionsSelection.MultiSelect = True
        'iPivotGrid.OptionsView.ShowRowTotals = False
        'iPivotGrid.OptionsView.ShowRowGrandTotals = True
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ShowSplash()

        If Me.chkRango.Checked Then
            ResumenCajaxFacturas()
        Else
            ResumenCajaxFechas()
        End If

        HideSplash()
    End Sub

    Sub ResumenCajaxFechas()
        Dim Datos As New ArrayList
        Dim Variables As New ArrayList

        Variables.Add("Empresa")
        Variables.Add("Desde")
        Variables.Add("Hasta")

        Datos.Add(EmpresaActual)
        Datos.Add(Me.Desde.DateTime.Date)
        Datos.Add(Me.Hasta.DateTime.Date)

        Dim DT As DataTable = ProcedureParameters(Datos, Variables, "_GetResumenCaja")
        LlenarGrid(DT)

        'If dt.Rows.Count = 0 Then
        '    XtraMsg("La Consulta No ha devuelto Ningún valor para los Parametros de Busqueda Seleccionados")
        '    Exit Sub
        'End If
        'Me.iPivotGrid.DataSource = dt.DefaultView
    End Sub

    Sub ResumenCajaxFacturas()
        Dim Datos As New ArrayList
        Dim Variables As New ArrayList

        Variables.Add("Empresa")
        Variables.Add("Desde")
        Variables.Add("Hasta")
        Variables.Add("DesdeF")
        Variables.Add("HastaF")

        Datos.Add(EmpresaActual)
        Datos.Add(Me.Desde.DateTime.Date)
        Datos.Add(Me.Hasta.DateTime.Date)
        Datos.Add(Me.TextEdit1.EditValue)
        Datos.Add(Me.TextEdit2.EditValue)

        Dim DT As DataTable = ProcedureParameters(Datos, Variables, "_GetResumenCajaxFactura")
        LlenarGrid(DT)
        'If dt.Rows.Count = 0 Then
        '    MsgBox("La Consulta No ha devuelto Ningún valor para los Parametros de Busqueda Seleccionados", MsgBoxStyle.Information)
        '    Me.iPivotGrid.DataSource = Nothing
        '    Exit Sub
        'End If

        'Me.iPivotGrid.DataSource = dt.DefaultView
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.iPivotGrid)
    End Sub

    Private Sub CheckEdit2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.CheckEdit2.Checked Then
            Me.iPivotGrid.OptionsView.ShowRowTotals = False
        Else
            Me.iPivotGrid.OptionsView.ShowRowTotals = True
        End If
    End Sub

    Private Sub chkRango_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRango.CheckedChanged
        Me.TextEdit1.Enabled = Me.chkRango.Checked
        Me.TextEdit2.Enabled = Me.chkRango.Checked

        If Not Me.chkRango.Checked Then
            Me.TextEdit1.EditValue = 0
            Me.TextEdit2.EditValue = 0
        End If
    End Sub

    Private Sub CheckEdit2_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        Me.iPivotGrid.OptionsView.ShowRowGrandTotals = Not Me.CheckEdit2.Checked
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        Me.iPivotGrid.OptionsView.ShowRowTotals = Not Me.CheckEdit1.Checked
    End Sub

    Private Sub cmdGrafico_Click(sender As Object, e As EventArgs) Handles cmdGrafico.Click
        Dim f As New frmGraficosDinamicos

        f.iGrafico.DataSource = iPivotGrid
        f.iGrafico.SeriesDataMember = "Series"
        f.iGrafico.SeriesTemplate.ArgumentDataMember = "Arguments"
        f.iGrafico.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Values"})
        f.iGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
        f.etTitulo.Text = "Gráfico Dinámico de Facturación"
        f.MdiParent = Me.MdiParent

        f.Show()
        f.WindowState = FormWindowState.Maximized
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

    Private Sub iPivotGrid_CellDoubleClick(sender As Object, e As PivotCellEventArgs) Handles iPivotGrid.CellDoubleClick
        FrmDetalleCrossTabDinamicos.Dispose()

        With FrmDetalleCrossTabDinamicos
            .Text = "Detalle Resumen de Caja"
            .StartPosition = FormStartPosition.CenterParent
            .GridControl1.DataSource = e.CreateDrillDownDataSource()
            .GridView1.PopulateColumns()
            FormatoGrid(.GridView1)
            .GridView1.Columns("RECARGO").Visible = False
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

End Class