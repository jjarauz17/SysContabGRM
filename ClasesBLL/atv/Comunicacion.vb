'' FirmaElectronicaCR es un programa para la firma y envio de documentos XML para la Factura Electrónica de Costa Rica
''
'' Comunicacion es la clase para el envío del documento XML para la Factura Electrónica de Costa Rica
''
'' Esta clase de Firma fue realizado tomando como base el trabajo realizado por:
'' - Departamento de Nuevas Tecnologías - Dirección General de Urbanismo Ayuntamiento de Cartagena
'' - XAdES Starter Kit desarrollado por Microsoft Francia
'' - Cambios y funcionalidad para Costa Rica - Roy Rojas - royrojas@dotnetcr.com
''
'' La clase comunicación fue creada en conjunto con Cristhian Sancho
''
'' Este programa es software libre: puede redistribuirlo y / o modificarlo
'' bajo los + términos de la Licencia Pública General Reducida de GNU publicada por
'' la Free Software Foundation, ya sea la versión 3 de la licencia, o
'' (a su opción) cualquier versión posterior.

'' Este programa se distribuye con la esperanza de que sea útil,
'' pero SIN NINGUNA GARANTÍA; sin siquiera la garantía implícita de
'' COMERCIABILIDAD O IDONEIDAD PARA UN PROPÓSITO PARTICULAR.
'' Licencia pública general menor de GNU para más detalles.
''
'' Deberías haber recibido una copia de la Licencia Pública General Reducida de GNU
'' junto con este programa. Si no, vea http://www.gnu.org/licenses/.
''
'' This program Is distributed in the hope that it will be useful,
'' but WITHOUT ANY WARRANTY; without even the implied warranty of
'' MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'' GNU Lesser General Public License for more details.
''
'' You should have received a copy of the GNU Lesser General Public License
'' along with this program.  If Not, see http://www.gnu.org/licenses/. 

Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class Comunicacion

    Public Property xmlRespuesta As Xml.XmlDocument
    Public Property jsonEnvio As String = ""
    Public Property jsonRespuesta As String = ""
    Public Property mensajeRespuesta As String = ""
    Public Property estadoFactura As String = ""
    Public Property statusCode As String = ""
    Public Property statusCodeFirma As String = ""
    Public Property ErrorRespuesta As String = ""
    Public Property Consecutivo As String = "0"

    ''' <summary>
    ''' Envia los datos a los servidores de Hacienda y obtiene las respuestas necesarias
    ''' </summary>
    ''' <param name="TK">Token que generó Hacienda</param>
    ''' <param name="objRecepcion">Objeto que contiene todos las variables de comunicación</param>
    ''' 
    Public Sub EnvioDatos(TK As String, ByVal objRecepcion As Recepcion, URL_RECEPCION As String)
        Try
            'Dim URL_RECEPCION As String = "https://api.comprobanteselectronicos.go.cr/recepcion-sandbox/v1/"

            Dim http As HttpClient = New HttpClient
            Dim msgHacienda As String = ""

            Dim JsonObject As Newtonsoft.Json.Linq.JObject = New Newtonsoft.Json.Linq.JObject()
            JsonObject.Add(New JProperty("clave", objRecepcion.clave))
            JsonObject.Add(New JProperty("fecha", objRecepcion.fecha))
            JsonObject.Add(New JProperty("emisor", New JObject(New JProperty("tipoIdentificacion", objRecepcion.emisor.TipoIdentificacion),
                                                               New JProperty("numeroIdentificacion", objRecepcion.emisor.numeroIdentificacion))))
            If objRecepcion.receptor.sinReceptor = False Then
                JsonObject.Add(New JProperty("receptor", New JObject(New JProperty("tipoIdentificacion", objRecepcion.receptor.TipoIdentificacion),
                                                                     New JProperty("numeroIdentificacion", objRecepcion.receptor.numeroIdentificacion))))
            End If

            JsonObject.Add(New JProperty("comprobanteXml", objRecepcion.comprobanteXml))
            jsonEnvio = JsonObject.ToString

            Dim oString As StringContent = New StringContent(JsonObject.ToString)
            http.DefaultRequestHeaders.Add("authorization", "Bearer " + TK)

            Dim response As HttpResponseMessage = http.PostAsync(URL_RECEPCION + "recepcion", oString).Result
            Dim res As String = response.Content.ReadAsStringAsync.Result

            'XtraMsg(response.StatusCode)
            'Si manda codigo 400 es porque hay un error en
            If response.StatusCode.Equals("400") Or
                     response.StatusCode.Equals("404") Then

                XtraMsg("Error de Validación #: " & response.StatusCode & vbCrLf &
                        response.Headers.GetValues("X-Error-Cause")(0).ToString, Windows.Forms.MessageBoxIcon.Error)

                statusCodeFirma = response.StatusCode
                ErrorRespuesta = response.Headers.GetValues("X-Error-Cause")(0).ToString
                Exit Sub
            End If

            statusCodeFirma = response.StatusCode
            mensajeRespuesta = "Recibido: " & response.StatusCode & vbCrLf & vbCrLf

            http = New HttpClient
            http.DefaultRequestHeaders.Add("authorization", "Bearer " + TK)
            response = http.GetAsync(URL_RECEPCION + "recepcion/" + objRecepcion.clave).Result
            'response = http.GetAsync(response.Headers.Location.AbsoluteUri).Result
            res = response.Content.ReadAsStringAsync.Result

            jsonRespuesta = res.ToString

            Dim RH As RespuestaHacienda = Newtonsoft.Json.JsonConvert.DeserializeObject(Of RespuestaHacienda)(res)

            If RH.respuesta_xml <> "" Then
                xmlRespuesta = Funciones.DecodeBase64ToXML(RH.respuesta_xml)
                msgHacienda = xmlRespuesta.GetElementsByTagName("MensajeHacienda")(0)("DetalleMensaje").InnerText
            End If

            estadoFactura = RH.ind_estado
            statusCode = response.StatusCode

            mensajeRespuesta += "Confirmación: " & statusCode & vbCrLf
            mensajeRespuesta += "Estado: " & estadoFactura & vbCrLf
            mensajeRespuesta += "Mensaje Hacienda: " & msgHacienda

        Catch ex As Exception
            XtraMsg("Error en Envío: " & vbCrLf & ex.Message, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub EnvioDatosReceptor(TK As String,
                                  ByVal objRecepcion As Recepcion,
                                  URL_RECEPCION As String)
        Try

            Dim http As HttpClient = New HttpClient
            Dim msgHacienda As String = ""

            Dim JsonObject As Newtonsoft.Json.Linq.JObject = New Newtonsoft.Json.Linq.JObject()
            JsonObject.Add(New JProperty("clave", objRecepcion.clave))
            JsonObject.Add(New JProperty("fecha", objRecepcion.fecha))
            JsonObject.Add(New JProperty("emisor", New JObject(New JProperty("tipoIdentificacion", objRecepcion.emisor.TipoIdentificacion),
                                                               New JProperty("numeroIdentificacion", objRecepcion.emisor.numeroIdentificacion))))

            JsonObject.Add(New JProperty("receptor", New JObject(New JProperty("tipoIdentificacion", objRecepcion.receptor.TipoIdentificacion),
                                                                     New JProperty("numeroIdentificacion", objRecepcion.receptor.numeroIdentificacion))))

            JsonObject.Add(New JProperty("consecutivoReceptor", objRecepcion.ConsecutivoReceptor))
            JsonObject.Add(New JProperty("comprobanteXml", objRecepcion.comprobanteXml))

            jsonEnvio = JsonObject.ToString
            Dim oString As StringContent = New StringContent(JsonObject.ToString)

            http.DefaultRequestHeaders.Add("authorization", "Bearer " + TK)
            Dim response As HttpResponseMessage = http.PostAsync(URL_RECEPCION + "recepcion", oString).Result
            Dim res As String = response.Content.ReadAsStringAsync.Result

            'Si manda codigo 400 es porque hay un error en 
            If response.StatusCode.Equals("400") Or
                response.StatusCode.Equals("404") Then

                If response.StatusCode.Equals("400") Then statusCode = "400 (Bad Request)"
                If response.StatusCode.Equals("404") Then statusCode = "400 (Not Found)"

                statusCodeFirma = response.StatusCode
                ErrorRespuesta = response.Headers.GetValues("X-Error-Cause")(0).ToString

                mensajeRespuesta = "StatusCode Error: " & statusCode & vbCrLf & vbCrLf
                mensajeRespuesta += "Error Respuesta: " & ErrorRespuesta

                Exit Sub
            End If

            'Dim Location As String = response.Headers.Location.AbsoluteUri           
            'statusCode = response.StatusCode
            statusCodeFirma = response.StatusCode

            'Obtener Respuesta de Hacienda
            http = New HttpClient
            http.DefaultRequestHeaders.Add("authorization", "Bearer " + TK)
            response = http.GetAsync(response.Headers.Location.AbsoluteUri).Result
            res = response.Content.ReadAsStringAsync.Result

            If response.StatusCode.Equals("200") Then
                statusCode = "200 (OK)"
            ElseIf response.StatusCode = "202" Then
                statusCode = "202 (Accepted)"
            Else
                statusCode = response.StatusCode
            End If

            jsonRespuesta = res.ToString

            Dim RH As RespuestaHacienda = Newtonsoft.Json.JsonConvert.DeserializeObject(Of RespuestaHacienda)(res)

            If RH.respuesta_xml <> "" Then
                xmlRespuesta = Funciones.DecodeBase64ToXML(RH.respuesta_xml)
                msgHacienda = xmlRespuesta.GetElementsByTagName("MensajeHacienda")(0)("DetalleMensaje").InnerText
            End If

            estadoFactura = RH.ind_estado

            If msgHacienda = "" Then
                If estadoFactura = "aceptado" Then msgHacienda = "El Comprobante Electronico ha sido recibido."
                If estadoFactura = "procesando" Then msgHacienda = "Consulte en unos minutos nuevamente el estado del Comprobante."
            End If

            mensajeRespuesta = "Confirmación: " & statusCode & vbCrLf & vbCrLf
            mensajeRespuesta += "Estado: " & estadoFactura & vbCrLf
            mensajeRespuesta += "Mensaje Respuesta: " & msgHacienda

        Catch ex As Exception
            'XtraMsg("Error en Envío: " & vbCrLf & ex.Message, Windows.Forms.MessageBoxIcon.Error)
            statusCode = "400"
            mensajeRespuesta = "Exception Error: 404 (Error Data)"
            mensajeRespuesta += "Error Respuesta: " & ex.Message
        End Try
    End Sub


    Public Function GetDatosJson(json As String) As DataTable

        Dim _DT As New DataTable("JsonResult")

        Try

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

    Public Sub ConsultaEstatus(TK As String, 
                               claveConsultar As String, 
                               URL_RECEPCION As String, 
                               directorio As String, 
                               nombreArchivo As String)
        Try
            Dim http As HttpClient = New HttpClient
            Dim msgHacienda As String = ""

            'claveConsultar = "50606091800310133802000100001030000000114199999999"

            http.DefaultRequestHeaders.Add("authorization", "Bearer " + TK)

            Dim response As HttpResponseMessage = http.GetAsync(URL_RECEPCION & "recepcion/" & claveConsultar).Result
            Dim res As String = response.Content.ReadAsStringAsync.Result
            Dim Localizacion = response.StatusCode
            jsonRespuesta = res.ToString

            'XtraMsg(response.RequestMessage.ToString)
            'XtraMsg(response.StatusCode)

            If Not response.IsSuccessStatusCode Then
                estadoFactura = "sin respuesta"
                statusCode = response.StatusCode
                '
                mensajeRespuesta = "Confirmación: " & statusCode & vbCrLf
                mensajeRespuesta += "Estado: BadRequest(400)" & vbCrLf
                mensajeRespuesta += "Mensaje Hacienda: Exception Error: 404 (Error Data)" & vbCrLf & vbCrLf &
                response.RequestMessage.ToString

                Exit Sub
            End If

            Dim RH As RespuestaHacienda = Newtonsoft.Json.JsonConvert.DeserializeObject(Of RespuestaHacienda)(res)

            If RH.respuesta_xml <> "" Then
                xmlRespuesta = Funciones.DecodeBase64ToXML(RH.respuesta_xml)
                msgHacienda = xmlRespuesta.GetElementsByTagName("MensajeHacienda")(0)("DetalleMensaje").InnerXml

                xmlRespuesta.Save(directorio & nombreArchivo & "_05_RESP.xml")
            End If

            estadoFactura = RH.ind_estado
            statusCode = response.StatusCode

            mensajeRespuesta = "Confirmación: " & statusCode & vbCrLf
            mensajeRespuesta += "Estado: " & estadoFactura & vbCrLf
            mensajeRespuesta += "Mensaje Hacienda: " & msgHacienda

        Catch ex As Exception
            XtraMsg("Error en consultar Estado: " & vbCrLf & ex.Message, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub ConsultaEstatusReceptor(TK As String, claveConsultar As String, URL_RECEPCION As String)
        Try
            Dim http As HttpClient = New HttpClient
            Dim msgHacienda As String = ""

            http.DefaultRequestHeaders.Add("authorization", "Bearer " + TK)

            Dim response As HttpResponseMessage = http.GetAsync(URL_RECEPCION & "recepcion/" & claveConsultar).Result
            Dim res As String = response.Content.ReadAsStringAsync.Result

            'Dim Localizacion = response.StatusCode

            jsonRespuesta = res.ToString

            Dim RH As RespuestaHacienda = Newtonsoft.Json.JsonConvert.DeserializeObject(Of RespuestaHacienda)(res)

            If RH.respuesta_xml <> "" Then
                xmlRespuesta = Funciones.DecodeBase64ToXML(RH.respuesta_xml)
                msgHacienda = xmlRespuesta.GetElementsByTagName("MensajeHacienda")(0)("DetalleMensaje").InnerText
            End If

            estadoFactura = RH.ind_estado
            statusCodeFirma = response.StatusCode

            If msgHacienda = "" Then
                If estadoFactura = "aceptado" Then msgHacienda = "El Comprobante Electronico ha sido recibido."
                If estadoFactura = "procesando" Then msgHacienda = "Consulte en unos minutos nuevamente el estado del Comprobante."
            End If

            If response.StatusCode = "200" Then
                statusCode = "200 (OK)"
            ElseIf response.StatusCode = "202" Then
                statusCode = "202 (Accepted)"
            Else
                statusCode = response.StatusCode
            End If

            ' statusCode = response.StatusCode

            mensajeRespuesta = "Confirmación: " & statusCode & vbCrLf
            mensajeRespuesta += "Estado: " & estadoFactura & vbCrLf
            mensajeRespuesta += "Mensaje Hacienda: " & msgHacienda

        Catch ex As Exception
            'XtraMsg("Error en consultar Estado: " & vbCrLf & ex.Message, Windows.Forms.MessageBoxIcon.Error)
            estadoFactura = "sin-respuesta"
            statusCode = "400 (Bad Request)"
            mensajeRespuesta = "Exception Error: 404 (Error Data)"
            mensajeRespuesta += "Error Respuesta: " & ex.Message
        End Try
    End Sub



    Public Sub ConsultaComprobantesEnviados(TK As String, claveConsultar As String, URL_RECEPCION As String, directorio As String, nombreArchivo As String)
        Try
            Dim http As HttpClient = New HttpClient
            Dim msgHacienda As String = ""

            http.DefaultRequestHeaders.Add("authorization", "Bearer " + TK)

            Dim response As HttpResponseMessage = http.GetAsync(URL_RECEPCION & "comprobantes/" & claveConsultar).Result
            Dim res As String = response.Content.ReadAsStringAsync.Result

            Dim Localizacion = response.StatusCode

            jsonRespuesta = res.ToString

            Dim RH As RespuestaHacienda = Newtonsoft.Json.JsonConvert.DeserializeObject(Of RespuestaHacienda)(res)

            If RH.respuesta_xml <> "" Then
                xmlRespuesta = Funciones.DecodeBase64ToXML(RH.respuesta_xml)
                msgHacienda = xmlRespuesta.GetElementsByTagName("MensajeHacienda")(0)("DetalleMensaje").InnerText

                xmlRespuesta.Save(directorio & nombreArchivo & "_05_RESP.xml")
            End If

            estadoFactura = RH.ind_estado
            statusCode = response.StatusCode

            mensajeRespuesta = "Confirmación: " & statusCode & vbCrLf
            mensajeRespuesta += "Estado: " & estadoFactura & vbCrLf
            mensajeRespuesta += "Mensaje Hacienda: " & msgHacienda

        Catch ex As Exception
            XtraMsg("Error en consultar Estado: " & vbCrLf & ex.Message, Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub




End Class
