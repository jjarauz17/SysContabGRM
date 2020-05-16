namespace ApiHacienda
{
    using System;    
    using System.Collections.Generic;    
    using System.Net.Http;

    public class TokenHacienda
    {

        public string accessToken { get; set; }
        public string refreshToken { get; set; }
        public string iError { get; set; }       

        public async void GetTokenHacienda(string usuario, 
            string password, 
            string IDP_CLIENT_ID, 
            string IDP_URI)
        {
            try
            {
                accessToken = "";
                refreshToken = "";

                //string IDP_CLIENT_ID = "api-stag";
                //string 
                //IDP_URI = "https://idp.comprobanteselectronicos.go.cr/auth/realms/rut-stag/protocol/openid-connect/token";

                HttpClient http = new HttpClient();
                List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();

                param.Add(new KeyValuePair<string, string>("client_id", IDP_CLIENT_ID));
                param.Add(new KeyValuePair<string, string>("grant_type", "password"));
                param.Add(new KeyValuePair<string, string>("username", usuario));
                param.Add(new KeyValuePair<string, string>("password", password));
                FormUrlEncodedContent content = new FormUrlEncodedContent(param);

                HttpResponseMessage response = http.PostAsync(IDP_URI, content).Result;
                string res = await response.Content.ReadAsStringAsync();
                Token tk = Newtonsoft.Json.JsonConvert.DeserializeObject<Token>(res);

                if ((response.StatusCode != System.Net.HttpStatusCode.OK))
                {
                    //throw new Exception(("Error: " + response.GetHashCode()));
                    //fn.XtraMsg(new Exception(("Error al Solicitar Token: " + response.GetHashCode())).ToString(), System.Windows.Forms.MessageBoxIcon.Error);
                    iError = "Error al Solicitar Token: " + response.GetHashCode().ToString();
                    return;
                }

                accessToken = tk.access_token;
                refreshToken = tk.refresh_token;
                iError = "Ok";

                //GetRefreshToken(refreshToken,
                //    IDP_CLIENT_ID,
                //    IDP_URI);
            }
            catch (Exception ex)
            {
                iError = "Error al Solicitar Token: " + ex.Message;
                //fn.XtraMsg(ex.Message, System.Windows.Forms.MessageBoxIcon.Error);
                //throw ex;
            }
        }

        public async void GetRefreshToken(string token,          
          string IDP_CLIENT_ID,
          string IDP_URI)
        {
            try
            {
                accessToken = "";
                refreshToken = "";

                //string IDP_CLIENT_ID = "api-stag";
                //string 
                //IDP_URI = "https://idp.comprobanteselectronicos.go.cr/auth/realms/rut-stag/protocol/openid-connect/token";

                HttpClient http = new HttpClient();
                List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
                param.Add(new KeyValuePair<string, string>("grant_type", "refresh_token"));
                param.Add(new KeyValuePair<string, string>("client_id", IDP_CLIENT_ID));                
                param.Add(new KeyValuePair<string, string>("refresh_token", token));                
                FormUrlEncodedContent content = new FormUrlEncodedContent(param);

                HttpResponseMessage response = http.PostAsync(IDP_URI, content).Result;
                string res = await response.Content.ReadAsStringAsync();
                Token tk = Newtonsoft.Json.JsonConvert.DeserializeObject<Token>(res);

                if ((response.StatusCode != System.Net.HttpStatusCode.OK))
                {
                    //throw new Exception(("Error: " + response.GetHashCode()));
                    //fn.XtraMsg(new Exception(("Error al Solicitar Token: " + response.GetHashCode())).ToString(), System.Windows.Forms.MessageBoxIcon.Error);
                    iError = "Error al Solicitar Token: " + response.GetHashCode().ToString();
                    return;
                }

                accessToken = tk.access_token;
                refreshToken = tk.refresh_token;
                iError = "Ok";
            }
            catch (Exception ex)
            {
                iError = "Error al Solicitar Token: " + ex.Message;
                //fn.XtraMsg(ex.Message, System.Windows.Forms.MessageBoxIcon.Error);
                //throw ex;
            }
        }

    }
}
