Public Class frmAsociarFacturasOT

    Public Property IdOrden As Integer = 0
    Public Property Ok As Boolean = False

    Private Sub frmAsociarFacturasOT_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Dispose()
    End Sub

    Private Sub frmAsociarFacturasOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iGrid.DataSource = ObtieneDatos("sp_sel_FacturasVentasOT", EmpresaActual)
        iVista.PopulateColumns()
        SimpleFormatGrid(iVista,
                         False,
                         DevExpress.Utils.HorzAlignment.Default,
                         0,
                         False, 0)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura!")
            Exit Sub
        End If
        '
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Ok = False
        Dispose()
    End Sub
End Class