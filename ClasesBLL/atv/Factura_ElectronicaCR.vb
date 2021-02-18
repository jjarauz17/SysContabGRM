Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Sockets
Imports System.Text
Imports Newtonsoft.Json.Linq

Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports DevExpress.ReportServer.ServiceModel
Imports System.Xml

Imports ClasesBLL
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Factura_ElectronicaCR

    Dim obj As New IDP_FacturaElectronica

    Public Function AutenticacionToken() As DataTable

        obj = IDP_FacturaElectronicaToken.Detalles()

        Dim client As HttpClient = New HttpClient
        client.DefaultRequestHeaders.Accept.Add(New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        Dim urlEncodedList As New List(Of KeyValuePair(Of String, String))

        urlEncodedList.Add(New KeyValuePair(Of String, String)("grant_type", "password"))
        urlEncodedList.Add(New KeyValuePair(Of String, String)("username", obj.Usuario))
        urlEncodedList.Add(New KeyValuePair(Of String, String)("password", obj.Password))
        urlEncodedList.Add(New KeyValuePair(Of String, String)("client_id", obj.IDP_CLIENT_ID))

        Dim content As New FormUrlEncodedContent(urlEncodedList)
        'content.Headers.ContentType = New Headers.MediaTypeHeaderValue("application/x-www-form-urlencoded")  'not sure if i need this
        Dim response As HttpResponseMessage = client.PostAsync(New Uri(obj.IDP_URI), content).Result()

        If response.IsSuccessStatusCode Then
            ' XtraMsg(response.Content.ReadAsStringAsync().Result())

            Return GetDatosJson(response.Content.ReadAsStringAsync().Result())
        Else
            XtraMsg("Error de Token." & vbCrLf & response.Content.ReadAsStringAsync().Result(), Windows.Forms.MessageBoxIcon.Error)
            Return Nothing
        End If

    End Function

    Public Function EnviarComprobante(Factura As String,
                                      Tipo As String,
                                      Etiqueta As String,
                                      FechaEmision As DateTime,
                                      Razon As String,
                                      IdNota As Integer,
                                      Optional SinReceptor As Integer = 0) As Comunicacion


        ShowSplash("Firmando XML...")        
        '
        obj = IDP_FacturaElectronicaToken.Detalles()

        If SinReceptor = 1 Then Etiqueta = "TiqueteElectronico"

        Dim DT As DataTable = New DataTable("Datos_XML")

        If Tipo.Equals("01") Then
            DT = GetDatosFacturaFE(
            Factura,
            Tipo,
            SinReceptor)
        ElseIf Tipo.Equals("03") Then
            DT = GetDatosFacturaNC(
            Factura,
            Tipo,
            IdNota,
            FechaEmision,
            Razon)
        ElseIf Tipo.Equals("09") Then
            DT = GetDatosFacturaFEE(
            Factura,
            Tipo)
        End If
        '        
        Dim xDoc As XDocument = JsonConvert.DeserializeXNode(
            DT.Rows.Item(0)("JsonEnviar"),
            Etiqueta,
            True)

        Dim XmlEnviar As String = xDoc.ToString.Replace("<" + Etiqueta + ">", DT.Rows.Item(0)("EncabezadoFE"))
        XmlEnviar = XmlEnviar.Replace("</MedioPago>", "</MedioPago><DetalleServicio>")
        XmlEnviar = XmlEnviar.Replace("<ResumenFactura>", "</DetalleServicio><ResumenFactura>")
        XmlEnviar = XmlEnviar.Replace("<LineaDetalle json:Array=""true"" xmlns:json=""http://james.newtonking.com/projects/json"">", "<LineaDetalle>")
        '
        Dim directorio As String = obj.DirectorioATV
        Dim nombreArchivo As String = DT.Rows.Item(0)("numeracion_ver")

        Dim xmlDocSF As New Xml.XmlDocument
        xmlDocSF.LoadXml(XmlEnviar)

        Dim EmisorNumero As String = xmlDocSF.GetElementsByTagName("Emisor")(0)("Identificacion")("Numero").InnerText
        Dim EmisorTipo As String = xmlDocSF.GetElementsByTagName("Emisor")(0)("Identificacion")("Tipo").InnerText
        '
        'Guardar XmlEnviado
        xmlDocSF.Save(directorio & nombreArchivo & "_XML_SinFirma.xml")
        ''Dim xmlTextWriter As New Xml.XmlTextWriter(directorio & nombreArchivo & "_01_SF.xml", New System.Text.UTF8Encoding(False))
        ''xmlDocSF.WriteTo(xmlTextWriter)
        ''xmlTextWriter.Close()
        'xmlDocSF = Nothing

        'La ruta donde se encuentra el Certificado
        Dim certificado As String = obj.RutaCertificado

        'If rbCertInstalado.Checked Then
        '    certificado = txtThumbprint.Text
        'Else
        '    certificado = txtPathCertificado.Text
        'End If

        Dim _firma As New ApiHacienda.Firma
        _firma.FirmaXML_Xades(
            directorio & nombreArchivo,
            certificado,
            False,
            obj.PIN,
            obj.FirmaUrl)

        If Not _firma.iError.Equals("Ok") Then
            XtraMsg(_firma.iError, MessageBoxIcon.Error)
            Return Nothing
        End If

        Dim xmlElectronica As New Xml.XmlDocument
        xmlElectronica.Load(directorio & nombreArchivo & "_XML_Firmado.xml")

        Dim txtXMLFirmado As String = xmlElectronica.OuterXml

        Dim myEmisor As New Emisor With {.numeroIdentificacion = EmisorNumero, .TipoIdentificacion = EmisorTipo}

        'Preparando la Entidad Receptor
        'Validando que el Numero de RUC del receptor este creado
        Dim myReceptor As New Receptor

        If SinReceptor Then
            myReceptor.sinReceptor = True
        Else
            Dim ReceptorNumero As String = String.Empty,
                ReceptorTipo As String = String.Empty

            'Para las facturas de Exportacion, solo llevan el nombre del receptor.
            If Not Tipo.Equals("09") Then
                ReceptorNumero = IIf(Tipo.Equals("09"), "", xmlDocSF.GetElementsByTagName("Receptor")(0)("Identificacion")("Numero").InnerText)
                ReceptorTipo = IIf(Tipo.Equals("09"), "", xmlDocSF.GetElementsByTagName("Receptor")(0)("Identificacion")("Tipo").InnerText)
            End If

            myReceptor = New Receptor With {.numeroIdentificacion = ReceptorNumero, .TipoIdentificacion = ReceptorTipo}
        End If
        '
        'Preparando la Entidad Recepcion
        Dim myRecepcion As New Recepcion
        myRecepcion.emisor = myEmisor
        myRecepcion.receptor = myReceptor

        myRecepcion.clave = DT.Rows.Item(0)("Clave")
        myRecepcion.fecha = DT.Rows.Item(0)("FechaEmision")
        ''Now.ToString("yyyy-MM-ddTHH:mm:sszzz")
        myRecepcion.comprobanteXml = Funciones.EncodeStrToBase64(xmlElectronica.OuterXml)
        'xmlElectronica = Nothing
        'Dim Token As String = getToken(obj.Usuario, obj.Password, obj.IDP_CLIENT_ID, obj.IDP_URI)
        HideSplash()
        '
        ShowSplash("Solicitando Token...")
        Dim iToken As New ApiHacienda.TokenHacienda
        iToken.GetTokenHacienda(
            obj.Usuario,
            obj.Password,
            obj.IDP_CLIENT_ID,
            obj.IDP_URI)
        HideSplash()
        '
        If Not iToken.iError.Equals("Ok") Then
            XtraMsg(iToken.iError, MessageBoxIcon.Error)
            Return Nothing
        End If

        ShowSplash("Enviando Solicitud...")
        '
        Dim enviaFactura As New Comunicacion
        enviaFactura.EnvioDatos(
            iToken.accessToken,
            myRecepcion,
            obj.APIUrl)
        '
        HideSplash()
        '
        'Devolver el Numero Consecutivo.
        enviaFactura.Consecutivo = DT.Rows.Item(0)("numeracion_ver")

        'Dim _dt As DataTable = GetDatosJson(enviaFactura.jsonRespuesta)

        Dim jsonEnvio As String = ""
        jsonEnvio = enviaFactura.jsonEnvio

        Dim jsonRespuesta As String = ""
        jsonRespuesta = enviaFactura.jsonRespuesta

        Dim outputFile As New IO.StreamWriter(directorio & nombreArchivo & "_03_jsonEnvio.txt")
        outputFile.Write(jsonEnvio)
        outputFile.Close()

        outputFile = New IO.StreamWriter(directorio & nombreArchivo & "_04_jsonRespuesta.txt")
        outputFile.Write(jsonRespuesta)
        outputFile.Close()
        '        
        'Si la respuesta de Hacienda viene Vacia, significa que se esta consultando, "en proceso".
        If Not IsNothing(enviaFactura.xmlRespuesta) Then
            ShowSplash("Actualizando Respuesta...")
            'Me.txtRespuestaHacienda.Text = enviaFactura.xmlRespuesta.OuterXml
            'XtraMsg(enviaFactura.xmlRespuesta.OuterXml.ToString())
            enviaFactura.xmlRespuesta.Save(directorio & nombreArchivo & "_05_RESP.xml")
            'Dim msg As String = enviaFactura.xmlRespuesta.GetElementsByTagName("MensajeHacienda")(0)("DetalleMensaje").InnerText

            'Actualizar Xml en la Tabla Auxiliar
            FacturaElectronicaXML(Factura,
                                  xmlDocSF.OuterXml,
                                  xmlElectronica.OuterXml,
                                  enviaFactura.xmlRespuesta.OuterXml,
                                  DT.Rows.Item(0)("numeracion_ver"))

            FacturaElectronicaUpdateEstado(Factura,
                                           enviaFactura.estadoFactura,
                                           enviaFactura.mensajeRespuesta,
                                           iToken.accessToken,
                                           DT.Rows.Item(0)("numeracion_ver"))

            HideSplash()
            XtraMsg(enviaFactura.mensajeRespuesta)

            'Return enviaFactura.estadoFactura
            Return enviaFactura

            'If Not IsNothing(enviaFactura.estadoFactura) Then
            'Else
            '    If enviaFactura.statusCode = "400" Then
            '        XtraMsg("La Clave no esta registrada", Windows.Forms.MessageBoxIcon.Error)
            '    End If
            'End If
        Else
            ShowSplash("Actualizando Respuesta...")
            outputFile = New IO.StreamWriter(directorio & nombreArchivo & "_05_RESP_SinRespuesta.txt")

            If enviaFactura.estadoFactura Is Nothing Or
                enviaFactura.estadoFactura = String.Empty Then
                outputFile.Write("Sin Respuesta de Haciendo.... Intentar de nuevo. Estado procesando")
            Else
                outputFile.Write(enviaFactura.mensajeRespuesta)
            End If


            outputFile.Close()

            'Dim msg As String = enviaFactura.xmlRespuesta.GetElementsByTagName("MensajeHacienda")(0)("DetalleMensaje").InnerText

            'ActualizarFacturaXML(Factura, xmlDocSF, txtXMLFirmado, enviaFactura.estadoFactura,
            '                     enviaFactura.mensajeRespuesta, iToken.accessToken,
            '                     DT.Rows.Item(0)("numeracion_ver"))

            'Guardar Datos en Tabla Auxiliar
            FacturaElectronicaXML(Factura,
                                  xmlDocSF.OuterXml,
                                  xmlElectronica.OuterXml,
                                  Nothing,
                                  DT.Rows.Item(0)("numeracion_ver"))

            FacturaElectronicaUpdateEstado(Factura,
                                           enviaFactura.estadoFactura,
                                           enviaFactura.mensajeRespuesta,
                                           iToken.accessToken,
                                           DT.Rows.Item(0)("numeracion_ver"))

            HideSplash()
            '
            XtraMsg("Consulte en unos minutos, factura se está procesando." & vbCrLf &
                    enviaFactura.mensajeRespuesta & vbCrLf & vbCrLf &
                    "Favor Consulte el estado de la Factura electrónica por Clave.")

            'Return enviaFactura.estadoFactura
            Return enviaFactura
        End If

    End Function

    Public Function EnviarComprobanteNC(Factura As String,
                                      Tipo As String,
                                      Etiqueta As String,
                                      FechaEmision As DateTime,
                                      Razon As String) As Comunicacion

    End Function


    Public Function ConsultarComprobante(Factura As String,
                                         Tipo As String) As Comunicacion

        Dim fvXml As New FacturaXML
        Dim obj As New IDP_FacturaElectronica

        Dim EsAccessToken As Boolean = True

        fvXml.Detalle(
            Factura,
            Tipo)

        obj = IDP_FacturaElectronicaToken.Detalles()

        'ShowSplash("Solicitando Token Zoho...")
        'Dim zToken As New TokenZoho
        'zToken.GetToken()
        'HideSplash()
        'zToken.GetTokenZoho("1000.M3KVJYH8KBVJ16952AL7IPXOK94M2H",
        '                    "6c9bb485c8909b02dbb2972cda89a4c71e767543e6",
        '                    "",
        '                    "1000.49d4ca8716dde7c01ea19ac201e277d6.e07bf0dc747614428e7593f221d26566",
        '                    "https://accounts.zoho.com/oauth/v2/token")


        ShowSplash("Solicitando Token...")
        'Token Vencido, Usar el Refresh token.                
        Dim iToken As New ApiHacienda.TokenHacienda
        iToken.GetTokenHacienda(obj.Usuario,
                                obj.Password,
                                obj.IDP_CLIENT_ID,
                                obj.IDP_URI)
        HideSplash()
        '
        If Not iToken.iError.Equals("Ok") Then
            XtraMsg(iToken.iError, MessageBoxIcon.Error)
            Return Nothing
        End If

        ShowSplash("Consultando Comprobante...")
        Dim enviaFactura As New Comunicacion
        enviaFactura.ConsultaEstatus(iToken.accessToken,
                                     fvXml.ClaveNumerica,
                                     obj.APIUrl,
                                     obj.DirectorioATV,
                                     fvXml.Consecutivo)
        HideSplash()
        '

        If Not IsNothing(enviaFactura.estadoFactura) Then
            'Actualizar Estado de
            ShowSplash("Actualizando Respuesta...")
            FacturaElectronicaUpdateEstado(Factura,
                                               enviaFactura.estadoFactura,
                                               enviaFactura.mensajeRespuesta,
                                               IIf(EsAccessToken, iToken.accessToken, iToken.refreshToken),
                                               fvXml.Consecutivo)

            If Not IsNothing(enviaFactura.xmlRespuesta) Then
                Dim XmlResp As Object = enviaFactura.xmlRespuesta.InnerXml
                '
                FacturaElectronicaXML(Factura,
                                  Nothing,
                                  Nothing,
                                  XmlResp,
                                  fvXml.Consecutivo)

            End If
            HideSplash()
        End If
        '
        If enviaFactura.estadoFactura.Equals("sin respuesta") Then
            XtraMsg("Errores encontrados al consultar comprobante, favor volver enviarlo." & vbCrLf &
                    enviaFactura.mensajeRespuesta,
                    MessageBoxIcon.Error)
        End If

        If (enviaFactura.estadoFactura Is Nothing Or
                enviaFactura.estadoFactura.Equals("sin respuesta")) Then Return Nothing

        Return enviaFactura
    End Function



    'Public Function getToken(usuario As String, password As String, cliente_id As String, url As String) As String
    '    Try
    '        Dim iTokenHacienda As New TokenHacienda
    '        iTokenHacienda.GetTokenHacienda(usuario, password, url, cliente_id)
    '        Return iTokenHacienda.accessToken
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Function

    'Public Function getTokenRefresh(usuario As String, password As String, cliente_id As String, url As String) As String
    '    Try
    '        Dim iTokenHacienda As New TokenHacienda
    '        iTokenHacienda.GetTokenHacienda(usuario, password, url, cliente_id)
    '        Return iTokenHacienda.refreshToken
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Function


    Public Sub Genera_XML(Factura As String, Tipo As String)

        '    'Dim sURL As String = "http://97.74.229.192/cr/comprobar_test.php?clave_ver=50616041800310166317600100001010000000010100255039&cod_cliente=14"

        '    'URL del WebServices
        '    'Dim sURL As String = "http://97.74.229.192/cr/genera_xml_test2.php"

        '    'Dim sURL As String = "http://97.74.229.192/cr/genera_xml_cr_test2.php"

        '    'Traer los Datos de la Factura
        '    Dim DT As DataTable = GetDatosFactura(Factura, Tipo)
        '    'Dim articulos_info As String = GetArticulosInfo(Factura)

        '    If DT.Rows.Count = 0 Then

        '        'Dim clave_ver As String = DT.Rows.Item(0)("Clave")
        '        'Dim numeracion_ver As String = DT.Rows.Item(0)("numeracion_ver")
        '        'Dim Cod_Cliente As Integer = DT.Rows.Item(0)("cod_cliente")
        '        'Dim sJson As String = DT.Rows.Item(0)("Json")
        '        'sURL = DT.Rows.Item(0)("URL")
        '        '
        '        'Dim emisor As String = DT.Rows.Item(0)("Emisor")
        '        'Dim receptor As String = DT.Rows.Item(0)("Receptor")
        '        'Dim ResumenFactura As String = DT.Rows.Item(0)("ResumenFactura")
        '        'Dim cod_cliente As String = DT.Rows.Item(0)("cod_cliente")
        '        'Dim CondicionVenta As String = DT.Rows.Item(0)("CondicionVenta")
        '        'Dim PlazoCredito As String = DT.Rows.Item(0)("PlazoCredito")
        '        'Dim MedioPago As String = DT.Rows.Item(0)("MedioPago")

        '        XtraMsg("No se encuentra información para esta factura, favor consultar con el administrador del sistema",)
        '        'Return "Error"
        '    End If

        '    Dim sURL As String = DT.Rows.Item(0)("wsUrl")

        '    Dim client As HttpClient = New HttpClient
        '    client.DefaultRequestHeaders.Accept.Add(New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        '    'Dim content As HttpContent = New StringContent("grant_type=password&username=" & mAccessUserName & "&password=" & mAccessPassword)
        '    Dim urlEncodedList As New List(Of KeyValuePair(Of String, String))

        '    urlEncodedList.Add(New KeyValuePair(Of String, String)("numeracion_ver", DT.Rows.Item(0)("numeracion_ver")))
        '    urlEncodedList.Add(New KeyValuePair(Of String, String)("clave_ver", DT.Rows.Item(0)("Clave")))
        '    urlEncodedList.Add(New KeyValuePair(Of String, String)("emisor", DT.Rows.Item(0)("Emisor")))
        '    urlEncodedList.Add(New KeyValuePair(Of String, String)("receptor", DT.Rows.Item(0)("Receptor")))
        '    urlEncodedList.Add(New KeyValuePair(Of String, String)("articulos_ifo", DT.Rows.Item(0)("Articulos_info")))
        '    urlEncodedList.Add(New KeyValuePair(Of String, String)("ResumenFactura", DT.Rows.Item(0)("ResumenFactura")))
        '    urlEncodedList.Add(New KeyValuePair(Of String, String)("CondicionVenta", DT.Rows.Item(0)("CondicionVenta")))
        '    urlEncodedList.Add(New KeyValuePair(Of String, String)("PlazoCredito", DT.Rows.Item(0)("PlazoCredito")))
        '    urlEncodedList.Add(New KeyValuePair(Of String, String)("MedioPago", DT.Rows.Item(0)("MedioPago")))
        '    urlEncodedList.Add(New KeyValuePair(Of String, String)("cod_cliente", DT.Rows.Item(0)("cod_cliente")))
        '    urlEncodedList.Add(New KeyValuePair(Of String, String)("interno", DT.Rows.Item(0)("Interno")))

        '    Dim content As New FormUrlEncodedContent(urlEncodedList)
        '    'content.Headers.ContentType = New Headers.MediaTypeHeaderValue("application/x-www-form-urlencoded")  'not sure if i need this
        '    Dim response As HttpResponseMessage = client.PostAsync(New Uri(sURL), content).Result()

        '    If response.IsSuccessStatusCode Then

        '        Dim _DT As DataTable = GetDatosJson(response.Content.ReadAsStringAsync().Result())

        '        If _DT.Rows.Count > 0 Then
        '            Dim Estado As String = _DT.Rows.Item(0)("Estado")
        '            If Estado = "aceptado" Then
        '                'Actualizar estado en Encabezado de factura
        '            ElseIf Estado = "procesando" Then
        '                Comprobar(DT.Rows.Item(0)("Clave"), DT.Rows.Item(0)("cod_cliente"), DT.Rows.Item(0)("wsComprobarUrl"))
        '            Else
        '                XtraMsg("El Comprobante ha sido Rechazado" & vbCrLf & "Mensaje: " & _DT.Rows.Item(0)("Mensaje"))
        '            End If

        '            'Return Estado
        '        End If

        '    Else
        '        XtraMsg(response.Content.ReadAsStringAsync().Result.ToString, Windows.Forms.MessageBoxIcon.Error)
        '        'Return "Error"
        '    End If




        '    'XtraMsg(enviaFactura.mensajeRespuesta)
        '    'Dim JsonObject As Newtonsoft.Json.Linq.JObject = New Newtonsoft.Json.Linq.JObject()

        '    'JsonObject.Add(New JProperty("clave", DT.Rows.Item(0)("Clave")))
        '    'JsonObject.Add(New JProperty("FechaEmision", DT.Rows.Item(0)("FechaEmision")))
        '    'JsonObject.Add(New JProperty("emisor", New JObject(New JProperty("tipoIdentificacion", EmisorTipo),
        '    '                                                       New JProperty("numeroIdentificacion", EmisorNumero))))
        '    'If ReceptorNumero.Trim.Length > 1 Then
        '    '    JsonObject.Add(New JProperty("receptor", New JObject(New JProperty("tipoIdentificacion", ReceptorTipo),
        '    '                                                             New JProperty("numeroIdentificacion", ReceptorNumero))))
        '    'End If

        '    'JsonObject.Add(New JProperty("comprobanteXml", myRecepcion.comprobanteXml))
        '    'Dim jsonEnvio As String = JsonObject.ToString

        '    'Dim oString As StringContent = New StringContent(JsonObject.ToString)
        '    'http.DefaultRequestHeaders.Add("authorization", "Bearer " + Token)

        '    'Dim response As HttpResponseMessage = http.PostAsync(obj.APIUrl + "/recepcion", oString).Result
        '    'Dim res As String = response.Content.ReadAsStringAsync.Result


        '    ' Dim http As HttpClient = New HttpClient
        '    ' http.DefaultRequestHeaders.Accept.Add(New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        '    ' Dim urlEncodedList As New List(Of KeyValuePair(Of String, String))

        '    '' urlEncodedList.Add(New KeyValuePair(Of String, String)("authorization", "Bearer " + Token))
        '    ' urlEncodedList.Add(New KeyValuePair(Of String, String)("clave", DT.Rows.Item(0)("Clave")))
        '    ' urlEncodedList.Add(New KeyValuePair(Of String, String)("NumeroConsecutivo", DT.Rows.Item(0)("numeracion_ver")))
        '    ' urlEncodedList.Add(New KeyValuePair(Of String, String)("FechaEmision", DT.Rows.Item(0)("FechaEmision")))
        '    ' urlEncodedList.Add(New KeyValuePair(Of String, String)("emisor", DT.Rows.Item(0)("Emisor")))
        '    ' urlEncodedList.Add(New KeyValuePair(Of String, String)("receptor", DT.Rows.Item(0)("Receptor")))
        '    ' urlEncodedList.Add(New KeyValuePair(Of String, String)("CondicionVenta", DT.Rows.Item(0)("CondicionVenta")))
        '    ' urlEncodedList.Add(New KeyValuePair(Of String, String)("PlazoCredito", DT.Rows.Item(0)("PlazoCredito")))
        '    ' urlEncodedList.Add(New KeyValuePair(Of String, String)("MedioPago", DT.Rows.Item(0)("MedioPago")))
        '    ' urlEncodedList.Add(New KeyValuePair(Of String, String)("DetalleServicio", DT.Rows.Item(0)("Articulos_info")))
        '    ' urlEncodedList.Add(New KeyValuePair(Of String, String)("ResumenFactura", DT.Rows.Item(0)("ResumenFactura")))
        '    ' urlEncodedList.Add(New KeyValuePair(Of String, String)("Signature", myRecepcion.comprobanteXml))

        '    ' Dim content As New FormUrlEncodedContent(urlEncodedList)
        '    ' Dim response As HttpResponseMessage = http.PostAsync(New Uri(obj.APIUrl + "recepcion"), content).Result()

        '    ' If response.IsSuccessStatusCode Then
        '    '     XtraMsg("Ok. " & response.Content.ReadAsStringAsync().Result())
        '    ' Else
        '    '     XtraMsg("Error de Envío." & vbCrLf & response.Content.ReadAsStringAsync().Result(), Windows.Forms.MessageBoxIcon.Error)
        '    ' End If



        '    'Dim sURL As String = "http://97.74.229.192/cr/genera_xml_test.php?clave_ver=" + clave_ver + "&emisor=" + emisor + "&receptor=" + receptor + "&articulos_ifo=" + articulos_info + "&ResumenFactura=" + resumen + "&cod_cliente=" + cod_cliente + ""
        '    'sURL = sURL + "clave_ver=" + clave_ver + "&emisor=" + emisor + "&receptor=" + receptor + "&articulos_ifo=" + articulos_info + "&ResumenFactura=" + resumen + "&cod_cliente=" + cod_cliente + ""



        '    'Dim request As WebRequest = WebRequest.Create(sURL)
        '    'request.Method = "POST"

        '    'Dim objStream As Stream = request.GetRequestStream()

        '    'Dim response As WebResponse = request.GetResponse()

        '    'objStream = response.GetResponseStream()
        '    'Dim reader As New StreamReader(objStream)

        '    'Dim responseFromServer As String = reader.ReadToEnd()

        '    'reader.Close()
        '    'objStream.Close()
        '    'response.Close()
        '    ''
        '    'Return responseFromServer





        '    'Using client = New HttpClient()

        '    '    client.BaseAddress = New Uri(sURL)
        '    '    client.DefaultRequestHeaders.Accept.Clear()
        '    '    client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

        '    '    Dim stringFromObject As String = JsonConvert.SerializeObject(product)
        '    '    Dim content As HttpContent = New StringContent(stringFromObject, Encoding.UTF8, "application/json")

        '    '    content.Headers.Add("YourCustomHeader", "YourParameter")

        '    '    Dim response As HttpResponseMessage = client.PostAsync(url, content).Result
        '    '    If response.IsSuccessStatusCode Then
        '    '        ' do something

        '    '    End If

        '    'End Using



        '    'Dim stringFromObject As String = ""

        '    'Using client = New HttpClient()

        '    '    ' Establecer la url que proporciona acceso al servidor que publica la API
        '    '    client.BaseAddress = New Uri(sURL)
        '    '    ' Configurar encabezados para que la petición de realice en formato JSON
        '    '    client.DefaultRequestHeaders.Accept.Clear()
        '    '    client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

        '    '    Dim content As HttpContent = New StringContent(stringFromObject, Encoding.UTF8, "application/json")

        '    '    'Add headers
        '    '    content.Headers.Add("numeracion_ver", DT.Rows.Item(0)("numeracion_ver"))
        '    '    content.Headers.Add("clave_ver", DT.Rows.Item(0)("Clave"))
        '    '    content.Headers.Add("emisor", DT.Rows.Item(0)("Emisor"))
        '    '    content.Headers.Add("receptor", DT.Rows.Item(0)("Receptor"))
        '    '    content.Headers.Add("articulos_ifo", DT.Rows.Item(0)("Articulos_info"))
        '    '    content.Headers.Add("ResumenFactura", DT.Rows.Item(0)("ResumenFactura"))
        '    '    content.Headers.Add("CondicionVenta", DT.Rows.Item(0)("CondicionVenta"))
        '    '    content.Headers.Add("PlazoCredito", DT.Rows.Item(0)("PlazoCredito"))
        '    '    content.Headers.Add("MedioPago", DT.Rows.Item(0)("MedioPago"))
        '    '    content.Headers.Add("cod_cliente", DT.Rows.Item(0)("cod_cliente"))
        '    '    content.Headers.Add("interno", DT.Rows.Item(0)("Interno"))

        '    '    'client.DefaultRequestHeaders.Add("numeracion_ver", DT.Rows.Item(0)("numeracion_ver"))
        '    '    'client.DefaultRequestHeaders.Add("clave_ver", DT.Rows.Item(0)("Clave"))
        '    '    'client.DefaultRequestHeaders.Add("emisor", DT.Rows.Item(0)("Emisor"))
        '    '    'client.DefaultRequestHeaders.Add("receptor", DT.Rows.Item(0)("Receptor"))
        '    '    'client.DefaultRequestHeaders.Add("articulos_ifo", DT.Rows.Item(0)("Articulos_info"))
        '    '    'client.DefaultRequestHeaders.Add("ResumenFactura", DT.Rows.Item(0)("ResumenFactura"))
        '    '    'client.DefaultRequestHeaders.Add("CondicionVenta", DT.Rows.Item(0)("CondicionVenta"))
        '    '    'client.DefaultRequestHeaders.Add("PlazoCredito", DT.Rows.Item(0)("PlazoCredito"))
        '    '    'client.DefaultRequestHeaders.Add("MedioPago", DT.Rows.Item(0)("MedioPago"))
        '    '    'client.DefaultRequestHeaders.Add("cod_cliente", DT.Rows.Item(0)("cod_cliente"))
        '    '    'client.DefaultRequestHeaders.Add("interno", DT.Rows.Item(0)("Interno"))

        '    '    '
        '    '    'Call client.PostAsJsonAsync to send a POST request to the appropriate URI
        '    '    'Dim response As HttpResponseMessage = Await client.PutAsync()
        '    '    Dim response As HttpResponseMessage = client.PostAsync(sURL, content).Result

        '    '    If response.IsSuccessStatusCode Then
        '    '        XtraMsg("Todo Bien!")
        '    '    End If

        '    '    'Dim response As HttpResponseMessage = client.PostAsJsonAsync(url, product).Result


        '    '    'This method throws an exception if the HTTP response status is an error code.
        '    '    ' Dim error As String = resp.EnsureSuccessStatusCode()

        '    '    'If response.IsSuccessStatusCode Then


        '    '    'Else
        '    '    '    Dim resultado = response.Content.ReadAsStringAsync().Result
        '    '    '    Dim result = JsonConvert.DeserializeObject(Of ResultServer)(resultado)
        '    '    '    Throw New Exception(String.Format("Message:{0}, ExceptionMessage: {1}", result.Message, result.ExceptionMessage))

        '    '    'End If




        '    'End Using



    End Sub

    Public Function Comprobar(clave_ver As String, cod_cliente As Integer, Url As String) As String

        Dim client As HttpClient = New HttpClient
        client.DefaultRequestHeaders.Accept.Add(New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

        'Dim content As HttpContent = New StringContent("grant_type=password&username=" & mAccessUserName & "&password=" & mAccessPassword)
        Dim urlEncodedList As New List(Of KeyValuePair(Of String, String))

        urlEncodedList.Add(New KeyValuePair(Of String, String)("clave_ver", clave_ver))
        urlEncodedList.Add(New KeyValuePair(Of String, String)("cod_cliente", cod_cliente))

        Dim content As New FormUrlEncodedContent(urlEncodedList)
        'content.Headers.ContentType = New Headers.MediaTypeHeaderValue("application/x-www-form-urlencoded")  'not sure if i need this
        Dim response As HttpResponseMessage = client.PostAsync(New Uri(Url), content).Result()
        Dim Estado As String = "null"

        If response.IsSuccessStatusCode Then

            Dim _DT As DataTable = GetDatosJson(response.Content.ReadAsStringAsync().Result())

            If _DT.Rows.Count > 0 Then Estado = _DT.Rows.Item(0)("Estado")

        Else
            XtraMsg(response.Content.ReadAsStringAsync().Result.ToString, Windows.Forms.MessageBoxIcon.Error)
        End If

        Return Estado

    End Function

    'Public Function canLogin() As Boolean

    '    Dim sURL As String = "http://97.74.229.192/cr/genera_xml_cr_test2.php"

    '    Dim client As HttpClient = New HttpClient
    '    client.DefaultRequestHeaders.Accept.Add(
    '        New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

    '    'Dim content As HttpContent = New StringContent("grant_type=password&username=" & mAccessUserName & "&password=" & mAccessPassword)
    '    Dim urlEncodedList As New List(Of KeyValuePair(Of String, String))
    '    urlEncodedList.Add(New KeyValuePair(Of String, String)("grant_type", "password"))
    '    urlEncodedList.Add(New KeyValuePair(Of String, String)("username", mAccessUserName))
    '    urlEncodedList.Add(New KeyValuePair(Of String, String)("password", mAccessPassword))

    '    Dim content As New FormUrlEncodedContent(urlEncodedList)
    '    'content.Headers.ContentType = New Headers.MediaTypeHeaderValue("application/x-www-form-urlencoded")  'not sure if i need this

    '    Dim response As HttpResponseMessage = client.PostAsync(New Uri(sURL), content).Result

    '    If response.IsSuccessStatusCode Then
    '        Return True
    '    Else
    '        Return False
    '    End If


    'End Function


    Public Function GetDatosJson(json As String) As DataTable

        Dim _DT As New DataTable("JsonResult")

        Try

            'Dim json As String = GetJsonResult()

            Dim ser As JObject = JObject.Parse(json)
            Dim data As List(Of JToken) = ser.Children().ToList

            Dim Datos As New ArrayList

            For Each item As JProperty In data

                Dim cl As New DataColumn(item.Name)
                _DT.Columns.Add(cl)

                Datos.Add(item.Value)
            Next

            Dim dr As DataRow = _DT.NewRow()

            For i As Integer = 0 To Datos.Count - 1
                dr(i) = Datos(i).ToString
            Next

            _DT.Rows.Add(dr)


            Return _DT
        Catch ex As Exception
            XtraMsg(ex.Message, Windows.Forms.MessageBoxIcon.Error)
            Return Nothing
        End Try

    End Function

    Public Function GetDatosFacturaFE(Factura As String,
                                     Tipo As String,
                                     SinReceptor As Integer) As DataTable

        Return ObtieneDatos("sp_facturaElectronicaDatos",
                            Factura,
                            Tipo,
                            Now.Date,
                            "n/a",
                            EmpresaA,
                            SinReceptor)      '.Rows.Item(0)("Clave")

    End Function

    Public Function GetDatosFacturaFEE(Factura As String,
                                     Tipo As String) As DataTable

        Return ObtieneDatos("sp_facturaElectronicaDatosFEE",
                            Factura,
                            Tipo,
                            EmpresaA)

    End Function

    Public Function GetDatosFacturaNC(Factura As String,
                                     Tipo As String,
                                     IdNota As Integer,
                                     FechaEmision As DateTime,
                                     Razon As String) As DataTable

        Return ObtieneDatos("sp_facturaElectronicaDatosNC",
                            Factura,
                            Tipo,
                            IdNota,
                            Razon,
                            EmpresaA)

    End Function

    Public Function GetArticulosInfo(Factura As String) As String

        Dim DT As DataTable = ObtieneDatos("sp_FacturaElectronica_GetArticulosInfo", Factura, EmpresaA)

        Dim articulos_info As String = ""

        If DT.Rows.Count > 0 Then
            For i As Integer = 0 To DT.Rows.Count - 1
                articulos_info = articulos_info + "," + DT.Rows.Item(i)("LineaInfo")
            Next

            articulos_info = Mid(articulos_info, 2, Len(articulos_info))
            articulos_info = "{" + articulos_info + "}"

        End If

        Return articulos_info

    End Function


    Public Function ImpresoraFiscalXML(Factura As String, Tipo As Integer, Optional Anular As Boolean = False) As Boolean

        Dim DT_ENCABEZADO As DataTable = ObtieneDatosTN("sp_GetFacturaFiscal", "Mercurio", Factura, Tipo, EmpresaA)
        Dim DT_DETALLE As DataTable = ObtieneDatosTN("sp_GetFacturaFiscalDetalle", "SalesLines", Factura, EmpresaA)
        Dim Ruta As String = ObtieneDatos("sp_ImpresoraFiscalRutaXML", EmpresaA).Rows.Item(0)("Ruta")

        If Ruta = "" Then
            Return True
        End If

        'Dim path As String = Server.MapPath("~/OfertaMarcas.xml")
        Dim path As String = Ruta & "FACT_NO_" & Factura & IIf(Anular, "_DEV", "") & ".xml"

        If File.Exists(path) Then File.Delete(path)

        Dim writer As New XmlTextWriter(path, Encoding.UTF8)

        writer.Formatting = Xml.Formatting.Indented
        writer.WriteStartDocument()

        Try
            writer.WriteStartElement("Mercurio_Invoices")
            writer.WriteStartElement("Mercurio")

            writer.WriteStartElement("Customer_ID")
            writer.WriteValue(DT_ENCABEZADO.Rows.Item(0)("Customer_ID"))
            writer.WriteEndElement()

            writer.WriteStartElement("Customer_Name")
            writer.WriteValue(DT_ENCABEZADO.Rows.Item(0)("Customer_Name"))
            writer.WriteEndElement()

            writer.WriteStartElement("RUC_Cedula")
            writer.WriteValue(DT_ENCABEZADO.Rows.Item(0)("RUC_Cedula"))
            writer.WriteEndElement()

            writer.WriteStartElement("Invoice_Number")
            writer.WriteValue(DT_ENCABEZADO.Rows.Item(0)("Invoice_Number"))
            writer.WriteEndElement()

            writer.WriteStartElement("Invoice_Date")
            writer.WriteValue(DT_ENCABEZADO.Rows.Item(0)("Invoice_Date"))
            writer.WriteEndElement()

            writer.WriteStartElement("Doc_Type")
            writer.WriteValue(DT_ENCABEZADO.Rows.Item(0)("Doc_Type"))
            writer.WriteEndElement()

            writer.WriteStartElement("Salesman_name")
            writer.WriteValue(DT_ENCABEZADO.Rows.Item(0)("Salesman_name"))
            writer.WriteEndElement()

            writer.WriteStartElement("Discount_Amount")
            writer.WriteValue(DT_ENCABEZADO.Rows.Item(0)("Discount_Amount"))
            writer.WriteEndElement()

            writer.WriteStartElement("Discount_Date")
            writer.WriteValue(DT_ENCABEZADO.Rows.Item(0)("Discount_Date"))
            writer.WriteEndElement()

            writer.WriteStartElement("Displayed_Comments")
            writer.WriteValue(DT_ENCABEZADO.Rows.Item(0)("Displayed_Comments"))
            writer.WriteEndElement()

            writer.WriteStartElement("ApplyToInvoiceNumber")
            writer.WriteValue(DT_ENCABEZADO.Rows.Item(0)("ApplyToInvoiceNumber"))
            writer.WriteEndElement()

            writer.WriteStartElement("Total_Amount")
            writer.WriteValue(DT_ENCABEZADO.Rows.Item(0)("Total_Amount"))
            writer.WriteEndElement()

            writer.WriteStartElement("Total_Tax")
            writer.WriteValue(DT_ENCABEZADO.Rows.Item(0)("Total_Tax"))
            writer.WriteEndElement()

            writer.WriteStartElement("Order_No")
            writer.WriteValue(DT_ENCABEZADO.Rows.Item(0)("Order_No"))
            writer.WriteEndElement()

            writer.WriteStartElement("Telefono")
            writer.WriteValue(DT_ENCABEZADO.Rows.Item(0)("Telefono"))
            writer.WriteEndElement()

            writer.WriteStartElement("SalesLines")

            For i As Integer = 0 To DT_DETALLE.Rows.Count - 1
                writer.WriteStartElement("SalesLine")

                writer.WriteStartElement("Item_code")
                writer.WriteValue(DT_DETALLE.Rows.Item(i)("Item_code"))
                writer.WriteEndElement()

                writer.WriteStartElement("item_barcode")
                writer.WriteValue(DT_DETALLE.Rows.Item(i)("item_barcode"))
                writer.WriteEndElement()

                writer.WriteStartElement("Quantity")
                writer.WriteValue(DT_DETALLE.Rows.Item(i)("Quantity"))
                writer.WriteEndElement()

                writer.WriteStartElement("Description")
                writer.WriteValue(DT_DETALLE.Rows.Item(i)("Description"))
                writer.WriteEndElement()

                writer.WriteStartElement("Unit_Price")
                writer.WriteValue(DT_DETALLE.Rows.Item(i)("Unit_Price"))
                writer.WriteEndElement()

                writer.WriteStartElement("Tax_Percent")
                writer.WriteValue(DT_DETALLE.Rows.Item(i)("Tax_Percent"))
                writer.WriteEndElement()

                writer.WriteStartElement("Amount")
                writer.WriteValue(DT_DETALLE.Rows.Item(i)("Amount"))
                writer.WriteEndElement()

                writer.WriteStartElement("Discount")
                writer.WriteValue(DT_DETALLE.Rows.Item(i)("Discount"))
                writer.WriteEndElement()

                writer.WriteStartElement("UOM")
                writer.WriteValue(DT_DETALLE.Rows.Item(i)("UOM"))
                writer.WriteEndElement()
                '
                writer.WriteEndElement()
            Next
            'Cierra SalesLines
            writer.WriteEndElement()
            'Cierra Mercurio_Invoices y Mercurio
            writer.WriteEndElement()
            writer.Close()
            '
            Dim xml As Object = File.ReadAllText(path)

            GuardarFacturaXML(Factura, xml)

            XtraMsg("El XML fue creado y enviado a: " & path)
            Return True
        Catch ex As Exception
            XtraMsg("Errores Encontrados al enviar XML : " & ex.Message, Windows.Forms.MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Sub GuardarFacturaXML(Factura As String, xml As Object)

        Try
            Dim cnn As SqlConnection = New SqlConnection(Conexion())
            Dim cmd As New SqlCommand("sp_ins_FACTURAS_VENTAS_XML")
            cmd.Connection = cnn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Factura", Factura)
            cmd.Parameters.AddWithValue("@Empresa", EmpresaA)
            cmd.Parameters.AddWithValue("@FacturaXML", xml)

            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()
        Catch ex As Exception
            XtraMsg("Error al guardar XML: " & vbCrLf & ex.Message, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub


    Public Sub FacturaElectronicaXML(Factura As String, XmlSinFirma As Object, XmlFirmado As Object, XmlRespuesta As Object, Consecutivo As String)

        Try
            Dim cnn As SqlConnection = New SqlConnection(Conexion())
            Dim cmd As New SqlCommand("sp_upd_FACTURAS_VENTAS_XML")
            cmd.Connection = cnn
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Factura", Factura)
            'cmd.Parameters.AddWithValue("@FacturaXML", XmlSinFirma)
            cmd.Parameters.AddWithValue("@XmlEnviado", XmlSinFirma)
            cmd.Parameters.AddWithValue("@XmlFirmado", XmlFirmado)
            cmd.Parameters.AddWithValue("@XmlRespuesta", XmlRespuesta)
            'cmd.Parameters.AddWithValue("@Estado", Estado)
            'cmd.Parameters.AddWithValue("@Mensaje", Mensaje)
            'cmd.Parameters.AddWithValue("@Token", TK)
            cmd.Parameters.AddWithValue("@Consecutivo", Consecutivo)
            cmd.Parameters.AddWithValue("@Empresa", EmpresaA)

            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()
        Catch ex As Exception
            XtraMsg("Error al guardar XML: " & vbCrLf & ex.Message, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub FacturaElectronicaUpdate(ID As Integer,
                                        FacturaXML As String,
                                        ClaveNumerica As String,
                                        Estado As String,
                                        Mensaje As String,
                                        XMLFirmado As String)

        Try
            Dim cnn As SqlConnection = New SqlConnection(Conexion())
            Dim cmd As New SqlCommand("sp_upd_FACTURAS_VENTAS_XML_GT")
            cmd.Connection = cnn
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@ID", ID)
            cmd.Parameters.AddWithValue("@FacturaXML", FacturaXML)
            cmd.Parameters.AddWithValue("@ClaveNumerica", ClaveNumerica)
            cmd.Parameters.AddWithValue("@Estado", XMLFirmado)
            cmd.Parameters.AddWithValue("@MensajeHacienda", Estado)
            cmd.Parameters.AddWithValue("@XmlFirmado", Mensaje)
            cmd.Parameters.AddWithValue("@Empresa", EmpresaA)

            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()
        Catch ex As Exception
            XtraMsg("Error al Actualizar Tabla, SP: sp_upd_FACTURAS_VENTAS_XML_GT. " & vbCrLf & ex.Message,
                    Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub


    Public Sub FacturaElectronicaUpdateEstado(Factura As String, Estado As String, Mensaje As String, TK As String, Consecutivo As String)

        Try
            Dim cnn As SqlConnection = New SqlConnection(Conexion())
            Dim cmd As New SqlCommand("sp_upd_FACTURAS_VENTAS_XML_Estado")
            cmd.Connection = cnn
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Factura", Factura)
            cmd.Parameters.AddWithValue("@Estado", Estado)
            cmd.Parameters.AddWithValue("@Mensaje", Mensaje)
            cmd.Parameters.AddWithValue("@Consecutivo", Consecutivo)
            cmd.Parameters.AddWithValue("@Token", TK)
            cmd.Parameters.AddWithValue("@Empresa", EmpresaA)

            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()
        Catch ex As Exception
            XtraMsg("Error al Actualizar Estado: " & vbCrLf & ex.Message, Windows.Forms.MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function GetConsecutivo() As Integer

        Return ObtieneDatos("sp_sel_FACTURAS_VENTAS_XML_Consecutivo", EmpresaA).Rows.Item(0)("Numero")

    End Function





End Class
