using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoApi.DictionaryData
{
    public class Dictionary
    {

        public static Dictionary<string, string> config = new Dictionary<string, string>()
        {
            {"client_id",new InitData().Cliente_id},
            {"client_secret",new InitData().Client_Secret},
            {"redirect_uri","https://www.google.com/"},
            {"access_type","offline"},
            {"persistence_handler_class","ZohoApi.OAuth.ClientApp.ZohoOAuthFilePersistence, ZohoApi"},
            {"oauth_tokens_file_path",@"D:\Zoho\OauthTokens\TokenConfig.txt"},
            {"mysql_username","root"},
            {"mysql_password",""},
            {"mysql_database","zohooauth"},
            {"mysql_server","localhost"},
            {"mysql_port","3306"},
            {"apiBaseUrl","https://www.zohoapis.com"},
            {"iamURL","https://accounts.zoho.com"},
            {"photoUrl",""},
            {"apiVersion","v2"},
            {"logFilePath","" },
            {"timeout",""},
            {"minLogLevel",""},
            {"domainSuffix",""},
            {"currentUserEmail","axel.irias@grupoequipsa.net"}
        };
    }
}
