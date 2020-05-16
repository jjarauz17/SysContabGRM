Public Class frmBuscarProductoxEmpresas

    Public Desde As Date, Hasta As Date

    Private Sub frmBuscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combos()
        '        
        LlenarGrid()
        FormatoPivot(iPivotGrid)
    End Sub

    Sub Combos()

        Combo(cbGrupo, ObtieneDatos("JAR_GetGruposEmpresas"), "Seleccione Grupo Empresarial")
        cbGrupo.ItemIndex = 0
        '
        Dim DT_PROD As DataTable = ObtieneDatos("JAR_GetArticulosBuscarxEmpresas", cbGrupo.EditValue)

        'SearchLookUp(cbProductos, DT_PROD, "NOMBRE", "CODIGO", 2, 4)
        'cbProductos.Properties.PopupFormMinSize = New Point(1000, 0)
        'cbProductos.Properties.View.Columns("CODIGO").Width = 80
        'cbProductos.Properties.View.Columns("NOMBRE").Width = 150

        SearchLookUp(cbCodigoParte, DT_PROD, "DESC. PROVEEDOR", "NO. PARTE", 1, 3)
        cbCodigoParte.Properties.PopupFormMinSize = New Point(1000, 0)
        cbCodigoParte.Properties.View.Columns("NO. PARTE").Width = 80
        cbCodigoParte.Properties.View.Columns("DESC. PROVEEDOR").Width = 150
    End Sub

    Private Sub LlenarGrid()
        Dim DT As DataTable = ObtieneDatos("SP_GeneralSaldosInventarioxEmpresa", cbGrupo.EditValue,
                                                                                 "XXXX")

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
        iPivotGrid.Fields("No. Parte").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Descripcion Proveedor").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Descripcion Proveedor").Width = 250
        iPivotGrid.Fields("Existencia").Width = 150

        iPivotGrid.Fields("Existencia").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Empresa").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea

        iPivotGrid.OptionsSelection.MultiSelect = True
        iPivotGrid.OptionsView.ShowRowTotals = False
        iPivotGrid.OptionsView.ShowRowGrandTotals = True
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If cbCodigoParte.EditValue Is Nothing Then
            XtraMsg("Seleccione el Producto")
            cbCodigoParte.Focus()
            Exit Sub
        End If

        'Dim Fecha_Cierre As Date = ObtieneDatos("JAR_GetUltimoCierreInventario", EmpresaActual).Rows.Item(0)("Fecha_Cierre")
        'Dim Fecha_Actual As Date = VB.SysContab.Rutinas.Fecha().Date

        'Desde = Fecha_Cierre.Date.AddDays(1).Date
        'Hasta = Fecha_Actual

        ShowSplash("Calculando Saldos...")

        Dim DT As DataTable = ObtieneDatos("SP_GeneralSaldosInventarioxEmpresa", cbGrupo.EditValue,
                                                                                 cbCodigoParte.EditValue)

        iPivotGrid.DataSource = DT

        'iGrid.DataSource = DT
        'iVista.PopulateColumns()
        'FormatoGrid(iVista, 4)

        HideSplash()

        'iVista.Columns("CODIGO_BODEGA").Visible = False
        'iVista.Columns("PROVEEDOR").Visible = False
        'iVista.Columns("VENTAS CONT").Visible = False
        'iVista.Columns("VENTAS CR").Visible = False
        'iVista.Columns("CREDITOS").Visible = False
        'iVista.Columns("DEBITOS").Visible = False
        'iVista.Columns("AJUSTES").Visible = False

        'iVista.Columns("COSTO PROMEDIO").Visible = False
        'iVista.Columns("COSTO TOTAL").Visible = False
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then iVista.ShowCustomization()
        If Not CheckEdit1.Checked Then iVista.DestroyCustomization()
    End Sub

    Private Sub iVista_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick
        If iVista.FocusedRowHandle < 0 Then
            Exit Sub
        End If
        '       
        With frmOpcionesInventarioDetalle
            .frm = "CONSULTA"
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub iVista_HideCustomizationForm(sender As Object, e As EventArgs) Handles iVista.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If cbCodigoParte.EditValue Is Nothing Then
            XtraMsg("Seleccione un Producto")
            Exit Sub
        End If
        '
        frmKardexProducto.Dispose()
        frmKardexProducto.Text = "KARDEX DEL PRODUCTO: " & cbCodigoParte.Text
        frmKardexProducto.Producto = cbCodigoParte.EditValue
        frmKardexProducto.Bodega = cbGrupo.EditValue
        frmKardexProducto.Show()
    End Sub
End Class