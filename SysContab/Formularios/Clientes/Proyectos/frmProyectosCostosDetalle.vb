Public Class frmProyectosCostosDetalle 

    Public IdProyecto As Integer = 0

    Private Sub frmProyectosCostosDetalle_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
    Private Sub frmProyectosCostosDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iGrid1.DataSource = ObtieneDatos("JAR_GetReporteProyectoCosto", _
                                        IdProyecto, _
                                        1, _
                                        EmpresaActual)

        iVista1.PopulateColumns() : FormatoGrid(iVista1, 2, 0, False)
        '
        iVista1.Columns("TipoD").Visible = False
        iVista1.Columns("Per_Id").Visible = False
        iVista1.Columns("Consecutivo").Visible = False
        iVista1.Columns("Proveedor_ID").Visible = False
        iVista1.Columns("ComprobanteID").Visible = False

        'iVista1.Columns("IdDetalle").Visible = False
        'iVista1.Columns("IdProyecto").Visible = False
        'iVista1.Columns("IdProveedor").Visible = False
        'iVista1.Columns("Tipo").Visible = False
        'iVista1.Columns("ComprobanteID").Visible = False
        'iVista1.Columns("Per_Id").Visible = False
        'iVista1.Columns("Consecutivo").Visible = False
        'iVista1.Columns("Costo").OptionsColumn.AllowEdit = True
        ''iVista1.Columns("Facturar").OptionsColumn.AllowEdit = True
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmExportarImprimir.Mostrar(iGrid1, Me.Text)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub iVista1_DoubleClick(sender As Object, e As EventArgs) Handles iVista1.DoubleClick
        If iVista1.FocusedRowHandle < 0 Then Exit Sub
        '
        'Es una OP
        If iVista1.GetFocusedRowCellValue("TipoD") = 1 Then _
           VerFactura(iVista1.GetFocusedRowCellValue("No. Documento"), _
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

End Class