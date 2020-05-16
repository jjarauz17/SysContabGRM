
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Mail
Imports System.Text
Imports System.Windows.Forms

Public Class db_FacturasElectronicasAceptadas
    Inherits ClComun
    Dim vFacturasElectronicasAceptadasTabla As New FacturasElectronicasAceptadas
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property FacturasElectronicasAceptadasTabla() As FacturasElectronicasAceptadas
        Get
            Return vFacturasElectronicasAceptadasTabla
        End Get
        Set(ByVal value As FacturasElectronicasAceptadas)
            vFacturasElectronicasAceptadasTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Insertar(ByVal FacturasElectronicasAceptadas As FacturasElectronicasAceptadas, Optional Tran As Boolean = False) As Boolean

        Dim result As Boolean = True

        Dim ObjParameter(21) As String
        ObjParameter(0) = EmpresaA
        ObjParameter(1) = FacturasElectronicasAceptadas.Numero
        ObjParameter(2) = FacturasElectronicasAceptadas.Clave
        ObjParameter(3) = FacturasElectronicasAceptadas.Emisor
        ObjParameter(4) = FacturasElectronicasAceptadas.CedulaEmisor
        ObjParameter(5) = FacturasElectronicasAceptadas.FechaEmision
        ObjParameter(6) = FacturasElectronicasAceptadas.FechaEnvio
        ObjParameter(7) = FacturasElectronicasAceptadas.Mensaje
        ObjParameter(8) = FacturasElectronicasAceptadas.MensajeDetalle
        ObjParameter(9) = FacturasElectronicasAceptadas.TotalImpuesto
        ObjParameter(10) = FacturasElectronicasAceptadas.TotalFactura
        ObjParameter(11) = FacturasElectronicasAceptadas.Receptor
        ObjParameter(12) = FacturasElectronicasAceptadas.CedulaReceptor
        ObjParameter(13) = FacturasElectronicasAceptadas.Consecutivo
        ObjParameter(14) = FacturasElectronicasAceptadas.StatusCode
        ObjParameter(15) = FacturasElectronicasAceptadas.Respuesta
        ObjParameter(16) = FacturasElectronicasAceptadas.XmlOriginal
        ObjParameter(17) = FacturasElectronicasAceptadas.XmlEnviado
        ObjParameter(18) = FacturasElectronicasAceptadas.XmlFirmado
        ObjParameter(19) = FacturasElectronicasAceptadas.Estado
        ObjParameter(20) = FacturasElectronicasAceptadas.XmlRespuesta
        'ObjParameter(20) = FacturasElectronicasAceptadas.ConsecutivoProveedor

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_FacturasElectronicasAceptadas", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception

            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If

            XtraMsg("Error al Guardar Datos, revisar SP: sp_ins_FacturasElectronicasAceptadas." & vbCrLf & ex.Message, MessageBoxIcon.Error)

            result = False
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If

        End Try

        Return result
    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Actualizar(ByVal FacturasElectronicasAceptadas As FacturasElectronicasAceptadas, Optional Tran As Boolean = False) As Boolean
        Dim ObjParameter(5) As String
        ObjParameter(0) = FacturasElectronicasAceptadas.IdFactura
        ObjParameter(1) = FacturasElectronicasAceptadas.StatusCode
        ObjParameter(2) = FacturasElectronicasAceptadas.Estado
        ObjParameter(3) = FacturasElectronicasAceptadas.Respuesta
        ObjParameter(4) = FacturasElectronicasAceptadas.XmlRespuesta

        Dim result As Boolean = True

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_FacturasElectronicasAceptadas", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If

        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            result = False
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try

        Return result
    End Function


    Public Sub ActualizarProveedor(ByVal FacturasElectronicasAceptadas As FacturasElectronicasAceptadas,
                                        Optional Tran As Boolean = False)
        Dim ObjParameter(4) As String
        ObjParameter(0) = FacturasElectronicasAceptadas.IdFactura
        ObjParameter(1) = FacturasElectronicasAceptadas.IdProveedor
        ObjParameter(2) = FacturasElectronicasAceptadas.Factura
        ObjParameter(3) = EmpresaA

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(
                TieneTransaccion.Si,
                "sp_upd_FacturasElectronicasAceptadasProveedor",
                ObjParameter)

            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If

        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Listar(ByVal Id As Integer, Desde As Date, Hasta As Date) As Data.DataTable

        Return ObtieneDatos("sp_sel_FacturasElectronicasAceptadas",
                            Id,
                            Desde,
                            Hasta,
                            EmpresaA)

    End Function

    Public Shared Function Buscar(Xml As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_FacturasElectronicasAceptadasBuscar", Xml, EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function GetConsecutivo(Mensaje As Integer) As String

        Return ObtieneDatos("sp_sel_ConsecutivoReceptor", Mensaje, EmpresaA).Rows.Item(0)("Consecutivo")

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal FacturasElectronicasAceptadas As FacturasElectronicasAceptadas, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = FacturasElectronicasAceptadas.IdFactura
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_FacturasElectronicasAceptadas", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub

    Public Function SendMail(Email As String,
                             Cc As String,
                             Subject As String,
                             Proveedor As String,
                             ClaveEmisor As String,
                             Consecutivo As String,
                             Mensaje As String,
                             Moneda As String,
                             Impuesto As Double,
                             Total As Double,
                             EmpresaN As String,
                             atacht1 As String,
                             atacht2 As String) As String

        Dim _Dt_Credenciales As DataTable = ObtieneDatos("sp_sel_MailCredenciales", EmpresaA)

        Using mm As New MailMessage()

            Dim data1 As New Attachment(atacht1)
            Dim data2 As New Attachment(atacht2)

            mm.From = New MailAddress(_Dt_Credenciales.Rows.Item(0)("Email").ToString(), "Recepción de Factura Electronica!", Encoding.UTF8)
            mm.To.Add(Email)
            If Cc.Length > 0 Then mm.CC.Add(Cc)
            If _Dt_Credenciales.Rows.Item(0)("CCO").ToString().Length > 0 Then mm.Bcc.Add(_Dt_Credenciales.Rows.Item(0)("CCO").ToString())
            If _Dt_Credenciales.Rows.Item(0)("CCO2").ToString().Length > 0 Then mm.Bcc.Add(_Dt_Credenciales.Rows.Item(0)("CCO2").ToString())
            mm.Subject = Subject
            mm.IsBodyHtml = True
            mm.BodyEncoding = Encoding.UTF8
            mm.Attachments.Add(data1)
            mm.Attachments.Add(data2)

            Dim vBody As String = "<html><style>h1{font-size: 12;color: #0a14cc;font-family: tahoma;}" +
            "th{font-family: tahoma;font-size: 12;background-color: #ffff26;color: #0a14cc;border-bottom: 1px solid black;border-top: 1px solid black;border-left: 1px solid black;border-right: 1px solid black;}" +
            "td{font-family:tahoma;font-size: 12;border-bottom: 1px groove black;border-left:1px solid;}" +
            "p{font-size: 12;font-family: tahoma;}" +
            "table{border: 5px;border-color: black;border-style:groove;margin: 0 auto;}" +
            "body{width: 85%;height:85%;margin: 35px;background-attachment: fixed;background-position:center center;background-size: cover;}" +
            "</style><body>"

            vBody = vBody + "<h1>" + _Dt_Credenciales.Rows.Item(0)("Saludo").ToString() + "</h1>" +
                    "<p>Estimado Proveedor: <b> " + Proveedor + "  </b>,<br><br>" +
                    " Su Factura Eletrónica N°: <b> " + ClaveEmisor + "  </b>, ha sido: <b> " + Mensaje + " .</b><br>" +
                    " Con N° de Recepción: <b> " + Consecutivo + "  </b><br>" +
                    " Factura recibida por: <b> " + EmpresaN + "  </b><br>" +
                    " <hr>" +
                    " <br>Impuesto " + Moneda + ": <b> " + Impuesto.ToString("n2") + "</b>" +
                    " <br>Total " + Moneda + ": <b> " + Total.ToString("n2") + "  </b><br><br>" +
                    " <br> <b> <h1> Un Cordial saludo, </h1> </b><br></p></body></html> "

            mm.Body = vBody

            Dim smtp As New SmtpClient()

            smtp.Host = _Dt_Credenciales.Rows.Item(0)("Host").ToString()
            smtp.Port = _Dt_Credenciales.Rows.Item(0)("Puerto")
            smtp.EnableSsl = IIf(_Dt_Credenciales.Rows.Item(0)("EnableSsl") = 1, True, False)

            Dim NetworkCred As New NetworkCredential(_Dt_Credenciales.Rows.Item(0)("Email").ToString(), _Dt_Credenciales.Rows.Item(0)("Password").ToString())
            smtp.UseDefaultCredentials = True
            smtp.Credentials = NetworkCred

            Try
                smtp.Send(mm)

                Return "Ok"
            Catch ex As Exception
                XtraMsg("Error al Enviar Correo Electrónico: " + ex.Message, MessageBoxIcon.Error)
                Return "Error al Enviar Correo Electrónico: " + ex.Message
            End Try

        End Using

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Detalles(ByVal Id As String) As FacturasElectronicasAceptadas
        Dim dt As DataTable = ObtieneDatos("sp_sel_FacturasElectronicasAceptadas", Id)
        Dim det As New FacturasElectronicasAceptadas

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdFactura = .Item("IdFactura")
                det.Empresa = .Item("Empresa")
                det.Numero = .Item("Numero")
                det.Clave = .Item("Clave")
                det.Emisor = .Item("Emisor")
                det.CedulaEmisor = .Item("CedulaEmisor")
                det.FechaEmision = .Item("FechaEmision")
                det.FechaEnvio = .Item("FechaEnvio")
                det.Mensaje = .Item("Mensaje")
                det.MensajeDetalle = .Item("MensajeDetalle")
                det.TotalImpuesto = .Item("TotalImpuesto")
                det.TotalFactura = .Item("TotalFactura")
                det.Receptor = .Item("Receptor")
                det.CedulaReceptor = .Item("CedulaReceptor")
                det.Consecutivo = .Item("Consecutivo")
                det.StatusCode = .Item("Estado")
                det.Respuesta = .Item("Respuesta")
                det.XmlOriginal = .Item("XmlOriginal")
                det.XmlEnviado = .Item("XmlEnviado")
                det.XmlFirmado = .Item("XmlFirmado")
                det.Usuario = .Item("Usuario")
                det.Fecha_Registro = .Item("Fecha_Registro")
            End With
        End If
        Return det
    End Function
End Class
