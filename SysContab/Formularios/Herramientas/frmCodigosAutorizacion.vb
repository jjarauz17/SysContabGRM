Public Class frmCodigosAutorizacion 
    Dim DT As DataTable

    Private Sub frmCodigosAutorizacion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.S Then
            txtComercial.Properties.PasswordChar = ""
            txtFinanciera.Properties.PasswordChar = ""
            txtConfirmar.Properties.PasswordChar = ""
            '
            txtClaveVendedor.Properties.PasswordChar = ""
            txtClaveGerente.Properties.PasswordChar = ""
            txtClaveFinanzas.Properties.PasswordChar = ""
        End If
        '
        If e.KeyCode = Keys.H Then
            txtComercial.Properties.PasswordChar = "●"
            txtFinanciera.Properties.PasswordChar = "●"
            txtConfirmar.Properties.PasswordChar = "●"
            '
            txtClaveVendedor.Properties.PasswordChar = "●"
            txtClaveGerente.Properties.PasswordChar = "●"
            txtClaveFinanzas.Properties.PasswordChar = "●"
        End If
    End Sub

    Private Sub frmCodigosAutorizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cargar()
        DT = ObtieneDatos("JAR_GetCodigos 'PCOMPRA'," & EmpresaActual)
        ''
        If DT.Rows.Count > 0 Then
            txtComercial.Text = DT.Rows.Item(0)("Codigo1")
            txtFinanciera.Text = DT.Rows.Item(0)("Codigo2")
            txtConfirmar.Text = DT.Rows.Item(0)("Codigo3")

            txtClaveVendedor.Text = DT.Rows.Item(0)("Codigo_Vendedor")
            txtClaveGerente.Text = DT.Rows.Item(0)("Codigo_Gerente")
            txtClaveFinanzas.Text = DT.Rows.Item(0)("Codigo_Finanza")

            sDesdeVendedor.EditValue = DT.Rows.Item(0)("Desde_Vendedor")
            sHastaVendedor.EditValue = DT.Rows.Item(0)("Hasta_Vendedor")
            '
            sDesdeGerente.EditValue = DT.Rows.Item(0)("Desde_Gerente")
            sHastaGerente.EditValue = DT.Rows.Item(0)("Hasta_Gerente")
            '
            sDesdeFinanza.EditValue = DT.Rows.Item(0)("Desde_Finanza")
            sHastaFinanza.EditValue = DT.Rows.Item(0)("Hasta_Finanza")
        End If
    End Sub

    Private Sub b_Click(sender As Object, e As EventArgs) Handles b.Click
        Dim IdDetalle As Integer = 1
        If DT.Rows.Count = 0 Then IdDetalle = 0

        Dim variables As New ArrayList, datos As New ArrayList

        variables.Add("IdDetalle")
        variables.Add("Tipo")
        variables.Add("Empresa")
        variables.Add("Codigo1")
        variables.Add("Codigo2")
        variables.Add("Codigo3")
        variables.Add("Codigo_Vendedor")
        variables.Add("Codigo_Gerente")
        variables.Add("Codigo_Finanza")
        variables.Add("Desde_Vendedor")
        variables.Add("Hasta_Vendedor")
        variables.Add("Desde_Gerente")
        variables.Add("Hasta_Gerente")
        variables.Add("Desde_Finanza")
        variables.Add("Hasta_Finanza")

        datos.Add(IdDetalle)
        datos.Add("PCOMPRA")
        datos.Add(EmpresaActual)
        datos.Add(txtComercial.Text)
        datos.Add(txtFinanciera.Text)
        datos.Add(txtConfirmar.Text)
        datos.Add(txtClaveVendedor.Text)
        datos.Add(txtClaveGerente.Text)
        datos.Add(txtClaveFinanzas.Text)
        datos.Add(sDesdeVendedor.EditValue)
        datos.Add(sHastaVendedor.EditValue)
        datos.Add(sDesdeGerente.EditValue)
        datos.Add(sHastaGerente.EditValue)
        datos.Add(sDesdeFinanza.EditValue)
        datos.Add(sHastaFinanza.EditValue)

        If ProcedureSave(datos, variables, "JAR_GuardarCodigos") Then
            XtraMsg("Datos Guardados!")
            Cargar()
        End If
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub
End Class