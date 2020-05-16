namespace ZohoApi.DictionaryData
{
    using ClasesBLL;
    public class InitData
    {

        public string Cliente_id { get; set; }
        public string Client_Secret { get; set; }

        ZohoToken obj = new ZohoToken();
        public InitData()
        {
            obj = db_ZohoToken.Detalles("api-modules");

            Cliente_id = obj.Client_ID;
            Client_Secret = obj.Client_Secret;

        }


        //public string Cliente_id()
        //{           
        //    return obj.Client_ID;
        //}

        //public string Client_Secret()
        //{
        //    ZohoToken obj = new ZohoToken();
        //    obj = db_ZohoToken.Detalles("api-modules");

        //    return obj.Client_Secret;
        //}
    }
}
