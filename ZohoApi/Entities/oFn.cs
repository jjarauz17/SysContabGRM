namespace ZohoApi.Entities
{
    public class oFn
    {

        public string Conexion()
        {
            string StrCnn = string.Empty;
            string[] s = LeerConexion();

            StrCnn = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};", s[0], s[1], s[2], s[3]);

            return StrCnn;
        }

        public string[] LeerConexion()
        {

            string[] Cadena = new string[4];
            int op = Properties.Settings.Default.CadenaActual;

            try
            {                
                    Cadena[0] = Properties.Settings.Default.Servidor;
                    Cadena[1] = Properties.Settings.Default.BaseDatos;
                    Cadena[2] = Properties.Settings.Default.Usuario;
                    Cadena[3] = Properties.Settings.Default.Clave;
                
            }
            catch (Exception)
            {
                Cadena[0] = "";
                Cadena[1] = "";
                Cadena[2] = "";
                Cadena[3] = "";
                Cadena[4] = "1";
            }

        }
}
