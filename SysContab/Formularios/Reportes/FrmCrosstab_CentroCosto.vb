Imports System.IO
Public Class FrmCrosstab_CentroCosto

    Dim Columna As String
    Dim Fila As String
    Dim Dato As String
    Dim Titulo As String

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrafico.Click

        'Dim f As New frmGraficosDinamicos

        frmGraficosDinamicos.Dispose()

        With frmGraficosDinamicos
            .iGrafico.DataSource = Me.iPivotGrid
            .iGrafico.SeriesDataMember = "Series"
            .iGrafico.SeriesTemplate.ArgumentDataMember = "Arguments"
            .iGrafico.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Values"})
            .iGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
            .etTitulo.Text = "Gráfico Dinámico Por Centros de Costos"
            .MdiParent = Me.MdiParent
            .Show()
            .Text = sender.Text
            .WindowState = FormWindowState.Maximized
        End With


        'EsquemaGrafico()
        'Dim f As FrmGraficar

        'f.grafico.SeriesTemplate.ValueDataMembers.Clear()
        'f.grafico.DataSource = PivotGrid.CreateSummaryDataSource()
        'f.grafico.SeriesDataMember = Columna  ' COLUMN AREA
        'f.grafico.SeriesTemplate.ArgumentDataMember = Fila  'ROW AREA
        'f.grafico.SeriesTemplate.ValueDataMembers.AddRange(New String() {Dato})  'DATA AREA
        'f.grafico.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        'f.grafico.SeriesTemplate.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.FixedPoint
        'f.grafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
        'f.grafico.Titles(0).Text = Titulo


        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        frmExportarImprimir.Mostrar(iPivotGrid, Me.Text)
    End Sub

    Sub EsquemaGrafico()
        CargarDatos()
        CargarColumnas()
        CargarFilas()
    End Sub


    Sub CargarDatos()

        Dim TipoDato As String = "_Sum"

        For i As Integer = 0 To iPivotGrid.Fields.Count - 1
            If iPivotGrid.Fields(i).Area = DevExpress.XtraPivotGrid.PivotArea.DataArea Then
                Dato = iPivotGrid.Fields(i).FieldName & TipoDato
                Titulo = iPivotGrid.Fields(i).ToString
                Exit Sub
            End If
        Next


    End Sub

    Sub CargarFilas()

        For i As Integer = 0 To iPivotGrid.Fields.Count - 1
            If iPivotGrid.Fields(i).Area = DevExpress.XtraPivotGrid.PivotArea.RowArea Then
                Fila = iPivotGrid.Fields(i).FieldName
                Titulo = Titulo & " agrupado por " & iPivotGrid.Fields(i).ToString
                Exit Sub
            End If
        Next
    End Sub


    Sub CargarColumnas()

        For i As Integer = 0 To iPivotGrid.Fields.Count - 1
            If iPivotGrid.Fields(i).Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea Then
                Columna = iPivotGrid.Fields(i).FieldName
                Titulo = Titulo & " por " & iPivotGrid.Fields(i).ToString
                Exit Sub
            End If
        Next

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        'Dim Datos As New ArrayList
        'Dim Variables As New ArrayList

        'Variables.Add("Desde")
        'Variables.Add("Hasta")
        'Variables.Add("Empresa")

        'Datos.Add(Me.Desde.DateTime.Date)
        'Datos.Add(Me.Hasta.DateTime.Date)
        'Datos.Add(EmpresaActual)

        ShowSplash()
        'iPivotGrid.DataSource = ProcedureParameters(Datos, Variables, "_CentroCosto_Crosstab")
        Dim DT As DataTable = ObtieneDatos("_CentroCosto_Crosstab",
                                           Desde.DateTime.Date,
                                           Hasta.DateTime.Date,
                                           EmpresaActual)
        iPivotGrid.DataSource = DT
        HideSplash()
        'PivotGrid.DataSource = funciones.ObtieneDatos("_CentroCosto_Crosstab '" & Desde.EditValue & "', '" & Hasta.EditValue & "'," & EmpresaActual)
    End Sub

    Private Sub FrmCrosstab_CentroCosto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl1)
        ''
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Desde.EditValue = New DateTime(f.Year, f.Month, 1)
        Hasta.EditValue = f.Date

        Application.DoEvents()
        LlenarGrid()
        Application.DoEvents()
        FormatoPivot(iPivotGrid)

        ''iPivotGrid.Fields.Add("Nombre_Cuenta", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
        ''iPivotGrid.Fields.Add("Cuenta", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
        ''iPivotGrid.Fields.Add("Comprobante", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
        ''iPivotGrid.Fields.Add("Quarter", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
        ''iPivotGrid.Fields.Add("Fecha", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
        ''iPivotGrid.Fields.Add("Dia", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
        ''iPivotGrid.Fields.Add("SC01", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
        ''iPivotGrid.Fields.Add("SC02", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
        ''iPivotGrid.Fields.Add("Rubro_Gasto", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
        ''iPivotGrid.Fields.Add("Tipo", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
        ''iPivotGrid.Fields.Add("Documento", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
        ' ''PivotGrid.Fields.Add("Trans_Id", DevExpress.XtraPivotGrid.PivotArea.FilterArea)
        ' ''PivotGrid.Fields.Add("Concepto", DevExpress.XtraPivotGrid.PivotArea.FilterArea)

        ''iPivotGrid.Fields.Add("Centro_Costo", DevExpress.XtraPivotGrid.PivotArea.RowArea)
        ''iPivotGrid.Fields.Add("Mayor", DevExpress.XtraPivotGrid.PivotArea.RowArea)

        ''iPivotGrid.Fields.Add("Año", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
        ''iPivotGrid.Fields.Add("Mes", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)

        ''iPivotGrid.Fields.Add("Debito", DevExpress.XtraPivotGrid.PivotArea.DataArea)
        ''iPivotGrid.Fields("Debito").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        ''iPivotGrid.Fields("Debito").CellFormat.FormatString = "{0:N}"

        ''iPivotGrid.Fields.Add("Credito", DevExpress.XtraPivotGrid.PivotArea.DataArea)
        ''iPivotGrid.Fields("Credito").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        ''iPivotGrid.Fields("Credito").CellFormat.FormatString = "{0:N}"

        ''iPivotGrid.Fields.Add("Movimiento", DevExpress.XtraPivotGrid.PivotArea.DataArea)
        ''iPivotGrid.Fields("Movimiento").CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        ''iPivotGrid.Fields("Movimiento").CellFormat.FormatString = "{0:N}"

        ''iPivotGrid.Fields("Fecha").ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        ''iPivotGrid.Fields("Fecha").ValueFormat.FormatString = "{0:dd/MM/yyyy}"
    End Sub

    Private Sub LlenarGrid()

        Dim DT As DataTable = ObtieneDatos("_CentroCosto_Crosstab",
                                           Desde.DateTime.Date,
                                           Hasta.DateTime.Date,
                                           EmpresaActual)
        iPivotGrid.DataSource = DT
        iPivotGrid.Fields.Clear()
        '
        For i As Integer = 0 To DT.Columns.Count - 1
            Dim Campo As New DevExpress.XtraPivotGrid.PivotGridField
            iPivotGrid.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Campo})
            Campo.FieldName = DT.Columns(i).Caption.ToString
            Campo.Caption = DT.Columns(i).Caption.ToString
            Campo.Name = "Field" & DT.Columns(i).Caption.ToString
        Next
        '
        iPivotGrid.Fields("Per_Id").Visible = False
        iPivotGrid.Fields("MesId").Visible = False
        '
        iPivotGrid.Fields("Centro_Costo").Width = 180
        iPivotGrid.Fields("Mayor").Width = 200

        iPivotGrid.Fields("Centro_Costo").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Mayor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        '
        iPivotGrid.Fields("Año").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        iPivotGrid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea

        iPivotGrid.Fields("Debito").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Credito").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Movimiento").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        '
        iPivotGrid.OptionsSelection.MultiSelect = True
        iPivotGrid.OptionsView.ShowRowTotals = False
        iPivotGrid.OptionsView.ShowRowGrandTotals = True
    End Sub

    Private Sub pivotGridControl1_CellDoubleClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellEventArgs) Handles iPivotGrid.CellDoubleClick

        With FrmDetalleCrossTabDinamicos
            .Text = "Detalle de Reporte x Centro de Costo"
            .StartPosition = FormStartPosition.CenterParent
            .GridControl1.DataSource = e.CreateDrillDownDataSource()
            .GridView1.PopulateColumns()
            FormatoGrid(.GridView1)

            .GridView1.Columns("Movimiento").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            .GridView1.Columns("Movimiento").DisplayFormat.FormatString = "{0:n2}"
            .GridView1.Columns("Movimiento").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .GridView1.Columns("Movimiento").SummaryItem.DisplayFormat = "{0:n2}"
            '            
            .ShowDialog()
            .Dispose()
        End With

        'form.Grid.Parent = form
        'form.Grid.Dock = DockStyle.Fill
        ' form.FileName = "Fecha"
        'form.GridView2.Columns(0).FieldName = "Fecha"
        'form.Grid.DataSource = e.CreateDrillDownDataSource()

        'If ckComp.Checked Then

        ' form.Grid.Parent = form
        'form.Grid.Dock = DockStyle.Fill
        'form.FileName = "Fecha"
        'form.GridView2.Columns(0).FieldName = "Fecha"


        'Else
        '    Dim Dato As DevExpress.XtraPivotGrid.PivotDrillDownDataSource = e.CreateDrillDownDataSource

        '    Dim Variables As New ArrayList
        '    Dim Datos As New ArrayList

        '    Variables.Add("Rubro")
        '    Variables.Add("CC")
        '    Variables.Add("Ano")
        '    Variables.Add("Cuarto")
        '    Variables.Add("Mes")
        '    Variables.Add("Mayor")
        '    Variables.Add("N1")
        '    Variables.Add("N2")

        '    Variables.Add("F_ini")
        '    Variables.Add("F_fin")



        '    For Each Fila As DevExpress.XtraPivotGrid.PivotDrillDownDataRow In Dato
        '        Datos.Add(IIf(PivotGrid.Fields("Rubro").Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea, "", Fila(7)))
        '        Datos.Add(IIf(PivotGrid.Fields("CentroCosto").Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea, "", Fila(6)))
        '        Datos.Add(IIf(PivotGrid.Fields("Anno").Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea, 0, Fila(0)))
        '        Datos.Add(IIf(PivotGrid.Fields("Quarter").Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea, "", Fila(1)))
        '        Datos.Add(IIf(PivotGrid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea, 0, Fila(15)))
        '        Datos.Add(IIf(PivotGrid.Fields("Mayor").Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea, "", Fila(11)))
        '        Datos.Add(IIf(PivotGrid.Fields("SC01").Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea, "", Fila(12)))
        '        Datos.Add(IIf(PivotGrid.Fields("SC02").Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea, "", Fila(13)))



        '        form.Grid.DataSource = ProcedureParameters(Datos, Variables, "SPGetCrossComprobanteDetalle")
        '        Exit For
        '    Next



        'End If
    End Sub

    Private Sub PivotGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iPivotGrid.Click

    End Sub

    Private Sub btnDiseno_Click(sender As Object, e As EventArgs) Handles btnDiseno.Click

    End Sub

    Private Sub btnGuardarEsq_Click(sender As Object, e As EventArgs) Handles btnGuardarEsq.Click
        If Guardar.ShowDialog = DialogResult.OK Then
            iPivotGrid.SaveLayoutToXml(Guardar.FileName)
        End If
    End Sub

    Private Sub btnCargarEsq_Click(sender As Object, e As EventArgs) Handles btnCargarEsq.Click
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

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        Me.iPivotGrid.OptionsView.ShowRowGrandTotals = Not Me.CheckEdit2.Checked
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        Me.iPivotGrid.OptionsView.ShowRowTotals = Not Me.CheckEdit1.Checked
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Close()
    End Sub
End Class