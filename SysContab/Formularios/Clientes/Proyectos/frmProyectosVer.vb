Public Class frmProyectosVer

    Private _IdProyecto As Integer
    Public Property IdProyecto As Integer
        Get
            Return _IdProyecto
        End Get
        Set(ByVal value As Integer)
            _IdProyecto = value
        End Set
    End Property

    Private Sub frmProyectosVer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Close()
    End Sub

    Private Sub frmProyectosVer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        iGrid1.DataSource = ObtieneDatos("JAR_GetReporteProyectoCosto",
                                         IdProyecto,
                                         1,
                                         EmpresaActual)

        FormatoGrid(iVista1, 2, 0, False)

        iVista1.Columns("TipoD").Visible = False
        iVista1.Columns("Per_Id").Visible = False
        iVista1.Columns("Consecutivo").Visible = False
        iVista1.Columns("Proveedor_ID").Visible = False
        iVista1.Columns("ComprobanteID").Visible = False

        tCostoCompras.EditValue = iVista1.Columns("Costo").SummaryItem.SummaryValue

        iGrid2.DataSource = ObtieneDatos("JAR_GetReporteProyectoCosto",
                                         IdProyecto,
                                         2,
                                         EmpresaActual)

        FormatoGrid(iVista2, 2, 0, False)

        iGridFact.DataSource = ObtieneDatos("sp_GetProyectosFacturacion",
                                            IdProyecto,
                                            EmpresaActual)
        FormatoGrid(iVistaFact, 2, 0, False)

        tCostoRemisiones.EditValue = iVista2.Columns("Costo Total").SummaryItem.SummaryValue

        tFacturacion.EditValue = iVistaFact.Columns("Total").SummaryItem.SummaryValue
        tTotalCosto.EditValue = tCostoCompras.EditValue + tCostoRemisiones.EditValue
        tMargen.EditValue = tFacturacion.EditValue - tTotalCosto.EditValue
        tMargen.Properties.AppearanceReadOnly.ForeColor = Color.White
        If tMargen.EditValue <= 0.0 Then tMargen.Properties.AppearanceReadOnly.BackColor = Color.Crimson
        If tMargen.EditValue > 0.0 Then tMargen.Properties.AppearanceReadOnly.BackColor = Color.Navy
    End Sub

    Private Sub iVista1_DoubleClick(sender As Object, e As EventArgs) Handles iVista1.DoubleClick
        If iVista1.FocusedRowHandle < 0 Then Exit Sub
        '
        'Es una OP
        If iVista1.GetFocusedRowCellValue("TipoD") = 1 Then _
            VerFactura(iVista1.GetFocusedRowCellValue("No. Documento"),
                       iVista1.GetFocusedRowCellValue("Proveedor_ID"))

        'Es un Comprobante
        If iVista1.GetFocusedRowCellValue("TipoD") = 2 Then
            Dim f As FrmComprobantesDetallesNew = FrmComprobantesDetallesNew.Instance()
            f.txtlNoComprobante.Text = iVista1.GetFocusedRowCellValue("No. Documento")
            f.txtConsecutivo.Text = IsNull(iVista1.GetFocusedRowCellValue("Consecutivo"), "")
            f.Periodo = iVista1.GetFocusedRowCellValue("Per_Id")
            f.Fecha.EditValue = iVista1.GetFocusedRowCellValue("Fecha")
            f.Fecha1 = iVista1.GetFocusedRowCellValue("Fecha")
            f.ComprobanteID = iVista1.GetFocusedRowCellValue("ComprobanteID")
            f.TipoLiq = 0
            f.cmdAceptar.Enabled = False
            f.cmdAnular.Enabled = False
            f.ShowDialog()
            f.Dispose()
        End If

        'Es una OC
        If iVista1.GetFocusedRowCellValue("TipoD") = 3 Then
            Dim f As DataGridTextBoxCombo.frmOrdenesCompra = DataGridTextBoxCombo.frmOrdenesCompra.Instance()

            f.Modifica = True
            f.CargarPedido = False

            f.txtFactura.Text = IsNull(iVista1.GetFocusedRowCellValue("Consecutivo"), "")
            f.etDestino.Text = "1"

            f.txtFactura.Enabled = False
            f.MdiParent = Me.MdiParent
            f.Text = "Ver Orden de Compra"
            f.cmdAceptar.Enabled = False
            f.cbProveedor.Enabled = False
            f.ShowDialog()
            f.Dispose()
        End If


        'ShowSplash("Cargando O/C...")
        ''Dim f As DataGridTextBoxCombo.frmOrdenesCompraVer = f.Instance
        'Dim f As DataGridTextBoxCombo.frmOrdenesCompra = DataGridTextBoxCombo.frmOrdenesCompra.Instance()

        'f.Modifica = True
        'f.CargarPedido = False

        'f.txtFactura.Text = Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Orden")
        'f.etDestino.Text = Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Destino")

        ''f.NoOrden = Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "Orden") 'Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 0)
        ''f.Destino = Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "Destino") 'Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 11)
        ''If Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 11).ToString = "1" Then

        ''If Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Destino") = 1 Then
        ''    'f.rbProductos.Checked = True
        ''    f.TipoServicio.EditValue = "P"
        ''ElseIf Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Destino") = 2 Then
        ''    'ElseIf Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 11).ToString = "2" Then
        ''    'f.rbInventario.Checked = True
        ''    f.TipoServicio.EditValue = "I"
        ''    'ElseIf Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 11).ToString = "I" Then
        ''    'f.rbInventario.Checked = True
        ''ElseIf Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Destino") = 3 Then
        ''    f.TipoServicio.EditValue = "A"
        ''    'f.rbProdInvet.Checked = True
        ''End If

        ''f.gbTipo.Enabled = False
        'f.txtFactura.Enabled = False
        'f.MdiParent = Me.MdiParent
        'f.Text = "Editar Orden de Compra"
        'f.Show()

        '' If Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 8) = "Anulada" Or Me.dgOrdenes.Item(Me.dgOrdenes.CurrentRowIndex, 8) = "Facturada" Then
        'If Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Estado") = "Anulada" Or
        'Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Estado") = "Facturada" Then

        '    f.cmdAceptar.Enabled = False
        '    f.cbProveedor.Enabled = False
        '    'f.iGrid.Enabled = False
        '    'f.dgFacturas.ReadOnly = True
        '    'f.cmdConsulta.Enabled = False
        '    'f.dtpFecha.Enabled = False
        '    'f.dtpFechaPago.Enabled = False
        '    'f.cbTipoFactura.Enabled = False
        '    'f.Articulo.ColumnComboBox.Visible = False '8566284 28 01 8:50 am
        '    'f.ArticuloCodigo.ColumnComboBox.Visible = False
        'End If

        'f.WindowState = FormWindowState.Maximized
        ''
        'HideSplash()


    End Sub

    Sub VerFactura(NoFactura As String, IdProveedor As Integer)
        Dim f As frmFacturasCompra = frmFacturasCompra.Instance()
        f.etInicio.Text = "1"

        f.cmdAceptar.Enabled = False
        f.cmbdistribucion.Enabled = False
        f.btnDetalle.Enabled = False
        f.ckIR.Enabled = False
        f.chkIRAlc.Enabled = False
        f.ckIVAAsumido.Enabled = False

        f.txtfactura.Text = NoFactura
        f.Proveedor = IdProveedor
        f.etOrigen.Text = 1
        f.TipoF = "A"
        f.gbTipo.EditValue = 3
        f.Modifica = True
        f.VerFactura = True
        f.TipoC = 2
        f.gbTipo.Enabled = False

        f.Text = "Ver Orden de Pago"
        f.ShowDialog()
        f.etInicio.Text = "0"
        f.Dispose()
    End Sub

    Private Sub iVista2_DoubleClick(sender As Object, e As EventArgs) Handles iVista2.DoubleClick
        If sender.FocusedRowHandle < 0 Then Exit Sub
        '        
        Nuevo = "SI"
        FrmRequisasnew.IdRequisa = iVista2.GetFocusedRowCellValue("#Remisión")
        FrmRequisasnew.Text = "Editar Movimiento"
        FrmRequisasnew.cmdguardar.Enabled = False
        FrmRequisasnew.SimpleButton1.Enabled = False
        FrmRequisasnew.ShowDialog()
        FrmRequisasnew.Dispose()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmExportarImprimir.Mostrar(iGrid1, "Costos por Compras")
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        frmExportarImprimir.Mostrar(iGrid2, "Costos por Remisiones")
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        db_Proyectos.Imprimir(IdProyecto)
    End Sub

    Private Sub iVistaFact_DoubleClick(sender As Object, e As EventArgs) Handles iVistaFact.DoubleClick
        If iVistaFact.FocusedRowHandle < 0 Then Exit Sub

        ShowSplash()
        '
        frmFacturasVentasEditar.Dispose()
        '
        With frmFacturasVentasEditar

            .Factura = iVistaFact.GetFocusedRowCellValue("Factura")
            .bGuardar.Enabled = False
            .Text = "Ver Factura"
            .Show()

            '  .WindowState = FormWindowState.Maximized
            '
        End With
        '
        HideSplash()


        'Dim f As DataGridTextBoxCombo.frmFacturacionClienteVer = DataGridTextBoxCombo.frmFacturacionClienteVer.Instance()

        'Registro = iVistaFact.GetFocusedRowCellValue("Factura")

        ''f.MdiParent = Me.MdiParent
        ''f.Show()
        'f.Text = "Ver Factura: " & iVistaFact.GetFocusedRowCellValue("Factura")
        'f.ShowDialog()
        'f.Dispose()
        ''f.WindowState = FormWindowState.Maximized
    End Sub
End Class