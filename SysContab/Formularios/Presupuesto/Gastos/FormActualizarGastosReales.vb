Imports ClasesBLL

Public Class FormActualizarGastosReales
    Private Sub FormActualizarGastosReales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '/////////////////////////////////////////EMPRESA////////////////////////////////////////////
        LookUpEdit1.Properties.DataSource = ObtieneDatos("sp_Presupuesto_return_combo", 2, Globales.Usuario_ID, "", 0, False, "", 0, 0)
        LookUpEdit1.Properties.DisplayMember = "NOMBRE"
        LookUpEdit1.Properties.ValueMember = "CODIGO"
        LookUpEdit1.Properties.PopulateColumns()

        LookUpEdit1.EditValue = Globales.EmpresaActual

        DateDesde.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        DateDesde.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        DateDesde.Properties.EditFormat.FormatString = "yyyy-MM-dd"
        DateDesde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        DateDesde.Properties.Mask.EditMask = "yyyy-MM-dd"


        DateHasta.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"
        DateHasta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        DateHasta.Properties.EditFormat.FormatString = "yyyy-MM-dd"
        DateHasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        DateHasta.Properties.Mask.EditMask = "yyyy-MM-dd"

    End Sub

    Private Sub LookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEdit1.EditValueChanged


        LookUpEdit3.Properties.DataSource = ObtieneDatos("sp_Presupuesto_return_combo", 5, LookUpEdit1.EditValue, "", 0, False, "", 0, 0)
        LookUpEdit3.Properties.DisplayMember = "Nombre"
        LookUpEdit3.Properties.ValueMember = "Codigo"
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash()
        '
        Try
            'fn.XtraMsg("Desde: " + DateDesde.DateTime + " Hasta: " + DateHasta.Text + "editmask " + DateHasta.Properties.Mask.EditMask)
            fn.Guardar("SP_Actualizar_PresuGastoReal", Convert.ToInt64(LookUpEdit1.EditValue), Convert.ToInt64(LookUpEdit3.EditValue), DateDesde.Text, DateHasta.Text)
        Catch ex As Exception
            'fn.XtraMsg("Error al Actualizar los registros: " + ex.ToString)
        End Try
        '
        HideSplash()

    End Sub
End Class