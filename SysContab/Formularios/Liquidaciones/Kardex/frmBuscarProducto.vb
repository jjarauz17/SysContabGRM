Public Class frmBuscarProducto

    Public Desde As Date, Hasta As Date

    Private Sub frmBuscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combos()
    End Sub

    Sub Combos()
        GetBodegasList(cbBodega)
        cbBodega.CheckAll()
        '
        SearchLookUp(cbProductos, ObtieneDatos("JAR_GetArticulosBuscar", EmpresaActual), "NOMBRE", "CODIGO")
        cbProductos.Properties.PopupFormMinSize = New Point(1000, 0)
        cbProductos.Properties.View.Columns("CODIGO").Width = 80
        cbProductos.Properties.View.Columns("NOMBRE").Width = 150
        '
        Dim DT As DataTable = ObtieneDatos("SP_GeneralSaldosInventarioxBodega",
                                          UltimoCierreInventario().Date,
                                          VB.SysContab.Rutinas.Fecha().Date,
                                          3,
                                          "P",
                                          cbBodega.EditValue,
                                          0,
                                          "XXXXXXXXX.",
                                          EmpresaActual)

        iGrid.DataSource = DT
        iVista.PopulateColumns()
        FormatoGrid(iVista, 4)
        '
        Dim rUrl As New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        rUrl.Caption = "Url"

        Dim rVer As New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        rVer.Caption = "Ver"

        iVista.Columns("CODIGO_BODEGA").Visible = False
        iVista.Columns("PROVEEDOR").Visible = False
        iVista.Columns("VENTAS CONT").Visible = False
        iVista.Columns("VENTAS CR").Visible = False
        iVista.Columns("CREDITOS").Visible = False
        iVista.Columns("DEBITOS").Visible = False
        iVista.Columns("AJUSTES").Visible = False
        iVista.Columns("COSTO PROMEDIO").Visible = False
        iVista.Columns("COSTO TOTAL").Visible = False
        iVista.Columns("COSTO TOTAL U$").Visible = False
        iVista.Columns("UNITARIO U$").Visible = False
        iVista.Columns("URL").Visible = False

        iVista.Columns(" ").ColumnEdit = rUrl
        iVista.Columns(" ").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        iVista.Columns("  ").ColumnEdit = rVer
        iVista.Columns("  ").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If cbProductos.EditValue Is Nothing Then
            XtraMsg("Seleccione el Producto")
            cbProductos.Focus()
            Exit Sub
        End If


        'Dim UltimoCierre As Date = UltimoCierreInventario().Date   'ObtieneDatos("JAR_GetUltimoCierreInventario", EmpresaActual).Rows.Item(0)("Fecha_Cierre")
        'Dim Fecha_Actual As Date = VB.SysContab.Rutinas.Fecha().Date
        'Desde = UltimoCierre    '.Date.AddDays(1).Date
        'Hasta = Fecha_Actual

        ShowSplash("Calculando Saldos...")

        Dim DT As DataTable = ObtieneDatos("SP_GeneralSaldosInventarioxBodega",
                                           UltimoCierreInventario().Date,
                                           VB.SysContab.Rutinas.Fecha().Date,
                                           3,
                                           "P",
                                           cbBodega.EditValue,
                                           0,
                                           cbProductos.EditValue,
                                           EmpresaActual)

        iGrid.DataSource = DT

        HideSplash()
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
        Desde = CDate(iVista.GetRowCellValue(iVista.FocusedRowHandle, "SALDO INI AL")).AddDays(1).Date
        Hasta = VB.SysContab.Rutinas.Fecha().Date

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
        If cbProductos.EditValue Is Nothing Then
            XtraMsg("Seleccione un Producto")
            Exit Sub
        End If
        '
        ShowSplash()
        frmKardexProducto.Dispose()
        frmKardexProducto.Text = "KARDEX DEL PRODUCTO: " & cbProductos.EditValue + " - " + cbProductos.Text
        frmKardexProducto.Producto = cbProductos.EditValue
        frmKardexProducto.Bodega = cbBodega.EditValue
        frmKardexProducto.Show()
        HideSplash()
    End Sub

    Private Sub iVista_Click(sender As Object, e As EventArgs) Handles iVista.Click
        If iVista.FocusedRowHandle < 0 Then Exit Sub
        '
        If iVista.FocusedColumn.FieldName = " " Then
            If iVista.GetRowCellValue(iVista.FocusedRowHandle, "URL").ToString().Length > 0 Then
                Try
                    Process.Start(iVista.GetRowCellValue(iVista.FocusedRowHandle, "URL"))
                Catch ex As Exception
                    XtraMsg("URL inválida: " + ex.Message, MessageBoxIcon.Error)
                End Try
            End If

        End If

        If iVista.FocusedColumn.FieldName = "  " Then
            With frmProductoDetalle
                .Text = "Producto: " + iVista.GetFocusedRowCellValue("ITEM") + "  " + iVista.GetFocusedRowCellValue("DESCRIPCION")
                .Codigo = iVista.GetFocusedRowCellValue("ITEM")
                .Tipo = "P"
                .ShowDialog()
                .Dispose()
            End With
        End If
    End Sub

    Private Sub frmBuscarProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
End Class