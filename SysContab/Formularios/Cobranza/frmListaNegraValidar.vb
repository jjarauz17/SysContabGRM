Imports Entities

Public Class frmListaNegraValidar

    Public Ok As Boolean = False,
        IdCliente As Integer = 0,
        ClienteN As String = String.Empty,
        Factura As String = String.Empty,
        IdSucursal As String = String.Empty,
        TipoAprobacion As String = String.Empty

    Dim obj As New ClientesListaNegraAprobacion,
        db As New db_ClientesListaNegraAprobacion,
        DT_CRED As New DataTable("Credenciales"),
        DT_COMITE As New DataTable("ComiteCredito")

    Private Sub frmListaNegraValidar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DT_CRED =
            ObtieneDatos("JAR_GetCredecialesEnvioCorreo",
                               EmpresaActual,
                               1,
                               IdSucursal,
                               "ln")

        If DT_CRED.Rows.Count = 0 Then
            Ok = False
            XtraMsg("No se ha configurado ninguna cuenta de correo para el envio en este proceso", MessageBoxIcon.Error)
            Close()
            Exit Sub
        End If

        DT_COMITE =
            ObtieneDatos("sp_sel_ClientesComiteCredito", 0, EmpresaActual)

        SearchLookUp(
            cbComite,
            DT_COMITE,
            "Nombre",
            "IdUsuario", 0)

        If DT_COMITE.Rows.Count = 0 Then
            Ok = False
            XtraMsg("No se ha definido los usuarios que conforman el Comite de Credito", MessageBoxIcon.Error)
            Close()
            Exit Sub
        End If

        txtCodigo.Focus()

        If TipoAprobacion = "Lista Negra" Then
            lyTitulo.Text = $"Advertencia, Cliente en {TipoAprobacion}!"
        ElseIf TipoAprobacion = "Limite Credito" Then
            lyTitulo.Text = $"Advertencia, {TipoAprobacion}!"
        ElseIf TipoAprobacion = "Facturas Vencidas" Then
            lyTitulo.Text = $"Advertencia, {TipoAprobacion}!"
        ElseIf TipoAprobacion = "Cuotas Factura" Then
            lyTitulo.Text = $"Advertencia, Aumento de Cuotas"
        End If

        HyperlinkLabelControl1.Text = $"Solicitar Código de Aprobación
Una vez enviado, el codigo tendra una validez de {DT_CRED.Rows.Item(0)("Minutos").ToString()} Minutos."
    End Sub

    Private Sub frmListaNegraValidar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Ok = False
            Close()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If Validar() Then

            If cbComite.EditValue Is Nothing Then
                XtraMsg("Debe seleccionar quien de los miembros del comite, realizó la apobración!", MessageBoxIcon.Warning)
                cbComite.Focus()
                Exit Sub
            End If

            Ok = True
            Close()
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Ok = False
        Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Validar()
    End Sub

    Function Validar() As Boolean
        If txtCodigo.Text.Trim.Length < 8 Then
            XtraMsg("Codigo inválido!", MessageBoxIcon.Error)
            txtCodigo.Focus()
            txtCodigo.SelectAll()
            Ok = False
            Return False
        End If
        '
        obj = db.Detalles(
                IdCliente,
                Factura,
                TipoAprobacion,
                EmpresaActual)

        If obj Is Nothing Then
            XtraMsg("Debe solicitar primero el código de aprobación!",
                    MessageBoxIcon.Warning)
            txtCodigo.Focus()
            txtCodigo.SelectAll()
            Ok = False
            Return False
        End If
        '
        Dim DifMin As Integer =
            DateDiff(DateInterval.Minute, obj.Fecha_Envio, VB.SysContab.Rutinas.Fecha())
        Dim ValidezMin As Integer = DT_CRED.Rows.Item(0)("Minutos")

        If DifMin > ValidezMin Then
            XtraMsg($"El Codigo de aprobación ha vencido, se envió al siguiente correo : {DT_CRED.Rows.Item(0)("ListaNegraMail")} hace {DifMin.ToString} Minutos.
                      Favor solicitar un nuevo codigo de aprobación", MessageBoxIcon.Warning)
            Ok = False
            txtCodigo.Focus()
            txtCodigo.SelectAll()
            Return False
        Else
            If txtCodigo.Text.Trim.Equals(obj.Codigo) Then
                XtraMsg("Codigo de Aprobación válido!")
                Return True
            Else
                Ok = False
                XtraMsg("Codigo de Aprobación Inválido!", MessageBoxIcon.Warning)
                Return False
            End If
        End If
    End Function

    Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl1.Click

        obj = db.Detalles(
                IdCliente,
                Factura,
                TipoAprobacion,
                EmpresaActual)

        'If DT_CRED.Rows.Count = 0 Then
        '    Ok = False
        '    XtraMsg("No se ha configurado ninguna cuenta de correo para este proceso.", MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        '
        Dim MailTo As String = String.Empty 'DT_CRED.Rows.Item(0)("ListaNegraMail")
        Dim ValidezMin As Integer = DT_CRED.Rows.Item(0)("Minutos")

        For i As Integer = 0 To DT_COMITE.Rows.Count - 1
            MailTo = MailTo + DT_COMITE.Rows.Item(i)("Correo").ToString() + ","
        Next

        'If MailTo.Trim.Length = 0 Then
        '    Ok = False
        '    XtraMsg("No se ha configurado el correo de envio para este proceso.", MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        If Not obj Is Nothing Then
            Dim DifMin As Integer = DateDiff(DateInterval.Minute, obj.Fecha_Envio, VB.SysContab.Rutinas.Fecha())
            '
            If DifMin > ValidezMin Then
                If XtraMsg2($"El Codigo de aprobación ha vencido, se envió al siguiente correo : {MailTo} hace {DifMin.ToString} Minutos.
                              Desea Solicitar un nuevo Codigo de Aprobación?") Then
                    EnviarCodigo()
                Else
                    Ok = False
                    Exit Sub
                End If
            End If
        Else
            'Enviar Correo.
            EnviarCodigo()
        End If
    End Sub

    Sub EnviarCodigo()

        Dim db_Mail As New db_EnviarCorreo
        Dim Codigo As String =
            ObtieneDatos("sp_sel_GetCodigoAprobacion", 0).Rows.Item(0)("Codigo")

        With DT_CRED

            Dim MsgMail As String =
                db_Mail.EnviarCodigoAprobacion(
                .Rows.Item(0)("ListaNegraMail"),
                .Rows.Item(0)("ListaNegraCc"),
                ClienteN,
                .Rows.Item(0)("Correo"),
                .Rows.Item(0)("Clave"),
                .Rows.Item(0)("Smtp"),
                .Rows.Item(0)("Seguridad"),
                .Rows.Item(0)("Puerto"),
                Codigo,
                DT_CRED.Rows.Item(0)("Minutos"),
                TipoAprobacion,
                DT_COMITE)

            If obj Is Nothing Then
                obj = New ClientesListaNegraAprobacion()
            End If

            obj.IdCliente = IdCliente
            obj.Empresa = EmpresaActual
            obj.Factura = Factura
            obj.Codigo = Codigo
            obj.CorreoEnviado = IIf(MsgMail.Equals("Enviado"), 1, 0)
            obj.ErrorEnvio = MsgMail
            obj.MailTo = .Rows.Item(0)("ListaNegraMail")
            obj.Tipo = TipoAprobacion

            db.Insertar(obj)

            If MsgMail.Equals("Enviado") Then
                XtraMsg($"El Codigo de aprobación se ha enviado con éxito al siguiente correo: { .Rows.Item(0)("ListaNegraMail")}")
            Else
                XtraMsg(MsgMail, MessageBoxIcon.Error)
            End If

        End With

    End Sub


End Class