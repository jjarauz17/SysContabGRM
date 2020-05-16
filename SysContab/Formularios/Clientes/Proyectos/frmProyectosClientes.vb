Public Class frmProyectosClientes

    Public IdCliente As Integer = 0
    Public Ok As String = "NO"
    Public DT_COSTO As DataTable,
        DT_REQ As DataTable

    Private Sub frmProyectosClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Ok = "NO"
            Close()
        End If
    End Sub

    Private Sub frmResponsables_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'SearchLookUp(cbProyectos, db_Proyectos.FillxCliente(IdCliente), "Nombre", "IdProyecto", 0, 5, 6, 7)        
        'cbProyectos.Properties.DataSource = db_Proyectos.FillxClienteCheck(IdCliente)
        'cbProyectos.Properties.ValueMember = "IdProyecto"
        'cbProyectos.Properties.DisplayMember = "Nombre"

        ShowSplash("Cargando Proyectos...")

        Cargar()

        '  iVista1.PopulateColumns() : FormatoGrid(iVista1, 2, 0, False)
        iVista2.PopulateColumns() : FormatoGrid(iVista2, 2, 0, False, True, False)
        iVistaCostos.PopulateColumns() : FormatoGrid(iVistaCostos, 2, 0, False, True, False)
        iVistaProyectos.PopulateColumns() : FormatoGrid(iVistaProyectos, 2, 0, False)
        '
        'For i As Integer = 0 To iVista1.Columns.Count - 1
        '    iVista1.Columns(i).OptionsColumn.AllowEdit = False
        'Next
        '
        For i As Integer = 0 To iVistaCostos.Columns.Count - 1
            iVistaCostos.Columns(i).OptionsColumn.AllowEdit = False
        Next

        For i As Integer = 0 To iVista2.Columns.Count - 1
            iVista2.Columns(i).OptionsColumn.AllowEdit = False
        Next
        '
        For i As Integer = 0 To iVistaProyectos.Columns.Count - 1
            iVistaProyectos.Columns(i).OptionsColumn.AllowEdit = False
        Next
        ''
        'iVista1.Columns("IdDetalle").Visible = False
        'iVista1.Columns("IdProveedor").Visible = False
        'iVista1.Columns("Tipo").Visible = False
        'iVista1.Columns("ComprobanteID").Visible = False
        'iVista1.Columns("Per_Id").Visible = False
        'iVista1.Columns("Consecutivo").Visible = False
        'iVista1.Columns("Costo").OptionsColumn.AllowEdit = True
        'iVista1.Columns("Facturar").OptionsColumn.AllowEdit = True
        '
        iVista2.Columns("IdDetalle").Visible = False
        iVista2.Columns("CantidadO").Visible = False
        iVista2.Columns("IdProyecto").Visible = False
        iVista2.Columns("Exento").Visible = False
        iVista2.Columns("Unitario").ColumnEdit = rMonto
        iVista2.Columns("Costo Total").ColumnEdit = rMonto
        iVista2.Columns("Cantidad").OptionsColumn.AllowEdit = True
        iVista2.Columns("Facturar").OptionsColumn.AllowEdit = True
        iVista2.Columns("Visible").OptionsColumn.AllowEdit = True
        iVista2.Columns("Facturar").ColumnEdit = rChkRemision
        iVista2.Columns("Visible").ColumnEdit = rChkRemision
        iVista2.Columns("Agrupar").OptionsColumn.AllowEdit = True
        iVista2.Columns("Agrupar").Width = 120
        '
        iVistaProyectos.Columns("IdProyecto").Visible = False
        iVistaProyectos.Columns("Facturar").OptionsColumn.AllowEdit = True
        iVistaProyectos.Columns("Numero").Width = 60
        iVistaProyectos.Columns("Fecha").Width = 60
        iVistaProyectos.Columns("Nombre").Width = 180

        iVistaCostos.Columns("IdProyecto").Visible = False
        iVistaCostos.Columns("CostoO").Visible = False
        iVistaCostos.Columns("Tipo").Visible = False
        iVistaCostos.Columns("Costo").OptionsColumn.AllowEdit = True
        iVistaCostos.Columns("Costo").ColumnEdit = rMonto
        iVistaCostos.Columns("Facturar").OptionsColumn.AllowEdit = True
        iVistaCostos.Columns("Facturar").ColumnEdit = rChekCostos

        iVistaCostos.Columns("Mono de Obra").OptionsColumn.AllowEdit = True
        iVistaCostos.Columns("Mono de Obra").ColumnEdit = rProyectosC
        iVistaCostos.Columns("Mono de Obra").Width = 150

        iVistaCostos.Columns("Flete").OptionsColumn.AllowEdit = True
        iVistaCostos.Columns("Flete").ColumnEdit = rProyectosC
        'iVistaCostos.Columns("Flete").Width = 150

        iVistaCostos.Columns("Varios").OptionsColumn.AllowEdit = True
        iVistaCostos.Columns("Varios").ColumnEdit = rProyectosC
        'iVistaCostos.Columns("Varios").Width = 150

        'iVistaCostos.Columns("Codigo").ColumnEdit = rProyectosC
        'iVistaCostos.Columns("Proyecto").OptionsColumn.AllowEdit = True
        'iVistaCostos.Columns("Proyecto").ColumnEdit = rProyectosN

        HideSplash()
    End Sub

    Sub Cargar()
        iGridProyectos.DataSource = db_Proyectos.FillxClienteCheck(IdCliente)

        Dim DT_MO As DataTable = ObtieneDatos("sp_GetManoDeObra", EmpresaActual)
        RepositorySearchLook(rProyectosC, DT_MO, "Nombre", "Codigo", 2)

        'RepositorySearchLook(rProyectosN, DT_ProySrv, "Nombre", "Codigo", 2)


        'iGrid1.DataSource = ObtieneDatos("JAR_GetReporteProyectoCostoFacturar", _
        '                                 0, _
        '                                 1, _
        '                                 EmpresaActual)

        '
        iGrid2.DataSource = ObtieneDatos("JAR_GetReporteProyectoCostoFacturar", _
                                         0, _
                                         2, _
                                         EmpresaActual)

        iGridItemProyectos.DataSource = ObtieneDatos("JAR_GetReporteProyectoCostoFacturar", _
                                         0, _
                                         3, _
                                         EmpresaActual)

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Dim factur As Boolean = False
        For i As Integer = 0 To iVistaCostos.DataRowCount - 1
            If iVistaCostos.GetRowCellValue(i, "Facturar") Then factur = True
        Next

        If Not factur Then
            XtraMsg("Debe Seleccionar al Menos 1 Proyecto para Facturar", MessageBoxIcon.Warning)
            Exit Sub
        End If

        Ok = "SI"
        Close()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Ok = "NO"
        Close()
    End Sub

    Private Sub cbProyectos_EditValueChanged(sender As Object, e As EventArgs)
        Cargar()
    End Sub

    Private Sub iGrid1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GenerarCostos()
    End Sub

    Sub GenerarCostos()
        Dim selec As Boolean = False, sProyecto As String = ""

        For i As Integer = 0 To iVistaProyectos.DataRowCount - 1
            If iVistaProyectos.GetRowCellValue(i, "Facturar") Then
                selec = True
                sProyecto = iVistaProyectos.GetRowCellValue(i, "IdProyecto").ToString + "," + sProyecto
            End If
        Next

        If Not selec Then
            XtraMsg("Debe Seleccionar al menos 1 Proyecto", MessageBoxIcon.Warning)
            Exit Sub
        End If

        MostrarDetalleProyecto(Mid(sProyecto, 1, Len(sProyecto) - 1))
    End Sub

    Sub MostrarDetalleProyecto(sProyecto As String)
        ShowSplash()

        DT_REQ = ObtieneDatos("JAR_GetReporteProyectoCostoFacturar",
                                         sProyecto,
                                         2,
                                         EmpresaActual)

        iGrid2.DataSource = DT_REQ

        DT_COSTO = ObtieneDatos("JAR_GetReporteProyectoCostoFacturar", _
                                         sProyecto, _
                                         3, _
                                         EmpresaActual)

        iGridItemProyectos.DataSource = DT_COSTO
        HideSplash()
    End Sub

    Private Sub iGridItemProyectos_DoubleClick(sender As Object, e As EventArgs) Handles iGridItemProyectos.DoubleClick
        If iVistaCostos.FocusedRowHandle < 0 Then Exit Sub
        '
        With frmProyectosCostosDetalle
            .IdProyecto = iVistaCostos.GetFocusedRowCellValue("IdProyecto")
            .Text = "Proyecto: " & iVistaCostos.GetFocusedRowCellValue("Codigo").ToString
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub iVistaCostos_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVistaCostos.CellValueChanged
        If e.Column.FieldName = "Costo" Then
            If iVistaCostos.GetRowCellValue(e.RowHandle, "CostoO") > 0.0 Then
                If e.Value > iVistaCostos.GetRowCellValue(e.RowHandle, "CostoO") Then
                    XtraMsg("El Valor del Costo no puede ser mayor", MessageBoxIcon.Error)
                    iVistaCostos.SetRowCellValue(e.RowHandle, "Costo", iVistaCostos.GetRowCellValue(e.RowHandle, "CostoO"))
                End If
            End If
        End If
    End Sub

    Private Sub iVistaCostos_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles iVistaCostos.ValidateRow
        'If iVistaCostos.GetRowCellValue(e.RowHandle,"Costo") >
    End Sub

    Private Sub iVista2_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVista2.CellValueChanged
        If e.Column.FieldName = "Cantidad" Then
            If e.Value > iVista2.GetRowCellValue(e.RowHandle, "CantidadO") Then
                XtraMsg("La Cantidad de la remisión no puede ser mayor", MessageBoxIcon.Error)
                iVista2.SetRowCellValue(e.RowHandle, "Cantidad", iVista2.GetRowCellValue(e.RowHandle, "CantidadO"))
            End If
        End If
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        For i As Integer = 0 To iVista2.DataRowCount - 1
            iVista2.SetRowCellValue(i, "Facturar", CheckEdit2.Checked)
            iVista2.SetRowCellValue(i, "Visible", CheckEdit2.Checked)
        Next
        iVista2.RefreshData()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        For i As Integer = 0 To iVistaProyectos.DataRowCount - 1
            iVistaProyectos.SetRowCellValue(i, "Facturar", CheckEdit1.Checked)
        Next
        iVistaProyectos.RefreshData()
    End Sub
End Class