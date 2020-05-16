using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Connectivity
{
    public class ZohoOAuthClient
    {

        private static ZohoOAuthClient client = null;

        public static ZohoOAuthClient GetInstance()
        {
            return client;
        }

        //TODO: Throw exceptions;
        public static void Initialize() { }

        public string GenerarGranToken()
        {
            try
            {
                string Url = "https://accounts.zoho.com/oauth/v2/auth?" +
                    "scope=ZohoCRM.modules.all&" +
                    "client_id=1000.BT8QS94IIA8278417LUKT1DE7XXBFH&" +
                    "response_type=code&" +
                    "access_type=offline&" +
                    "redirect_uri=https://www.grupoequipsa.com/";

                //ServicePointManager.ServerCertificateValidationCallback = ValidateRemoteCertificate;
                WebRequest request = WebRequest.Create(Url);
                request.Method = "POST";
                byte[] byteArray = Encoding.UTF8.GetBytes("https://accounts.zoho.com/");
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse response = request.GetResponse();
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();

                return responseFromServer;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
