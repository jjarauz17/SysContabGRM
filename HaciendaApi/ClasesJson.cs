namespace ApiHacienda
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

   public class ClasesJson
    {

    }

   public class RespuestaHacienda
    {
        [JsonProperty("clave")]
        public string clave { get; set; }

        [JsonProperty("fecha")]
        public string fecha { get; set; }

        [JsonProperty("ind-estado")]
        public string ind_estado { get; set; }

        [JsonProperty("respuesta-xml")]
        public string respuesta_xml { get; set; }
    }

    public class Token
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

    public class Recepcion
    {
        [JsonProperty("clave")]
        public string clave { get; set; }

        [JsonProperty("fecha")]
        public string fecha { get; set; }

        [JsonProperty("emisor")]
        public Emisor emisor { get; set; }

        [JsonProperty("receptor")]
        public Receptor receptor { get; set; }

        [JsonProperty("ConsecutivoReceptor")]
        public string ConsecutivoReceptor { get; set; }        

        [JsonProperty("comprobanteXml")]
        public string comprobanteXml { get; set; }
    }

    public class Emisor
    {
        [JsonProperty("TipoIdentificacion")]
        public string TipoIdentificacion { get; set; }

        [JsonProperty("numeroIdentificacion")]
        public string numeroIdentificacion { get; set; }
    }

    public class Receptor {
        [JsonProperty("TipoIdentificacion")]
        public string TipoIdentificacion { get; set; }

        [JsonProperty("numeroIdentificacion")]
        public string numeroIdentificacion { get; set; }

        public Boolean sinReceptor { get; set; }
    }
}

