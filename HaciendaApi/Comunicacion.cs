// FirmaElectronica es un programa para la firma y envio de documentos XML para la Factura Electrónica de Costa Rica
//
// Comunicacion es la clase para el envío del documento XML para la Factura Electrónica de Costa Rica
//
// Esta clase de Firma fue realizado tomando como base el trabajo realizado por:
// - Departamento de Nuevas Tecnologías - Dirección General de Urbanismo Ayuntamiento de Cartagena
// - XAdES Starter Kit desarrollado por Microsoft Francia

namespace ApiHacienda
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Newtonsoft.Json.Linq;
    using System.Xml;
    using Microsoft.VisualBasic;
    using System.Collections;
    using System.Net;

    public class Comunicacion
    {
        public XmlDocument xmlRespuesta { get; set; }
        public string jsonEnvio { get; set; }
        public string jsonRespuesta { get; set; }
        public string mensajeRespuesta { get; set; }
        public string estadoFactura { get; set; }
        public object statusCode { get; set; }
        public string iError { get; set; }

       // oFn fn = new oFn();

        public async void EnvioDatos(string TK, Recepcion objRecepcion, string URL_RECEPCION)
        {
            try
            {
                //string URL_RECEPCION = "https://api.comprobanteselectronicos.go.cr/recepcion-sandbox/v1/";

                HttpClient http = new HttpClient();
                string MsgHacienda = string.Empty;

                Newtonsoft.Json.Linq.JObject JsonObject = new Newtonsoft.Json.Linq.JObject();
                JsonObject.Add(new JProperty("clave", objRecepcion.clave));
                JsonObject.Add(new JProperty("fecha", objRecepcion.fecha));
                JsonObject.Add(new JProperty("emisor",
                                             new JObject(new JProperty("tipoIdentificacion", objRecepcion.emisor.TipoIdentificacion),
                                                         new JProperty("numeroIdentificacion", objRecepcion.emisor.numeroIdentificacion))));

                if (objRecepcion.receptor.sinReceptor == false)
                {
                    JsonObject.Add(new JProperty("receptor",
                                             new JObject(new JProperty("tipoIdentificacion", objRecepcion.receptor.TipoIdentificacion),
                                                         new JProperty("numeroIdentificacion", objRecepcion.receptor.numeroIdentificacion))));
                }

                JsonObject.Add(new JProperty("comprobanteXml", objRecepcion.comprobanteXml));
                jsonEnvio = JsonObject.ToString();

                StringContent oString = new StringContent(JsonObject.ToString());
                http.DefaultRequestHeaders.Add("authorization", ("Bearer " + TK));

                HttpResponseMessage response = http.PostAsync((URL_RECEPCION + "recepcion"), oString).Result;
                string res = await response.Content.ReadAsStringAsync();               

                if (!response.StatusCode.ToString().Equals("Accepted"))
                {
                    iError = $"Error de Validación #: {response.StatusCode.ToString()}";
                    //mensajeRespuesta = response.Headers.GetValues["X-Error-Cause"][0].ToString();
                    statusCode = response.StatusCode.ToString();
                    return;
                }

                //object Localizacion = response.StatusCode;
                // mensajeRespuesta = Localizacion
                //IEnumerable listError = response.Headers.GetValues("X-Error-Cause").FirstOrDefault
               // string[] val = response.Headers.GetValues("").ToArray<>;

               // iError = response.Headers.GetValues("X-Error-Code").FirstOrDefault();

                //iError = (response.Headers)).headerStore["X-Error-Code"].ParsedValue();
                //string[] _err = (string[])response.Headers.GetValues("X-Error")[0];
                // Get the headers associated with the response.
                //httpWebHeaderCollection myWebHeaderCollection = response.Headers;

                //HttpResponseHeader myWebHeaderCollection = response.Headers;
                //HttpResponseMessage  myWebHeaderCollection = response.Headers;

                http = new HttpClient();
                http.DefaultRequestHeaders.Add("authorization", ("Bearer " + TK));
                response = http.GetAsync(URL_RECEPCION + "recepcion/" + objRecepcion.clave).Result;
                res = await response.Content.ReadAsStringAsync();

                jsonRespuesta = res.ToString();

                RespuestaHacienda RH = Newtonsoft.Json.JsonConvert.DeserializeObject<RespuestaHacienda>(res);

                if (RH == null)
                {
                    estadoFactura = null;
                }
                else
                {
                    if (RH.respuesta_xml != null)
                    {
                        xmlRespuesta = Funciones.DecodeBase64ToXML(RH.respuesta_xml);
                        MsgHacienda = xmlRespuesta.GetElementsByTagName("MensajeHacienda")[0]["DetalleMensaje"].InnerText;
                    }

                    estadoFactura = RH.ind_estado;
                }

            
                statusCode = response.StatusCode.ToString();

                mensajeRespuesta = ("Confirmación: " + (statusCode + Environment.NewLine));
                mensajeRespuesta = (mensajeRespuesta + ("Estado: " + estadoFactura == null ? "Sin Respuesta" : estadoFactura + Environment.NewLine));
                mensajeRespuesta = (mensajeRespuesta + ("Mensaje Hacienda: " + MsgHacienda));

                iError = "Ok";
            }
            catch (Exception ex)
            {
                iError = "Error: " + statusCode + Environment.NewLine +
                    ex.Message;

                //fn.XtraMsg("Error al Enviar XML: " + Constants.vbCrLf +
                //    ex.Message, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public async void ConsultaEstatus(string TK, string claveConsultar, string URL_RECEPCION)
        {
            try
            {
                string MsgHacienda = string.Empty;
                HttpClient http = new HttpClient();

                http.DefaultRequestHeaders.Add("authorization", ("Bearer " + TK));

                HttpResponseMessage response = http.GetAsync((URL_RECEPCION + ("recepcion/" + claveConsultar))).Result;
                string res = await response.Content.ReadAsStringAsync();

                object Localizacion = response.StatusCode;

                jsonRespuesta = res.ToString();

                RespuestaHacienda RH = Newtonsoft.Json.JsonConvert.DeserializeObject<RespuestaHacienda>(res);

                if (RH == null)
                {
                    estadoFactura = null;
                    statusCode = response.StatusCode;
                    MsgHacienda= response.StatusCode.ToString();
                }
                else {
                    if (RH.respuesta_xml != null)
                    {
                        if ((RH.respuesta_xml != ""))
                        {
                            xmlRespuesta = Funciones.DecodeBase64ToXML(RH.respuesta_xml);
                            MsgHacienda = xmlRespuesta.GetElementsByTagName("MensajeHacienda")[0]["DetalleMensaje"].InnerText;
                        }
                    }

                    estadoFactura = RH.ind_estado;
                    statusCode = response.StatusCode.ToString();
                }                                               
                
                mensajeRespuesta = ("Confirmación: " + (statusCode + Environment.NewLine));
                mensajeRespuesta = (mensajeRespuesta + ("Estado: " + estadoFactura == null ? "Sin Respuesta" : estadoFactura + Environment.NewLine));
                mensajeRespuesta = (mensajeRespuesta + ("Mensaje Hacienda: " + MsgHacienda));

                //statusCode = response.StatusCode.ToString();
                //mensajeRespuesta = ("Confirmación: " + (statusCode + Environment.NewLine));
                //mensajeRespuesta = (mensajeRespuesta + ("Estado: " + estadoFactura));

                iError = "Ok";
            }
            catch (Exception ex)
            {
                iError = "Error al Consultar Comprobante: " + Environment.NewLine +
                        ex.Message;

                //fn.XtraMsg("Error al Consultar Comprobante: " + Constants.vbCrLf +
                //    ex.Message, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }


    }
}
