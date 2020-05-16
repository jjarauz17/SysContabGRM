Public Class frmBuscarOrdenCompra

    Public Ok As Boolean = False

    Private Sub frmBuscarOrdenCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowSplash()
        '
        Cargar()
        '
        HideSplash()
    End Sub

    Sub Cargar()
        iGrid.DataSource =
            ObtieneDatos("sp_sel_OrdenesCompraPendiente", EmpresaActual)
        iVista.PopulateColumns()
        FormatoGrid(iVista)
        '
        iVista.Columns("Monto").Visible = False
        iVista.Columns("Descuento").Visible = False
        iVista.Columns("Factura_Origen").Visible = False
        iVista.Columns("Destino").Visible = False
        '
        iVista.Columns("Proveedor").Width = 250
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro de la lista!")
            Exit Sub
        End If
        Ok = True
        Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Ok = False
        Close()
    End Sub

    Private Sub frmBuscarOrdenCompra_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Ok = False
            Close()
        End If
    End Sub

    Private Sub iVista_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick
        If iVista.FocusedRowHandle < 0 Then Exit Sub
        '
        Ok = True
        Close()
    End Sub
End Class