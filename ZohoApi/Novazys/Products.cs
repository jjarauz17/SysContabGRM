namespace ZohoApi.Novazys
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Linq;

    public class Products
    {

        public async void EnviarToZoho(string Codigo,
            string Nombre,
            string Categoria,
            string Codigo_SysContab,
            double Precio,
            double Cantidad,
            string Almacen,
            string URL)
        {
            
            HttpClient http = new HttpClient();
            
            JObject JsonObject = new JObject();
            JsonObject.Add(new JProperty("Product_Code", Codigo));
            JsonObject.Add(new JProperty("Product_Name", Nombre));
            JsonObject.Add(new JProperty("Product_Category", Categoria));
            JsonObject.Add(new JProperty("codigo_syscontab", Codigo_SysContab));
            JsonObject.Add(new JProperty("precio", Precio.ToString()));
            JsonObject.Add(new JProperty("cantidad", Cantidad.ToString()));
            JsonObject.Add(new JProperty("almacen", Almacen));
            JsonObject.Add(new JProperty("sincronizacion_syscontab","si" ));
            JsonObject.Add(new JProperty("fecha_actualizacion", DateTime.UtcNow.ToString()));

            StringContent oString = new StringContent(JsonObject.ToString());
            oString.Headers.ContentType.MediaType = "application/json";

            //Call client.PostAsJsonAsync to send a POST request to the appropriate URI   
            HttpResponseMessage response = await http.PostAsync(URL, oString);
            string res = await response.Content.ReadAsStringAsync();
            var contents = await response.Content.ReadAsStringAsync();

            //This method throws an exception if the HTTP response status is an error code.  
            //var xx = resp.EnsureSuccessStatusCode();

            if (!response.StatusCode.Equals("200"))
            {
                //iError = $"Error de Validación #: {response.StatusCode.ToString()}";
                //mensajeRespuesta = response.Headers.GetValues["X-Error-Cause"][0].ToString();
                //statusCode = response.StatusCode.ToString();
                return;
            }      
        }

        public async void RecibirFromZoho(string Codigo_SysContab,
            string Nombre,
            string Almacen,
            string Descripcion,
            double Precio,
            double Cantidad,
            string URL)
        {

            HttpClient client = new HttpClient();            
            
            // Configurar encabezados para que la petición de realice en formato JSON            
            JObject JsonObject = new JObject();
            JsonObject.Add(new JProperty("codigo_syscontab", Codigo_SysContab));
            JsonObject.Add(new JProperty("nombre", Nombre));
            JsonObject.Add(new JProperty("descripcion", Descripcion));
            JsonObject.Add(new JProperty("precio", Precio.ToString()));
            JsonObject.Add(new JProperty("cantidad", Cantidad.ToString()));
            JsonObject.Add(new JProperty("almacen", Almacen));

            StringContent oString1 = new StringContent(JsonObject.ToString());
            oString1.Headers.ContentType.MediaType = "application/json";

            //Call client.PostAsJsonAsync to send a POST request to the appropriate URI   
            HttpResponseMessage response = await client.PostAsync(URL, oString1);

            var contents = await response.Content.ReadAsStringAsync();
            string res1 = await response.Content.ReadAsStringAsync();

        }

    }
}
