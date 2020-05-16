Imports ClasesBLL
Public Class frmCombos

    Public Codigo_Combo As String = ""
    Dim DT As DataTable = Nothing
    Private Temp As Boolean = False, Bodega_Principal As String = ""

    Dim obj As New Combos
    Dim db As New db_Combos

    Private Sub frmCombos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cargar()

        Bodega_Principal = VB.SysContab.ConfiguracionDB.GetConfigDetails().Bodega

        Dim DT_PROD As DataTable = ObtieneDatos("SP_ArticulosGetAll", "P", EmpresaActual)

        SearchLookUp(cbProducto, DT_PROD, "Display", "Codigo", 3, 4, 6, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26)
        RepositorySearchLook(ItemProductos, DT_PROD, "Display", "Codigo", 3, 4, 6, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26)

        If Codigo_Combo.Length > 0 Then
            cbProducto.Properties.ReadOnly = True
            cbProducto.EditValue = Codigo_Combo
        End If

        DT = db_Combos.Listar(Codigo_Combo)
        iGrid.DataSource = DT
        ArmarGrid()
    End Sub

    Sub ArmarGrid()
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False, True, False)

        iVista.Columns("IdDetalle").Visible = False
        iVista.Columns("Producto").ColumnEdit = ItemProductos
        iVista.Columns("Cantidad").ColumnEdit = txtCantidad
        '
        iVista.Columns("Costo").OptionsColumn.AllowEdit = False
        iVista.Columns("Total").OptionsColumn.AllowEdit = False
        '
        iVista.Columns("Costo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Costo").DisplayFormat.FormatString = "{0:n4}"
        iVista.Columns("Costo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("Costo").SummaryItem.DisplayFormat = "{0:n4}"
        '
        iVista.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Total").DisplayFormat.FormatString = "{0:n4}"
        iVista.Columns("Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("Total").SummaryItem.DisplayFormat = "{0:n4}"
        '
        iVista.BestFitColumns()
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        If iVista.DataRowCount = 0 Then
            XtraMsg("Debe agregar al menos 1 Producto!", MessageBoxIcon.Error)
            Exit Sub
        End If

        'Si es Cambo Nuevo
        If Codigo_Combo.Length = 0 Then
            Dim _DT_DTL As DataTable = DT.GetChanges(DataRowState.Added Or DataRowState.Modified)
            obj.Codigo_Combo = cbProducto.EditValue
            '
            If Not _DT_DTL Is Nothing Then
                For i As Integer = 0 To _DT_DTL.Rows.Count - 1
                    obj.Producto = _DT_DTL.Rows.Item(i)("Producto")
                    obj.Unidad = _DT_DTL.Rows.Item(i)("Unidad")
                    obj.Cantidad = _DT_DTL.Rows.Item(i)("Cantidad")
                    obj.Costo = _DT_DTL.Rows.Item(i)("Costo")

                    db.Insertar(obj)
                Next
            End If


            XtraMsg("El Combo " + cbProducto.Text + " se ha creado con exito!")
            Close()
            frmCombosList.Cargar()
        Else    'Si estamos editando el Combo.

            Dim _DT_UPD As DataTable = DT.GetChanges(DataRowState.Modified)
            obj.Codigo_Combo = cbProducto.EditValue
            '
            If Not _DT_UPD Is Nothing Then
                For i As Integer = 0 To _DT_UPD.Rows.Count - 1
                    obj.IdDetalle = _DT_UPD.Rows.Item(i)("IdDetalle")
                    obj.Producto = _DT_UPD.Rows.Item(i)("Producto")
                    obj.Unidad = _DT_UPD.Rows.Item(i)("Unidad")
                    obj.Cantidad = _DT_UPD.Rows.Item(i)("Cantidad")
                    obj.Costo = _DT_UPD.Rows.Item(i)("Costo")

                    db.Actualizar(obj)
                Next
            End If
            '
            'Agregar Nuevos Registros
            Dim _DT_NEW As DataTable = DT.GetChanges(DataRowState.Added)
            obj.Codigo_Combo = cbProducto.EditValue
            '
            If Not _DT_NEW Is Nothing Then
                For i As Integer = 0 To _DT_NEW.Rows.Count - 1
                    obj.Producto = _DT_NEW.Rows.Item(i)("Producto")
                    obj.Unidad = _DT_NEW.Rows.Item(i)("Unidad")
                    obj.Cantidad = _DT_NEW.Rows.Item(i)("Cantidad")
                    obj.Costo = _DT_NEW.Rows.Item(i)("Costo")

                    db.Insertar(obj)
                Next
            End If
            '
            'Borrar Linea
            Dim _DT_DEL As DataTable = DT.GetChanges(DataRowState.Deleted)
            If Not _DT_DEL Is Nothing Then
                For i As Integer = 0 To _DT_DEL.Rows.Count - 1
                    obj.IdDetalle = _DT_DEL.Rows.Item(i)("IdDetalle", DataRowVersion.Original)

                    db.BorrarDetalle(obj)
                Next
            End If
            '            
            XtraMsg("Los Cambios Solicitados han sido actualizados con exito!")
            '
            Close()
            frmCombosList.Cargar()
        End If
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub vDatos_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVista.CellValueChanged
        Try
            If e.Column.FieldName = "Producto" Then  'Or e.Column.FieldName = "Cantidad" Then
                Dim DR As DataRowView = ItemProductos.GetRowByKeyValue(e.Value)

                If Not DR Is Nothing Then
                    Temp = True
                    iVista.SetRowCellValue(e.RowHandle, "Cantidad", 1.0)
                    iVista.SetRowCellValue(e.RowHandle, "Unidad", DR.Item("Unidad"))

                    Dim Promedio As Double = ObtieneDatos("JAR_GetCostoProducto",
                                                                                e.Value,
                                                                                "P",
                                                                                Bodega_Principal,
                                                                                EmpresaActual).Rows.Item(0)("Promedio")

                    iVista.SetRowCellValue(e.RowHandle, "Costo", Promedio)
                    iVista.SetRowCellValue(e.RowHandle, "Total", Promedio)
                    Temp = False
                End If
            End If

            If e.Column.FieldName = "Cantidad" And Not Temp Then
                iVista.SetRowCellValue(e.RowHandle, "Total", e.Value * IsNull(iVista.GetRowCellValue(e.RowHandle, "Costo"), 1.0))
            End If

            iVista.UpdateTotalSummary()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub vDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles iVista.KeyDown
        If iVista.FocusedRowHandle < 0 Then
            Exit Sub
        End If

        If e.KeyCode = Keys.Delete Then
            iVista.DeleteSelectedRows()
            iVista.RefreshData()
        End If
    End Sub
End Class