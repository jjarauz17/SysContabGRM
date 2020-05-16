Imports System.Net
Imports Entities
Imports System.Net.Mail
Imports System.Data.SqlClient
Public Class db_EnviarCorreo
    Inherits ClComun

    Public Sub EstadoDeCuenta(Adjunto As String,
                              Email_Para As String,
                              Corte As Date,
                              Asunto As String,
                              NombreCliente As String,
                              DT_CC As DataTable,
                              IdSucursal As String)

        Dim obj As New BitacoraEnvioEC
        Dim db As New db_BitacoraEnvioEC

        Try

            'Dim DT As DataTable = ObtieneDatos("SELECT cc.Correo FROM CorreoCopia AS cc WHERE cc.IdCorreo = 1 AND cc.Empresa = " & EmpresaActual)

            'If DT.Rows.Count = 0 Then
            '    XtraMsg("No se Encontra Configurado La Copia del Correo!", MessageBoxIcon.Error)
            '    Exit Sub
            'End If

            Dim DT_CRED As DataTable = ObtieneDatos("JAR_GetCredecialesEnvioCorreo",
                                                    EmpresaActual,
                                                    1,
                                                    IdSucursal)

            If DT_CRED.Rows.Count = 0 Then
                XtraMsg("No se Encuentran Configuradas las Credenciales de Envio de Correo para este Usuario", MessageBoxIcon.Error)
                Exit Sub
            End If

            'Datos para Bitacora
            obj.Empresa = EmpresaActual
            obj.MailTo = Email_Para
            obj.Asunto = Asunto
            obj.Cliente = NombreCliente
            obj.AlCorte = Corte
            obj.Sucursal = IdSucursal
            obj.Adjunto = Adjunto
            obj.ErrorMsg = String.Empty
            obj.Enviado = 1

            Using mm As New MailMessage()

                mm.From = New MailAddress(
                    DT_CRED.Rows.Item(0)("Correo").ToString,
                    Usr_Nombre,
                    System.Text.Encoding.UTF8)

                mm.To.Add(Email_Para)

                'Copiarle al Usuario, que envia
                If Usr_Mail.Trim.Length > 0 Then mm.Bcc.Add(Usr_Mail)

                For i As Integer = 0 To DT_CC.Rows.Count - 1
                    If DT_CC.Rows.Item(i)("Enviar") Then mm.Bcc.Add(DT_CC.Rows.Item(i)("Correo"))
                Next

                mm.Subject = Asunto

                mm.Body = "<p style=" & "FONT-WEIGHT: bold; FONT-SIZE: 10px; COLOR: navy; FONT-FAMILY: Verdana, Arial" & "> " & "Estimado Cliente Sr(a) : " & NombreCliente & "<br>" _
                                & " Le informomos de su Estado de Cuenta a la Fecha de Corte: " & Corte.Date.ToShortDateString & " <br><br> " _
                                & " <br> Un Cordial saludo, <br> " _
                                & " Departamento de Cartera y Cobro <br>" _
                                & " " & NombreEmpresaActual & " <br><br></p>"

                Dim FileAdjuntar As New System.Net.Mail.Attachment(Adjunto)
                mm.Attachments.Add(FileAdjuntar)

                mm.IsBodyHtml = True
                Dim smtp As New SmtpClient()
                smtp.Host = DT_CRED.Rows.Item(0)("smtp").ToString
                smtp.EnableSsl = DT_CRED.Rows.Item(0)("Seguridad")

                Dim NetworkCred As New NetworkCredential(
                    DT_CRED.Rows.Item(0)("Correo").ToString,
                    DT_CRED.Rows.Item(0)("Clave").ToString)
                smtp.UseDefaultCredentials = True
                smtp.Credentials = NetworkCred
                smtp.Port = DT_CRED.Rows.Item(0)("Puerto")
                smtp.Send(mm)

            End Using

            XtraMsg("Correo enviado Exitoso!")

            db.Insertar(obj)
        Catch ex As Exception

            XtraMsg("ERROR: " & ex.Message)
            obj.ErrorMsg = ex.Message
            obj.Enviado = 0
            db.Insertar(obj)

            SendEmail(ex.Message)
        End Try

    End Sub

    Public Function Test(Asunto As String,
                         Envia As String,
                         Clave As String,
                         Salida As String,
                         Seguridad As Boolean,
                         Puerto As Integer) As Boolean
        Try

            Using mm As New MailMessage()

                mm.To.Add(Usr_Mail)
                mm.From = New MailAddress(Envia, "Informática, Dpto. Análisis y Desarrollo!", System.Text.Encoding.UTF8)
                mm.Subject = Asunto

                mm.Body = "<p style=" & "FONT-WEIGHT: bold; FONT-SIZE: 10px; COLOR: navy; FONT-FAMILY: Verdana, Arial" & "> " & "Estimado Usuario : " & Login & "<br>" _
                                & " Si puede Leer este Correo, la prueba se realizo de forma exitosa.<br><br> " _
                                & " <br> Un Cordial saludo, <br> " _
                                & " Departamento de Informatica <br></p>"


                mm.IsBodyHtml = True
                Dim smtp As New SmtpClient()
                smtp.Host = Salida
                smtp.EnableSsl = Seguridad
                Dim NetworkCred As New NetworkCredential(Envia, Clave)
                smtp.UseDefaultCredentials = True
                smtp.Credentials = NetworkCred
                smtp.Port = Puerto
                smtp.Send(mm)
            End Using

            XtraMsg("Envío Exitoso!")

            Return True
        Catch ex As Exception
            XtraMsg("ERROR: " & ex.Message)
            SendEmail(ex.Message)

            Return False
        End Try

    End Function

    Public Function Test_Send_db_mail(Perfil As String, Correo As String, cc As String, Asunto As String) As Boolean
        Try
            Dim Body As String = "<p style=" & "FONT-WEIGHT: bold; FONT-SIZE: 10px; COLOR: navy; FONT-FAMILY: Verdana, Arial" & "> " & "Estimado Usuario : " & Login & "<br>" _
                               & " Si puede Leer este Correo, la prueba se realizo de forma exitosa.<br><br> " _
                               & " <br> Un Cordial saludo, <br> " _
                               & " Departamento de Informática <br></p>"

            ObtieneDatos("JAR_sp_send_dbmail", Perfil, Correo, cc, Asunto, Body)

            XtraMsg("Envío Exitoso!")

            Return True
        Catch ex As Exception
            XtraMsg("ERROR: " & ex.Message, MessageBoxIcon.Error)

            Return False
        End Try
    End Function

End Class
