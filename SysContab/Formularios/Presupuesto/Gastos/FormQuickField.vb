Imports ClasesBLL

Public Class FormQuickField
    Private Sub FormQuickField_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CheckedComboBoxEdit1.Properties.Items.Add(fn.ObtieneDatos("sp_Presupuesto_return_combo", 7, 1, "", 0, False, "", 0, 0))
        CheckedComboBoxEdit1.Properties.Items.Add(2, "prueba")
        LookUpEdit1.Properties.DataSource = fn.ObtieneDatos("sp_Presupuesto_return_combo", 33, 1, "", 0, False, "", 0, 0)
        LookUpEdit1.Properties.DisplayMember = "Cuenta"
        LookUpEdit1.Properties.ValueMember = "Numero de Cuenta"
    End Sub

    'fn.ObtieneDatos("sp_sel_PresupuestoGastoDetalle", Convert.ToInt64(TextEdit3.Text), 6)



End Class