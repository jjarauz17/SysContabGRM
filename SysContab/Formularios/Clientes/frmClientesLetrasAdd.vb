Imports Entities
Imports SysContab.VB.SysContab

Public Class frmClientesLetrasAdd
    Public Ok As Boolean = False,
        Id As Integer = 0

    Dim obj As New ClientesLetrasCambio,
        db As New db_ClientesLetrasCambio

    Private Sub frmClientesLetrasAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Ok = False
            Close()
        End If

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If Not DxValidationProvider1.Validate Then Exit Sub

        obj.Id = Id
        obj.Empresa = EmpresaActual
        obj.IdCliente = cbClientes.EditValue
        obj.ANombre = txtANombre.Text
        obj.NEmpresa = NombreEmpresaActual
        obj.Fecha = dFecha.DateTime
        obj.Vencimiento = dVencimiento.DateTime
        obj.Moneda = cbMoneda.EditValue
        obj.TCambio = txtTCambio.EditValue
        obj.Monto = txtMonto.EditValue
        obj.Comentarios = mComentarios.Text
        obj.EnLetras = Rutinas.Letras(txtMonto.EditValue, cbMoneda.Text)

        If Id = 0 Then
            Ok = db.Insertar(obj)
        Else
            Ok = db.Actualizar(obj)
        End If

        If Ok Then Close()
    End Sub

    Private Sub dFecha_EditValueChanged(sender As Object, e As EventArgs) Handles dFecha.EditValueChanged
        txtTCambio.EditValue = GetTasaCambioDia(IsNull(dFecha.DateTime.Date, Now.Date))
    End Sub

    Private Sub cbClientes_EditValueChanged(sender As Object, e As EventArgs) Handles cbClientes.EditValueChanged
        txtANombre.Text = sender.Text
    End Sub

    Private Sub Salir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Salir.ItemClick
        Ok = False
        Close()
    End Sub

    Private Sub frmClientesLetrasAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        dFecha.DateTime = f.Date
        dVencimiento.DateTime = f.Date

        SearchLookUp(
            cbClientes,
            ClientesDB.GetList(1).Tables("Clientes"),
            "Nombre",
            "Codigo", 4, 5, 6, 7, 8)

        GetMonedasList(cbMoneda)

        If Id > 0 Then
            obj = db.Detalles(Id, EmpresaActual)

            cbClientes.EditValue = obj.IdCliente
            txtANombre.Text = obj.ANombre
            dFecha.DateTime = obj.Fecha
            dVencimiento.DateTime = obj.Vencimiento
            cbMoneda.EditValue = obj.Moneda
            txtTCambio.EditValue = obj.TCambio
            txtMonto.EditValue = obj.Monto
            mComentarios.Text = obj.Comentarios
        End If

    End Sub
End Class