namespace ApiHacienda
{
    using System.Xml;
    using System.IO;
    using System.Security;
    using System.Security.Cryptography.X509Certificates;
    using System.Security.Cryptography;
    using FirmaXadesNet;
    using FirmaXadesNet.Crypto;
    using FirmaXadesNet.Signature.Parameters;

   public class Firma
    {
        public string iError { get; set; }

        public void FirmaXML_Xades(string pathXML,
            string Certificado,
            bool esThumbprint,
            string Clave,
            string FirmaUrl)
        {
            try
            {
                XadesService xadesService = new XadesService();
                X509Certificate2 cert = new X509Certificate2(Certificado, Clave);
                SignatureParameters parametros = new SignatureParameters();

                parametros.SignaturePolicyInfo = new SignaturePolicyInfo();
                parametros.SignaturePolicyInfo.PolicyIdentifier = FirmaUrl;
                //La propiedad PolicyHash es la misma para todos, es un cálculo en base 
                //al archivo pdf indicado en PolicyIdentifier
                parametros.SignaturePolicyInfo.PolicyHash = "Ohixl6upD6av8N7pEvDABhEL6hM=";
                parametros.SignaturePackaging = SignaturePackaging.ENVELOPED;
                parametros.DataFormat = new DataFormat();
                parametros.DataFormat.MimeType = "text/xml";

                // StreamReader objReader = File.OpenText($"{pathXML}_01_SF.xml");
                StreamReader objReader = File.OpenText($"{pathXML}_XML_SinFirma.xml");
                XmlDocument DocumentoXml = new XmlDocument();
                DocumentoXml.LoadXml(objReader.ReadToEnd().ToString());
                objReader.Close();

                parametros.Signer = new Signer(cert);
                MemoryStream ms = new MemoryStream();

                DocumentoXml.PreserveWhitespace = true;
                DocumentoXml.Save(ms);
                ms.Flush();
                ms.Position = 0;

                var DocFirmado = xadesService.Sign(ms, parametros);
                //DocFirmado.Save($"{pathXML}_02_Firmado.xml");
                DocFirmado.Save($"{pathXML}_XML_Firmado.xml");

                iError = "Ok";
            }
            catch (System.Exception ex)
            {
                iError = ex.Message;
            }
        }
    }
}
