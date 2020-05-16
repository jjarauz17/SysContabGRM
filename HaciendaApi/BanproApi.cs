namespace HaciendaApi
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;

    public class BanproApi
    {

        public async void GetToken(string Merchant,
           string Key,
           string Secret_key,
           string IDP_URI)
        {

            HttpClient http = new HttpClient();
            List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();

            param.Add(new KeyValuePair<string, string>("client_id", Merchant));
            param.Add(new KeyValuePair<string, string>("Key", Key));
            param.Add(new KeyValuePair<string, string>("Shared Secret Key", Secret_key));
            FormUrlEncodedContent content = new FormUrlEncodedContent(param);

            HttpResponseMessage response = http.PostAsync(IDP_URI, content).Result;
            string res = await response.Content.ReadAsStringAsync();
            Token tk = Newtonsoft.Json.JsonConvert.DeserializeObject<Token>(res);
        }

        class Token
        {
            [JsonProperty("access_token")]
            public string access_token { get; set; }
            [JsonProperty("refresh_token")]
            public string refresh_token { get; set; }
            [JsonProperty("refresh_expires_in")]
            public string refresh_expires_in { get; set; }
            [JsonProperty("expires_in")]
            public string expires_in { get; set; }
        }



    }
}
