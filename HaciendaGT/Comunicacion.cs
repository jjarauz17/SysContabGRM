namespace HaciendaGT
{
    using ClasesBLL;
    using Newtonsoft.Json;
    using System;
    using System.Data;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;
    using System.Xml;
    using System.Xml.Serialization;    
    using static HaciendaGT.XmlFormatoFactura;
    using Entities;
    using static HaciendaGT.XmlFormatoAnulacion;

    public class Comunicacion
    {
        public string iError { get; set; }

        public ResponseApi responseApi;

        //Factura_ElectronicaCR FE = new Factura_ElectronicaCR();
        FacturaElectronicaGT objHeader = new FacturaElectronicaGT();
        db_FacturaElectronicaGT db = new db_FacturaElectronicaGT();
        Credenciales objCredenciales = new Credenciales();

        DataTable Detalle = new DataTable("DetalleFactura");
        string xml = string.Empty;

        public async void EnvioDatosFactura(
            string Factura,
            string Tipo,
            int Empresa)

        {
            string res = string.Empty;

            try
            {
                //Obtener Encabezado y Detalle de la Factura
                objHeader = db.Header(Factura, Tipo, Empresa);
                Detalle = db.Detalle(Factura, Empresa);
                objCredenciales = DAL.Credenciales(Empresa);

                if (objHeader is null)
                {
                    iError = "El SP: sp_sel_FacturaElectronicaGTDatos no ha devuelto ningun valor.";
                    return;
                }

                // Covertir la Clase en XML
                XmlSerializer serializador = new XmlSerializer(typeof(GTDocumento));
                StringBuilder sb = new StringBuilder();
                TextWriter tw = new StringWriter(sb);
                serializador.Serialize(tw, new CrearXmlFactura().FacturaXml(objHeader, Detalle));
                tw.Close();
                xml = sb.ToString();

                // Limpiar XML para que sea igual al formato de Hacienda
                xml = xml.Substring(198, xml.Length - 198);
                xml = xml.Replace("<", "<dte:");
                xml = xml.Replace("<dte:/", "</dte:");
                xml = xml.Replace("<dte:cfc", "<cfc");
                xml = xml.Replace("</dte:cfc", "</cfc");
                xml = xml.Replace("<dte:AbonosFacturaCambiaria", "<cfc:AbonosFacturaCambiaria");
                xml = xml.Replace("</dte:AbonosFacturaCambiaria>", "</cfc:AbonosFacturaCambiaria>");

                xml = $"{objHeader.EncabezadoFE}{xml}";

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));

                client.DefaultRequestHeaders.Add("UsuarioFirma", objCredenciales.usuarioFirma);
                client.DefaultRequestHeaders.Add("LlaveFirma", objCredenciales.tokenFirma);
                client.DefaultRequestHeaders.Add("UsuarioApi", objCredenciales.usuaarioApi);
                client.DefaultRequestHeaders.Add("LlaveApi", objCredenciales.llaveApi);
                client.DefaultRequestHeaders.Add("Identificador", objHeader.Consecutivo);

                StringContent oString = new StringContent(xml);

                HttpResponseMessage response = client.PostAsync(new Uri(objCredenciales.urlApi), oString).Result;
                res = await response.Content.ReadAsStringAsync();
                responseApi = JsonConvert.DeserializeObject<ResponseApi>(res);

                //Actualizar el resultado en Tabla
                db.Actualizar(
                    objHeader.Id,
                    xml,
                    responseApi.numero,
                    responseApi.resultado ? "aceptado" : "rechazado",
                    res,
                    responseApi.xml_certificado,
                    Empresa);

                iError = "Ok";
            }
            catch (Exception ex)
            {
                iError = ex.Message;
                //Actualizar el resultado en Tabla en caso de Error.
                db.Actualizar(
                    objHeader.Id,
                    xml,
                    string.Empty,
                    "sin-respuesta",
                    res.Length == 0 ? iError : res,
                    string.Empty,
                    Empresa);

            }


        }

        public async void EnvioDatosFExportacion(
            string Factura,
            string Tipo,
            int Empresa)
        {

            string res = string.Empty;

            try
            {
                //Obtener Encabezado y Detalle de la Factura
                objHeader = db.Header(Factura, Tipo, Empresa);
                Detalle = db.Detalle(Factura, Empresa);
                objCredenciales = DAL.Credenciales(Empresa);

                if (objHeader is null)
                {
                    iError = "El SP: sp_sel_FacturaElectronicaGTDatos no ha devuelto ningun valor.";
                    return;
                }

                // Covertir la Clase en XML
                XmlSerializer serializador = new XmlSerializer(typeof(XmlFormatoFExportacion.GTDocumento));
                StringBuilder sb = new StringBuilder();
                TextWriter tw = new StringWriter(sb);
                serializador.Serialize(tw, new CrearXMLFExportacion().FExportacionXml(objHeader, Detalle));
                tw.Close();
                xml = sb.ToString();

                // Limpiar XML para que sea igual al formato de Hacienda
                xml = xml.Substring(198, xml.Length - 198);
                xml = xml.Replace("<", "<dte:");
                xml = xml.Replace("<dte:/", "</dte:");                
                xml = xml.Replace("<dte:cex", "<cex");
                xml = xml.Replace("</dte:cex", "</cex");
                xml = xml.Replace("<dte:Exportacion", "<cex:Exportacion");
                xml = xml.Replace("</dte:Exportacion>", "</cex:Exportacion>");
                xml = xml.Replace("<dte:cfc", "<cfc");
                xml = xml.Replace("</dte:cfc", "</cfc");
                xml = xml.Replace("<dte:AbonosFacturaCambiaria", "<cfc:AbonosFacturaCambiaria");
                xml = xml.Replace("</dte:AbonosFacturaCambiaria>", "</cfc:AbonosFacturaCambiaria>");

                xml = $"{objHeader.EncabezadoFE}{xml}";

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));

                client.DefaultRequestHeaders.Add("UsuarioFirma", objCredenciales.usuarioFirma);
                client.DefaultRequestHeaders.Add("LlaveFirma", objCredenciales.tokenFirma);
                client.DefaultRequestHeaders.Add("UsuarioApi", objCredenciales.usuaarioApi);
                client.DefaultRequestHeaders.Add("LlaveApi", objCredenciales.llaveApi);
                client.DefaultRequestHeaders.Add("Identificador", objHeader.Consecutivo);

                StringContent oString = new StringContent(xml);

                HttpResponseMessage response = client.PostAsync(new Uri(objCredenciales.urlApi), oString).Result;
                res = await response.Content.ReadAsStringAsync();
                responseApi = JsonConvert.DeserializeObject<ResponseApi>(res);

                //Actualizar el resultado en Tabla
                db.Actualizar(
                    objHeader.Id,
                    xml,
                    responseApi.numero,
                    responseApi.resultado ? "aceptado" : "rechazado",
                    res,
                    responseApi.xml_certificado,
                    Empresa);

                iError = "Ok";
            }
            catch (Exception ex)
            {
                iError = ex.Message;
                //Actualizar el resultado en Tabla en caso de Error.
                db.Actualizar(
                    objHeader.Id,
                    xml,
                    string.Empty,
                    "sin-respuesta",
                    res.Length == 0 ? iError : res,
                    string.Empty,
                    Empresa);

            }


        }

        public async void EnvioDatosNotas(
            int IdNota ,            
            string Tipo,
            ResponseApi Api,
            string Motivo,
            int Empresa)

        {
            string res = string.Empty;

            try
            {
                //Obtener Encabezado y Detalle de la Nota de Debito/Credito
                objHeader = db.HeaderNCD(IdNota, Tipo, Empresa);
                Detalle = db.DetalleNC(IdNota, Empresa);
                objCredenciales = DAL.Credenciales(Empresa, 1);                

                if (objHeader is null)
                {
                    iError = "El SP: sp_sel_NotaElectronicaGTDatos no ha devuelto ningun valor.";
                    return;
                }
               
                // Covertir la Clase en XML
                XmlSerializer serializador = new XmlSerializer(typeof(XmlFormatoNotaCredito.GTDocumento));
                StringBuilder sb = new StringBuilder();
                TextWriter tw = new StringWriter(sb);
                serializador.Serialize(tw, new CrearXmlNotasCD().NotaCDXml(objHeader, Detalle, Api, Motivo));
                tw.Close();
                xml = sb.ToString();

                // Limpiar XML para que sea igual al formato de Hacienda
                xml = xml.Substring(198, xml.Length - 198);
                xml = xml.Replace("<", "<dte:");
                xml = xml.Replace("<dte:/", "</dte:");
                xml = xml.Replace("<dte:cfc", "<cfc");
                xml = xml.Replace("</dte:cfc", "</cfc");                
                xml = xml.Replace("<dte:ReferenciasNota", "<cno:ReferenciasNota");
                xml = xml.Replace("</dte:ReferenciasNota>", "</cno:ReferenciasNota>");

                xml = $"{objHeader.EncabezadoFE}{xml}";

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));

                client.DefaultRequestHeaders.Add("UsuarioFirma", objCredenciales.usuarioFirma);
                client.DefaultRequestHeaders.Add("LlaveFirma", objCredenciales.tokenFirma);
                client.DefaultRequestHeaders.Add("UsuarioApi", objCredenciales.usuaarioApi);
                client.DefaultRequestHeaders.Add("LlaveApi", objCredenciales.llaveApi);
                client.DefaultRequestHeaders.Add("Identificador", objHeader.Consecutivo);

                StringContent oString = new StringContent(xml);

                HttpResponseMessage response = client.PostAsync(new Uri(objCredenciales.urlApi), oString).Result;
                res = await response.Content.ReadAsStringAsync();
                responseApi = JsonConvert.DeserializeObject<ResponseApi>(res);

                //Actualizar el resultado en Tabla
                db.Actualizar(
                    objHeader.Id,
                    xml,
                    responseApi.numero,
                    responseApi.resultado ? "aceptado" : "rechazado",
                    res,
                    responseApi.xml_certificado,
                    Empresa);

                iError = "Ok";
            }
            catch (Exception ex)
            {
                iError = ex.Message;
                //Actualizar el resultado en Tabla en caso de Error.
                db.Actualizar(
                    objHeader.Id,
                    xml,
                    string.Empty,
                    "sin-respuesta",
                    res.Length == 0 ? iError : res,
                    string.Empty,
                    Empresa);

            }


        }


        public async void EnvioDatosAnula(
            string Factura,
            string Tipo,
            string NumeroDocumento,
            string Motivo,
            DataTable _dt,
            int Empresa)
        {

            if (_dt.Rows.Count == 0)
            {
                iError = "El SP: sp_sel_FacturaElectronicaAnulacion no ha devuelto ningun valor.";
                return;
            }

            string res = string.Empty;

            try
            {
                // Covertir la Clase en XML
                XmlSerializer serializador = new XmlSerializer(typeof(GTAnulacionDocumento));
                StringBuilder sb = new StringBuilder();
                TextWriter tw = new StringWriter(sb);
                serializador.Serialize(tw, new CrearXmlAnulacion().AnulacionXml(NumeroDocumento, Motivo, _dt));
                tw.Close();
                xml = sb.ToString();

                // Limpiar XML para que sea igual al formato de Hacienda
                xml = xml.Substring(206, xml.Length - 206);
                xml = xml.Replace("<", "<dte:");
                xml = xml.Replace("<dte:/", "</dte:");
                xml = $"{_dt.Rows[0]["EncabezadoFE"].ToString()}{xml}";

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));

                objCredenciales = DAL.Credenciales(Empresa);

                client.DefaultRequestHeaders.Add("UsuarioFirma", objCredenciales.usuarioFirma);
                client.DefaultRequestHeaders.Add("LlaveFirma", objCredenciales.tokenFirma);
                client.DefaultRequestHeaders.Add("UsuarioApi", objCredenciales.usuaarioApi);
                client.DefaultRequestHeaders.Add("LlaveApi", objCredenciales.llaveApi);
                client.DefaultRequestHeaders.Add("Identificador", _dt.Rows[0]["Consecutivo"].ToString());

                StringContent oString = new StringContent(xml);

                HttpResponseMessage response = client.PostAsync(new Uri(objCredenciales.urlApi), oString).Result;
                res = await response.Content.ReadAsStringAsync();
                responseApi = JsonConvert.DeserializeObject<ResponseApi>(res);

                //Actualizar el resultado en Tabla
                db.Actualizar(
                    (int)_dt.Rows[0]["Id"],
                    xml,
                    responseApi.numero,
                    responseApi.resultado ? "aceptado" : "rechazado",
                    res,
                    responseApi.xml_certificado,
                    Empresa);

                iError = "Ok";
            }
            catch (Exception ex)
            {

                iError = ex.Message;
                //Actualizar el resultado en Tabla en caso de Error.
                db.Actualizar(
                    (int)_dt.Rows[0]["Id"],
                    xml,
                    string.Empty,
                    "sin-respuesta",
                    res.Length == 0 ? iError : res,
                    string.Empty,
                    Empresa);
            }
         
        }
    }
}
