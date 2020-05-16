Public Class frmCuentaDiferenciaVentas

    Public ok As String = "NO"

    Private Sub frmCuentaDiferenciaVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioGroup1.EditValue = "D"
        GetCatalogoCuenta(cbCatalogo, glvDatos)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If cbCatalogo.EditValue Is Nothing Then
            XtraMsg("Seleccione Cuenta Contable")
            cbCatalogo.Focus()
            Exit Sub
        End If

        ok = "SI"
        Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        ok = "NO"
        Close()
    End Sub
End Class