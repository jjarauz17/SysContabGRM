Public Class frmShowDialog

    Public ok As String = ""

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        ok = "NO"
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        ok = "SI"
        Me.Close()
    End Sub

    Private Sub frmShowDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbCuentas.Properties.DataSource = ObtieneDatos("_GetCatalogo_Cuenta " & EmpresaActual)
        Me.cbCuentas.Properties.DisplayMember = "Display"
        Me.cbCuentas.Properties.ValueMember = "Cuenta"
        Me.cbCuentas.Properties.PopulateColumns()
        Me.cbCuentas.Properties.Columns("Display").Visible = False
        Me.cbCuentas.ItemIndex = 0
    End Sub
End Class