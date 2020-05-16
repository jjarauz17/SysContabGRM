Public Class frmInteresesClientes 

    Dim ID As Integer = 0
    Dim obj As New Clientes_Intereses
    Dim db As New db_Clientes_Intereses

    Private Sub frmInteresesClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchLookUp(cbCuentaCorriente, ObtieneDatos("_GetCatalogo_Cuenta " & EmpresaActual), "Display", "Cuenta", 2)
        SearchLookUp(cbCuentaMorosidad, ObtieneDatos("_GetCatalogo_Cuenta " & EmpresaActual), "Display", "Cuenta", 2)
        Cargar()
    End Sub

    Sub Cargar()
        Dim DT As DataTable = db_Clientes_Intereses.Listar()

        If DT.Rows.Count = 0 Then ID = 0
        If DT.Rows.Count <> 0 Then ID = DT.Rows.Item(0)("IdInteres")

        If ID > 0 Then
            txtCorrientes.EditValue = DT.Rows.Item(0)("Corriente")
            txtMoratorio.EditValue = DT.Rows.Item(0)("Moratorio")

            cbCuentaCorriente.EditValue = DT.Rows.Item(0)("Cuenta_Corriente")
            cbCuentaMorosidad.EditValue = DT.Rows.Item(0)("Cuenta_Morosidad")
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        obj.IdInteres = ID
        obj.Empresa = EmpresaActual
        obj.Corriente = txtCorrientes.EditValue
        obj.Moratorio = txtMoratorio.EditValue
        obj.Cuenta_Corriente = cbCuentaCorriente.EditValue
        obj.Cuenta_Morosidad = cbCuentaMorosidad.EditValue

        If ID = 0 Then db.Insertar(obj)
        If ID <> 0 Then db.Actualizar(obj)

        XtraMsg("Datos Guardados...")
        Cargar()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub
End Class