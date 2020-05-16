using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoApi
{
    public interface IAPIHandler
    {
        APIConstants.RequestMethod GetRequestMethod();

        string GetUrlPath();

        JObject GetRequestBody();

        Dictionary<string, string> GetRequestHeaders();

        Dictionary<string, string> GetRequestQueryParams();
    }

}
