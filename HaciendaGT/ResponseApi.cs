namespace HaciendaGT
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class ResponseApi
   {        
        public bool resultado { get; set; }        
        public string fecha { get; set; }        
        public string origen { get; set; }        
        public string descripcion { get; set; }        
        public ControlEmision control_emision { get; set; }        
        public bool alertas_infile { get; set; }
        public List<string> descripcion_alertas_infile { get; set; }
        public bool alertas_sat { get; set; }
        public List<object> descripcion_alertas_sat { get; set; }
        public string cantidad_errores { get; set; }
        public List<DescripcionErrore> descripcion_errores { get; set; }
        public string informacion_adicional { get; set; }
        public string uuid { get; set; }
        public string serie { get; set; }
        public string numero { get; set; }
        public string xml_certificado { get; set; }

    }

    public class ControlEmision
    {
        public string Saldo { get; set; }
        public string Creditos { get; set; }
    }

    public class DescripcionErrore
    {
        public bool resultado { get; set; }
        public string fuente { get; set; }
        public string categoria { get; set; }
        public string numeral { get; set; }
        public string validacion { get; set; }
        public string mensaje_error { get; set; }
    }
}
