using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//using ZCRMSDK.CRM.Library.Setup.RestClient;
//using ZCRMSDK.OAuth.Client;
//using ZCRMSDK.OAuth.Contract;

namespace ZohoApi
{
   public class Token
    {
        
        public string accessToken { get; set; }
        public string refreshToken { get; set; }
        
        public void GetToken()
        {
            //ZCRMRestClient.Initialize(Dictionary.config);
            //ZohoOAuthClient client = ZohoOAuthClient.GetInstance();

            ZohoOAuthClient.Initialize();
            ZCRMRestClient.Initialize(null);
            ZohoOAuthClient client = ZohoOAuthClient.GetInstance();

            //ZohoOAuthParams param = new ZohoOAuthParams();
            //param.ClientId = "1000.BT8QS94IIA8278417LUKT1DE7XXBFH";
            //param.ClientSecret = "e319f52223bc374d77c65ab410587593cf3ae7e20c";
            //param.RedirectURL = "https://zohoapis.zoho.com/";
            //param.AccessType = "code";
            //param.Scopes = "ZohoCRM.modules.all";
            ///ZohoOAuthClient client = new ZohoOAuthClient(param);

            string grantToken = "1000.a25f043b256bcdcab5804a0cec61c684.ba747fb495a81327a9d78b0e2a1d052f";
           // ZohoOAuthTokens tokens = client.GenerateAccessToken(grantToken);            

            //string accessToken = tokens.AccessToken;
            //string refreshToken = tokens.RefreshToken;


            try
            {
                var conn = client.GetZohoConnector(ZohoOAuth.GetTokenURL());
                conn.AddParam(ZohoOAuthConstants.GRANT_TYPE, ZohoOAuthConstants.GRANT_TYPE_AUTH_CODE);
                conn.AddParam(ZohoOAuthConstants.CODE, grantToken);
                string response = conn.Post();

                string v = string.Empty;

                JObject responseJSON = JObject.Parse(response);

                //if (responseJSON.ContainsKey(ZohoOAuthConstants.ACCESS_TOKEN))
                //{
                //    ZohoOAuthTokens tokens = client.GetTokensFromJSON(responseJSON);
                //    tokens.UserMaiilId = client.GetUserMailId(tokens.AccessToken);
                //    ZohoOAuth.GetPersistenceHandlerInstance().SaveOAuthTokens(tokens);

                //    string accessToken = tokens.AccessToken;
                //    string refreshToken = tokens.RefreshToken;
                //    //return tokens;
                //}
                //throw new ZohoOAuthException("Exception while fetching Access Token from grant token" + response);
            }
            catch (WebException e)
            {
                ZCRMLogger.LogError(e);
                throw new ZohoOAuthException(e);
            }


        }
    }
}
