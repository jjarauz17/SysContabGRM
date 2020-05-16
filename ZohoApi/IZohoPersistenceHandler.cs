using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoApi
{
    public interface IZohoPersistenceHandler
    {
        void SaveOAuthTokens(ZohoOAuthTokens zohoOAuthTokens);
        ZohoOAuthTokens GetOAuthTokens(string paramString);
        void DeleteOAuthTokens(string paramName);

    }
}
