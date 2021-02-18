Imports Entities

Public Class frmSeguimientoAdd

    Public ID As Integer = 0,
        IdCliente As Integer = 0,
        Ok As Boolean = False

    Dim objSeguimiento As New ClientesSeguimiento
    Dim dbSeguimiento As New db_ClientesSeguimiento

    Private Sub frmListaNegraAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        ShowSplash("Calculando Saldo...")

        SearchLookUp(
            cbCliente,
            VB.SysContab.ClientesDB.GetList(1).Tables("Clientes"),
            "Nombre",
            "Codigo",
            4, 5, 6, 7, 8)

        If ID > 0 Then
            objSeguimiento = dbSeguimiento.Detalles(ID, EmpresaActual)
            cbCliente.EditValue = objSeguimiento.IdCliente
            cbCliente.Properties.ReadOnly = True


            FechaLlamada.DateTime = objSeguimiento.FechaLlamada
            FechaPago.DateTime = Convert.ToDateTime(objSeguimiento.FechaPago)
            HoraPago.DateTime = Convert.ToDateTime(objSeguimiento.HoraPago)
            Acuerdo.Text = objSeguimiento.Acuerdo
            Comentario.Text = objSeguimiento.Descripcion
        Else
            If IdCliente > 0 Then
                cbCliente.EditValue = IdCliente
                cbCliente.Properties.ReadOnly = True
            End If
        End If
        '
        HideSplash()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        objSeguimiento.IdSeguimiento = ID
        objSeguimiento.IdCliente = cbCliente.EditValue
        objSeguimiento.Empresa = EmpresaActual
        objSeguimiento.FechaLlamada = FechaLlamada.DateTime.Date
        objSeguimiento.FechaPago = FechaPago.DateTime.Date
        objSeguimiento.Acuerdo = Acuerdo.Text
        objSeguimiento.Descripcion = Comentario.Text
        objSeguimiento.Saldo = lblSaldo.Text
        objSeguimiento.HoraPago = HoraPago.EditValue

        If ID = 0 Then
            dbSeguimiento.Insertar(objSeguimiento)
        Else
            dbSeguimiento.Actualizar(objSeguimiento)
        End If
        '
        Ok = True
        Close()
    End Sub

    Private Sub cbCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cbCliente.EditValueChanged
        If cbCliente.EditValue Is Nothing Then Exit Sub
        '
        lblSaldo.Text = CDbl(dbSeguimiento.Saldo(cbCliente.EditValue, EmpresaActual)).ToString("n2")

        'ObtieneDatos("SELECT dbo.fn_GetSaldoClienteUSD(" + cbCliente.EditValue + "," + EmpresaActual + ");").Rows.Item(0)(0)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Ok = False
        Close()
    End Sub

    Private Sub frmListaNegraAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Ok = False
            Close()
        End If
    End Sub
End Class