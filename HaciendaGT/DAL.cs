namespace HaciendaGT
{

    using System;
    using ClasesBLL;
    using Microsoft.VisualBasic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DAL
    {
        public static string iError { get; set; }

        public static Credenciales Credenciales(int Empresa, int Demo = 0)
        {
            DataTable _dt = ObtieneDatos("sp_sel_CredencialesSAT", Empresa, Demo);

            if (_dt.Rows.Count > 0)
            {
                return new Credenciales
                {
                    urlApi = _dt.Rows[0]["Url"].ToString(),
                    Nit = _dt.Rows[0]["Nit"].ToString(),
                    usuarioFirma = _dt.Rows[0]["UsuarioFirma"].ToString(),
                    tokenFirma = _dt.Rows[0]["TokenFirma"].ToString(),
                    usuaarioApi = _dt.Rows[0]["UsuarioApi"].ToString(),
                    llaveApi = _dt.Rows[0]["LlaveApi"].ToString(),
                };
            }
            else {
                return null;
            } 
        }


        public static DataTable ObtieneDatos(string Procedimiento, params object[] Parametros)
        {

            SqlConnection cn = new SqlConnection(fn.Conexion());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = Procedimiento;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            try
            {
                cn.Open();
                cmd.Connection = cn;
                da.SelectCommand = cmd;
                SqlCommandBuilder.DeriveParameters(cmd);
            }
            catch (Exception iEx)
            {
                iError = $"Error SP: {Procedimiento}" +
                    $"{iEx.Message}";                     
                return null;
            }

            try
            {
                if (Parametros != null)
                {
                    for (int i = 1; i <= Parametros.Length; i++)
                    {
                        cmd.Parameters[i].Value = Parametros[i - 1];
                    }
                }
            }
            catch (Exception ex)
            {
                iError = ex.Message;
            }

            try
            {
                da.Fill(dt);
                iError = "Ok";
            }
            catch (Exception ex)
            {
                iError = $"Error SP: {Procedimiento}" +
                   $"{ex.Message}";
                dt = null;
               // XtraMsg(iError, MessageBoxIcon.Error);
            }

            da = null;
            cmd = null;
            cn.Close();

            return dt;
        }
    }
}
