Public Class frmProduccionEstadoFinalizar

    Dim obj As New Prod_Produccion
    Dim db As New db_Prod_Produccion

    Public IdProduccion As String = 0, Ok As String = "NO"
    Dim DT As DataTable
    Private Sub frmProduccionEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        dFecha.DateTime = Now.Date

        CargarCombos()

        'obj = db_Prod_Produccion.Detalles(IdProduccion)

        'If Not obj Is Nothing Then
        '    Numero.Text = obj.NumeroProduccion
        '    dFecha.DateTime = obj.FechaProduccion
        '    cbFormula.EditValue = obj.IdSysFormula
        '    TxtAProducir.EditValue = obj.CantidadProducir
        '    txtNoDocumento.Text = obj.NoDocumento
        '    cbBodega.EditValue = obj.Bodega
        'End If

        'Cargar Materia Prima
        DT = db_Prod_ProduccionDetalle.MateriaPrima(IdProduccion)
        iGrid2.DataSource = DT
        iVista2.PopulateColumns()
        FormatoGrid(iVista2, 6, 0, False, True, False)
        '
        'iVista2.Columns("IdDetalle").Visible = False
        'iVista2.Columns("IdFormula").Visible = False
        'iVista2.Columns("IdProduccion").Visible = False
        'iVista2.Columns("Tipo").Visible = False
        'iVista2.Columns("Presentacion").Visible = False
        'iVista2.Columns("Cantidad").Visible = False
        'iVista2.Columns("Tipo Producto").Visible = False
        'iVista2.Columns("Cantidad Base").Visible = False

        iVista2.Columns("Producto").ColumnEdit = cbItems
        ' iVista2.Columns("Tipo Producto").ColumnEdit = TipoProducto
        iVista2.Columns("Bodega").ColumnEdit = Bodega
        iVista2.Columns("Cantidad").ColumnEdit = txtCantidad
        'iVista2.Columns("Cantidad Base").ColumnEdit = txtCantidad
        'iVista2.Columns("Base Producir").ColumnEdit = txtCantidad
        'iVista2.Columns("A Producir").ColumnEdit = txtCantidad
        iVista2.Columns("Costo").ColumnEdit = txtCantidad
        iVista2.Columns("Total").ColumnEdit = txtCantidad

        iVista2.BestFitColumns()
        TotalMateriaPrima()


        'Cargar Producto Terminado
        DT = db_Prod_ProduccionDetalle.ProductoTerminado(IdProduccion)
        iGrid1.DataSource = DT
        iVista1.PopulateColumns()
        FormatoGrid(iVista1, 6, 0, False, True, False)

        iVista1.Columns("Producto").ColumnEdit = cbItemsTerminado
        iVista1.Columns("Bodega").ColumnEdit = cbBodegaTerminado
        iVista1.Columns("Cantidad").ColumnEdit = rCantidad
        iVista1.Columns("Costo").ColumnEdit = rCantidad
        iVista1.Columns("Total").ColumnEdit = rCantidad

        iVista1.BestFitColumns()
        TotalProdTerminado()
    End Sub
    '
    Sub CargarCombos()
        Dim DT_PROD As DataTable = ObtieneDatos("sp_GetProductos_Forumlas", EmpresaActual, 0)
        RepositorySearchLook(cbItems, DT_PROD, "Nombre", "Codigo", 2, 3)
        RepositorySearchLook(cbItemsTerminado, DT_PROD, "Nombre", "Codigo", 2, 3)

        'SearchLookUp(cbFormula, db_Prod_CatMaestroFormula.Listar(0), "Descripción", "IdSysFormula", 0, 6, 7)
        ' Combo(TipoProducto, db_Prod_TipoProductos.Listar(0))
        'GetBodegasxUsuario(cbBodega, 0)
        GetBodegasxUsuario(Bodega, 0)
        GetBodegasxUsuario(cbBodegaTerminado, 0)

        GetTipoMovimientos(cbND, 1)
        GetTipoMovimientos(cbNC, 1)

        cbND.ItemIndex = 0
        cbNC.ItemIndex = 0
    End Sub

    Sub TotalMateriaPrima()
        lblCostoProduccion.Text = "Total Costo de Producción = " & CDbl(iVista2.Columns("Total").SummaryItem.SummaryValue).ToString("n2")
    End Sub

    Sub TotalProdTerminado()
        lblCostoTerminado.Text = "Total Costo de Producción = " & CDbl(iVista1.Columns("Total").SummaryItem.SummaryValue).ToString("n2")
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate() Then Exit Sub

        If cbNC.ItemIndex = 0 Then
            XtraMsg("Seleccione la Nota de Crédito del Movimiento a Generar", MessageBoxIcon.Warning)
            cbNC.Focus()
            Exit Sub
        End If

        If cbND.ItemIndex = 0 Then
            XtraMsg("Seleccione la Nota de Débito del Movimiento a Generar", MessageBoxIcon.Warning)
            cbND.Focus()
            Exit Sub
        End If

        'Quitar todos filtros si hay culumnas con filtros aplicados
        For i As Integer = 0 To iVista1.Columns.Count - 1
            iVista1.Columns(i).ClearFilter()
        Next

        For i As Integer = 0 To iVista2.Columns.Count - 1
            iVista2.Columns(i).ClearFilter()
        Next

        Dim sProd As String = ""

        For i As Integer = 0 To iVista2.DataRowCount - 1
            If Math.Round(iVista2.GetRowCellValue(i, "Cantidad"), 6) > Math.Round(iVista2.GetRowCellValue(i, "Existencia"), 6) Then
                Dim DR As DataRowView = cbItems.GetRowByKeyValue(iVista2.GetRowCellValue(i, "Producto"))

                If sProd.Length > 0 Then sProd = sProd & vbCrLf & DR.Item("Nombre") & ", Existencia = " & CDbl(iVista2.GetRowCellValue(i, "Existencia")).ToString("n6")
                If sProd.Length = 0 Then sProd = DR.Item("Nombre") & ", Existencia = " & CDbl(iVista2.GetRowCellValue(i, "Existencia")).ToString("n6")
            End If
        Next

        If sProd.Length > 0 Then
            XtraMsg("Existen productos que no tiene Existencias suficiente: " & vbCrLf & sProd, MessageBoxIcon.Error)
        End If

        If sProd.Length > 0 Then
            If Not XtraMsg2("Exta Seguro de Procesar esta Producción de todas formas?") Then
                Exit Sub
            End If
        End If

        ShowSplash("Guardando...")

        obj.IdProduccion = IdProduccion
        obj.Empresa = EmpresaActual
        obj.FechaFinalizaProduccion = dFecha.DateTime.Date
        obj.ND = cbND.EditValue
        obj.NC = cbNC.EditValue
        obj.NoDocumento = txtReferencia.Text
        obj.Observaciones3 = txtObservaciones.Text

        db.FinalizarProduccion(obj)

        HideSplash()
        XtraMsg("Las Producción ha finalizado y se han generado los movimientos al inventario con exito!")

        Ok = "SI"
        Close()
        FrmProduccionFinalizar.Cargar()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Ok = "NO"
        Close()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        frmExportarImprimir.Mostrar(iGrid1, "Producto Terminado")
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        frmExportarImprimir.Mostrar(iGrid2, "Materia Prima")
    End Sub
End Class