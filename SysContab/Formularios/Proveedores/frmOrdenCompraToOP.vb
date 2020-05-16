Imports System.Linq
Imports System.ComponentModel
Imports SysContab.VB.SysContab

Public Class frmOrdenCompraToOP

    Public NoOrden As String,
        Ok As Boolean = False,
        ds As New DataSet
    Dim OC As New VB.SysContab.Ordenes_ComprasDB(),
        _DT As New DataTable("OrdenCompra")

    Private Sub frmOrdenCompraToOP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchLookUp(
                cbProveedor,
                ProveedoresDB.ProveedoresList(1).Tables("Proveedores"), "Nombre", "Codigo")

        dFecha.DateTime = Rutinas.Fecha().Date

        _DT = OC.OrdenComprasDetalleTrasladar(NoOrden)
        iGrid.DataSource = _DT
        FormatoGrid(iVista, 4, 0, False)

        cbProveedor.EditValue = _DT.Rows.Item(0)("Proveedor_ID")
        etTasa.EditValue = GetTasaCambioDia(dFecha.DateTime)

        Dim Tipo As IEnumerable(Of String) =
                       From row In _DT.AsEnumerable()
                       Select row.Field(Of String)("Tipo") Distinct

        If Tipo.Count > 1 Then
            TipoServicio.EditValue = "A"
        Else
            TipoServicio.EditValue = Tipo.ToList().Item(0).ToString()
        End If

        Dim s() As String = Split(NoOrden, ",")

        If Split(NoOrden, ",").Count > 1 Then
            iVista.Columns("NoOrden").Visible = True
            iVista.Columns("NoOrden").VisibleIndex = 0
        End If
    End Sub

    Private Sub frmOrdenCompraToOP_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Ok = False
            Close()
        End If
    End Sub

    Private Sub dFecha_EditValueChanged(sender As Object, e As EventArgs) Handles dFecha.EditValueChanged
        etTasa.EditValue = GetTasaCambioDia(IsNull(dFecha.DateTime, Now.Date))
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'ShowSplash()
        'Inicio = True
        ''
        'Dim frm As frmFacturasCompra = frmFacturasCompra.Instance()
        'frm.Dispose()
        ''
        'Dim f As frmFacturasCompra = frmFacturasCompra.Instance()
        'f.OrdenCompra = Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Orden")
        'f.txtOrden.Text = Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "No. Orden")
        'f.etOrigen.Text = Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Factura_Origen")
        'f.Destino = 1
        'f.gbTipo.Enabled = False
        'f.MdiParent = Me.MdiParent
        'f.etTipo.Text = "A"
        'f.Show()
        'f.Text = "Nueva Orden de Pago"
        'f.WindowState = FormWindowState.Maximized
        'f.txtfactura.Focus()
        'f.Nuevo = False
        ''
        'Inicio = False
        'HideSplash()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Ok = False
        Close()
    End Sub

    Private Sub iVista_ShowingEditor(sender As Object, e As CancelEventArgs) Handles iVista.ShowingEditor
        If iVista.GetRowCellValue(iVista.FocusedRowHandle, "Entregado") >=
            iVista.GetRowCellValue(iVista.FocusedRowHandle, "Cantidad") Then
            e.Cancel = True
        End If

    End Sub
End Class