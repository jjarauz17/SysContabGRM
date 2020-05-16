Imports DevExpress.XtraEditors

Public Class frmUsuariosPass

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtusuario.Text = Login
    End Sub

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub cmdaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaceptar.Click
        Dim Datos As New ArrayList
        Dim Variables As New ArrayList

        If Trim(txtactual.Text) = Nothing Or Trim(txtnueva.Text) = Nothing Or Trim(txtrepetir.Text) = Nothing Then
            XtraMessageBox.Show("Complete la informacion", "Almacen Financiero", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtactual.Text = txtnueva.Text Then
            DxError.SetError(txtnueva, "La contraseña anterior y la nueva no deben ser iguales")
            DxError.SetError(txtactual, "La contraseña anterior y la nueva no deben ser iguales")
            Exit Sub
        End If
        If txtnueva.Text <> txtrepetir.Text Then
            DxError.SetError(txtnueva, "No coinciden las contraseñas")
            DxError.SetError(txtrepetir, "No coinciden las contraseñas")
            Exit Sub
        End If
        '
        Datos.Add(txtusuario.text)
        Datos.Add(txtactual.Text)
        Datos.Add(txtnueva.Text)

        Variables.Add("User")
        Variables.Add("Old")
        Variables.Add("Pass")
        '
        If ProcedureSave(Datos, Variables, "SPChangePass") Then
            MsgBox("Contraseña cambiada", MsgBoxStyle.OkOnly)
            Password = txtnueva.Text
        Else
            MsgBox("Error al cambiar la contraseña, intente nuevamente", MsgBoxStyle.Critical)
        End If
        Close()
    End Sub

    Private Sub txtusuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusuario.TextChanged, txtactual.TextChanged, txtnueva.TextChanged, txtrepetir.TextChanged
        DxError.Clear()
    End Sub
End Class