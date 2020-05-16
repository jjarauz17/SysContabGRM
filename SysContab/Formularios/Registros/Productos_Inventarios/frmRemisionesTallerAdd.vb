Public Class frmRemisionesTallerAdd 

    Public IdRemision As Integer = 0
    Private Data As DataTable = New DataTable("Remision")
    Private Temp As Boolean = False

    Private Sub frmRemisionesTallerAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetBodegasxUsuario(cmbbodega, 0)
        'GetBodegasList(cmbbodega)
        ''
        cmbrequisa.Properties.DataSource = ObtieneDatos("SELECT 'Entrada' AS Nombre,1 AS Codigo UNION ALL SELECT 'Salida' AS Nombre,2 AS Codigo")
        cmbrequisa.Properties.PopulateColumns()
        cmbrequisa.Properties.DisplayMember = "Nombre"
        cmbrequisa.Properties.ValueMember = "Codigo"
        cmbrequisa.Properties.Columns(1).Visible = False
        ''
        cbOrdenTrabajo.Properties.DataSource = ObtieneDatos("jar_GetOrdenesTrabajoPendientes " & EmpresaActual)
        cbOrdenTrabajo.Properties.ValueMember = "IdOrden"
        cbOrdenTrabajo.Properties.DisplayMember = "Mostrar"
        cbOrdenTrabajo.Properties.PopulateViewColumns()
        FormatoGrid(iLVista)
        iLVista.Columns("Mostrar").Visible = False
        cbOrdenTrabajo.Properties.PopupFormSize = New Point(1000, 0)

        GetData()
    End Sub

    Private Sub GetData()
        If IdRemision = 0 Then
            Me.txtrealizado.Text = Usuario
            Me.txtrequisa.Text = db_Taller_Remisiones.GetCodigoNuevo()
            Me.cmbrequisa.EditValue = 1            
            Me.cmbbodega.ItemIndex = 0
            Me.TipoServicio.EditValue = "P"
            Me.fecha.EditValue = VB.SysContab.Rutinas.Fecha().Date
        Else
            TipoServicio.Enabled = False
            'Me.cmbbodega.Enabled = False
            cmbrequisa.Enabled = False
            ''txtrequisa.Text = IdRemision

            Dim DT As DataTable = db_Taller_Remisiones.Listar(IdRemision)   '' ObtieneDatos("SPGetRequisasEditar " & IdRequisa & "," & EmpresaActual)

            txtrequisa.EditValue = DT.Rows(0)("Codigo")
            TipoServicio.EditValue = "P"
            cmbbodega.EditValue = DT.Rows(0)("Bodega")
            cmbrequisa.EditValue = IIf(DT.Rows(0)("Tipo") = "E", 1, 2)
            fecha.EditValue = DT.Rows(0)("Fecha")
            txtrealizado.Text = DT.Rows(0)("Realizadopor")
            txtReferencia.Text = DT.Rows(0)("Referencia")
            cbOrdenTrabajo.EditValue = CInt(DT.Rows(0)("OrdenTrabajo"))

            If cmbrequisa.EditValue = 2 Then
                cmbbodega.Enabled = False
            End If

            If DT.Rows(0)("Procesado") Then
                bGuardar.Enabled = False
                cmbbodega.Enabled = False
            End If
        End If
    End Sub

    Private Sub cmbrequisa_EditValueChanged(sender As Object, e As EventArgs) Handles cmbrequisa.EditValueChanged
        ''ShowSplash("Cargando Inventario...")

        If sender.editvalue = 1 Then
            Me.vDatos.OptionsView.ShowAutoFilterRow = False
        Else
            Me.vDatos.OptionsView.ShowAutoFilterRow = True
        End If

        BuscarArticulos()
        ''
        '' HideSplash()
    End Sub

    Private Sub BuscarArticulos()
        If cmbrequisa.EditValue = 2 Then    '' Salida

            Data = ObtieneDatos("SP_GetBodegasArticulos " & EmpresaActual & ",'" & cmbbodega.EditValue & "','" & TipoServicio.EditValue & "',0," & IdRemision)
            GridDetalle.DataSource = Data
            vDatos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None

            vDatos.Columns("Cantidad").Caption = "Cantidad a Retirar"
        Else    '' Entrada
            Data = ObtieneDatos("SP_GetBodegasArticulos " & EmpresaActual & ",'" & cmbbodega.EditValue & "','" & TipoServicio.EditValue & "',1," & IdRemision)
            GridDetalle.DataSource = Data
            vDatos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            vDatos.Columns("Cantidad").Caption = "Cantidad a Ingresar"
        End If

        ''Dim Config As New VB.SysContab.ConfiguracionDB
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails

        Me.txtCosto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCosto.Mask.EditMask = "n" + ConfigDetalles.Decimales.ToString

        Me.vDatos.Columns("Costo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Costo").SummaryItem.DisplayFormat = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
    End Sub

    Private Sub ListaArticulos()
        Dim DTP As DataTable
        DTP = ObtieneDatos("SP_GetArticulo " & EmpresaActual & ",'" & TipoServicio.EditValue & "'")
        ItemProducto.DataSource = DTP
        ItemProducto.DisplayMember = "Codigo"
        ItemProducto.ValueMember = "Codigo"
        ItemProducto.PopulateColumns()
        ItemProductoD.DataSource = DTP
        ItemProductoD.DisplayMember = "Nombre"
        ItemProductoD.ValueMember = "Codigo"
        ItemProductoD.PopulateColumns()
    End Sub

    Private Sub TipoServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipoServicio.SelectedIndexChanged
        ListaArticulos()
        BuscarArticulos()
    End Sub

    Private Sub vDatos_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vDatos.CellValueChanged
        If e.Column.FieldName = "Codigo" Then

            If Data.Compute("Count(Codigo)", "Codigo = '" & e.Value & "'") >= 1 And cmbrequisa.Text.ToString.Substring(0, 1) = "E" Then
                XtraMsg("Ya existe este articulo en la lista", MessageBoxIcon.Warning)
                vDatos.DeleteRow(vDatos.FocusedRowHandle)
            End If

            Try
                'vDatos.SetRowCellValue(e.RowHandle, "Existencia", ObtieneDatos("SELECT ISNULL(SUM(Existencia),0) FROM Bodegas_Articulos WHERE Empresa = " & EmpresaActual & " AND Codigo_Bodega = '" & cmbbodega.EditValue & "' AND Codigo_Articulo = '" & e.Value & "'").Rows(0).Item(0))
                'vDatos.SetRowCellValue(e.RowHandle, "Costo", ObtieneDatos("SELECT isnull(costo,0) FROM Bodegas_Articulos WHERE Empresa = " & EmpresaActual & " AND Codigo_Bodega = '" & cmbbodega.EditValue & "' AND Codigo_Articulo = '" & e.Value & "'").Rows(0).Item(0))

                vDatos.SetRowCellValue(e.RowHandle, "Existencia", ObtieneDatos("SELECT dbo.fn_CalcularExistencia('" & cmbbodega.EditValue & "','" & e.Value & "'," & EmpresaActual & ") Existencia").Rows(0).Item(0))
                vDatos.SetRowCellValue(e.RowHandle, "Costo", ObtieneDatos("SELECT isnull(ba.Costo_Prom,0.00) FROM Bodegas_Articulos ba WHERE Empresa = " & EmpresaActual & " AND Codigo_Bodega = '" & cmbbodega.EditValue & "' AND Codigo_Articulo = '" & e.Value & "'").Rows(0).Item(0))
                '' vDatos.SetRowCellValue(e.RowHandle, "Cuenta", MovimientoCuenta())
            Catch ex As Exception
                vDatos.SetRowCellValue(e.RowHandle, "Existencia", 0)
                vDatos.SetRowCellValue(e.RowHandle, "Costo", 0)
                '' vDatos.SetRowCellValue(e.RowHandle, "Cuenta", "")
            End Try

            ''Me.vDatos.Columns("Codigo").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default

            Data.DefaultView.RowFilter = ""
        End If
    End Sub

    Private Sub vDatos_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles vDatos.RowUpdated
        Data.DefaultView.RowFilter = ""
    End Sub

    Private Sub vDatos_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles vDatos.ValidateRow
        If IsDBNull(vDatos.GetRowCellValue(e.RowHandle, "Codigo")) Or (IsDBNull(vDatos.GetRowCellValue(e.RowHandle, "Cantidad"))) Then
            e.ErrorText = "Complete la informacion" & vbCrLf
            e.Valid = False
        End If
    End Sub

    Private Sub cmbbodega_EditValueChanged(sender As Object, e As EventArgs) Handles cmbbodega.EditValueChanged
        If IdRemision = 0 Then BuscarArticulos()
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click

    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(GridDetalle)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub
End Class