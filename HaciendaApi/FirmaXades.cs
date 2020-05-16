namespace ApiHacienda
{

    using FirmaXadesNet;
    using FirmaXadesNet.Crypto;
    using FirmaXadesNet.Signature.Parameters;
    using Microsoft.VisualBasic;
    using System;    
    using System.IO;    
    using System.Security.Cryptography.X509Certificates;    
    using System.Xml;

    public class FirmaXades
    {
        public string iError { get; set; }

        public void XadesEpesFirma(string pathXML,            
            string PathCertificado, 
            string PINCertificado,
            string UrlFirma)
        {
            var xadesService = new XadesService();

            X509Certificate2 Certificat = new X509Certificate2(
                ConvertirCertificadoEnBytes(PathCertificado),
                PINCertificado);
            try
            {
                var parametros = new SignatureParameters
                {
                    SignaturePolicyInfo = new SignaturePolicyInfo
                    {
                        PolicyIdentifier = UrlFirma,
                        PolicyHash = "Ohixl6upD6av8N7pEvDABhEL6hM="
                    },
                    SignaturePackaging = SignaturePackaging.ENVELOPED,                                                                                
                    DataFormat = new DataFormat(),                    
                };
                parametros.DataFormat.MimeType = "text/xml";
                
                StreamReader objReader = File.OpenText(pathXML + "_01_SF.xml");
                XmlDocument documentoXml = new XmlDocument();
                documentoXml.LoadXml(objReader.ReadToEnd().ToString());
                objReader.Close();

                using (parametros.Signer = new Signer(Certificat))
                {
                    using (MemoryStream fs = new MemoryStream())
                    {
                        documentoXml.PreserveWhitespace = true;
                        documentoXml.Save(fs);
                        fs.Flush();
                        fs.Position = 0;
                        var docFirmado = xadesService.Sign(fs, parametros);
                        documentoXml = docFirmado.Document;
                        docFirmado.Save((pathXML + "_02_Firmado.xml"));
                    }
                }

                iError = "Ok";
            }
            catch (Exception ex)
            {
                iError = "Error en metodo XadesEpesFirma." + Environment.NewLine + ex.Message;
            }

            //documentoXml.Save(@"C:\Users\Public\Documents\" + EngineDocumentoXml.NombreDocumentoXml(documentoXml));
            //return documentoXml;
        }

        private byte[] ConvertirCertificadoEnBytes(string PathCertificado)
        {
            byte[] certificadoBytes = System.IO.File.ReadAllBytes(PathCertificado);
            return certificadoBytes;
        }

    }
}
