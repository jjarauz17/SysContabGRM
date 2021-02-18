using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ZohoUrl
    {
          
     public string UrlEnviar { get; set; }
     public string UrlRecibir { get; set; }


     public ZohoUrl Load(int Empresa)
     {
        DataTable dt = fn.ObtieneDatos("sp_sel_ApiZohoURL", Empresa);
        ZohoUrl det = new ZohoUrl();

        if (dt.Rows.Count == 0)
           return null;

        if (dt.Rows.Count > 0)
        {
           det.UrlEnviar = dt.Rows[0]["UrlEnviar"].ToString();
           det.UrlRecibir = dt.Rows[0]["UrlRecibir"].ToString();
        }

        return det;
     }


    }
}
