Public Class frmFacturasComprasListNew

    Public IdProveedor As Integer = 0,
        IdTipoPago As Integer = 0,
        Estado As String = "T"
    Dim ProveedorDetalle As New VB.SysContab.ProveedoresDetails()
    Dim Facturas As New VB.SysContab.Facturas_ComprasDB()

    Private Sub frmFacturasComprasListNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProveedorDetalle = VB.SysContab.ProveedoresDB.GetDetails(IdProveedor)
        '
        Cargar()
        '
        etDescripcion.Text = "Facturas del Proveedor:  " & ProveedorDetalle.Nombre
    End Sub

    Sub Cargar()
        iGrid.DataSource = Facturas.FacturasList(
            IdProveedor,
            IdTipoPago,
            "",
            "",
            Estado).Tables("Facturas_Compras").DefaultView

        iVista.PopulateColumns()
        FormatoGrid(iVista)
        iVista.Columns("Proveedor").Visible = False
        iVista.Columns("Proveedor_ID").Visible = False
    End Sub

    Private Sub bVer_Click(sender As Object, e As EventArgs) Handles bVer.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If

        ShowSplash()
        '
        Dim frm As frmFacturasCompra = frmFacturasCompra.Instance()
        frm.Dispose()
        '
        Dim f As frmFacturasCompra = frmFacturasCompra.Instance()
        f.etInicio.Text = "1"

        f.cmdAceptar.Enabled = False
        f.cmbdistribucion.Enabled = False
        f.btnDetalle.Enabled = False
        f.ckIR.Enabled = False
        f.chkIRAlc.Enabled = False
        f.ckIVAAsumido.Enabled = False

        f.txtfactura.Text = iVista.GetFocusedRowCellValue("Factura")
        f.Proveedor = IdProveedor
        f.etOrigen.Text = "1"
        f.TipoF = "A"
        f.Modifica = True
        f.VerFactura = True
        f.TipoC = 2
        f.gbTipo.Enabled = False

        If f.TipoF = "P" Then
            f.gbTipo.EditValue = 0
        ElseIf f.TipoF = "S" Then
            f.gbTipo.EditValue = 1
        ElseIf f.TipoF = "A" Then
            f.gbTipo.EditValue = 3
        ElseIf f.TipoF = "I" Then
            f.gbTipo.EditValue = 4
        End If

        'f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Ver Orden de Pago"
        'f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
        '
        HideSplash()
    End Sub

    Private Sub b_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub frmFacturasComprasListNew_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
End Class