namespace Entities
{
    using System;
    using DevExpress.XtraEditors;
    using System.Windows.Forms;
    using System.Data;
    using System.Data.SqlClient;
    using Microsoft.VisualBasic;
    using System.Reflection;
    using System.Diagnostics;
    using Microsoft.Win32;
    using System.IO;

    //using ClasesBLL;

    public static class fn
    {

        public static string iError { get; set; }

        //Credenciales credenciales = new Credenciales();
        //public string Conexion()
        //{
        //    string StrCnn = string.Empty;
        //    string[] s = LeeData();

        //    StrCnn = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};", s[0], s[1], s[2], s[3]);

        //    return StrCnn;
        //}

        //public string[] LeeData()
        //{
        //    string[] Cadena = new string[4];
        //    Assembly assembly = Assembly.GetExecutingAssembly();

        //    try
        //    {
        //        Cadena[0] = GetSetting(FileVersionInfo.GetVersionInfo(assembly.Location).ProductName, "CxCadena", "NServer_RAMAC","");
        //        Cadena[0] = GetSetting(FileVersionInfo.GetVersionInfo(assembly.Location).ProductName, "CxCadena", "NServer_RAMAC",""); ;
        //        Cadena[2] = credenciales.LoginN;
        //        Cadena[3] = credenciales.PasswordN;                
        //    }
            
        //    catch (Exception)
        //    {
        //        Cadena[0] = string.Empty;
        //        Cadena[1] = string.Empty;
        //        Cadena[2] = string.Empty;
        //        Cadena[3] = string.Empty;
        //    }

        //    return Cadena;
        //}

        static private string GetSetting(string appName, string section, string key, string sDefault)
        {
            // Los datos de VB se guardan en:
            // HKEY_CURRENT_USER\Software\VB and VBA Program Settings
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"Software\VB and VBA Program Settings\" +
                                                              appName + "\\" + section);
            string s = sDefault;
            if (rk != null)
                s = (string)rk.GetValue(key);
            //
            return s;
        }


        public static void XtraMsg(string msg, MessageBoxIcon Icono = MessageBoxIcon.Information,
                         MessageBoxButtons Tipo = MessageBoxButtons.OK, string Titulo = "")
        {

            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);

            XtraMessageBox.Show(
                msg, 
                (Titulo == "") ? "SysContab" : Titulo, 
                Tipo, 
                Icono);

        }

        public static bool XtraMsg2(string msg, MessageBoxIcon Icono = MessageBoxIcon.Question,
                                    MessageBoxButtons Tipo = MessageBoxButtons.YesNo,
                                    string Titulo = "")
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);

            if (XtraMessageBox.Show(
                msg, 
                (Titulo == "") ? "SysContab" : Titulo, 
                Tipo, 
                Icono, 
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static object IsNull(object Var, object Valor = null)
        {
            // if DBNull.Value

            if (Var == null || Var == DBNull.Value || Var.ToString() == string.Empty)

            {
                return Var == DBNull.Value ? "" : Valor;
            }
            else
            {
                return Var;
            }
        }

        public static DataTable ObtieneDatos(string Procedimiento, params object[] Parametros)
        {

            SqlConnection cn = new SqlConnection(ClasesBLL.fn.Conexion());
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
                iError = "Error SP: " + Procedimiento + Constants.vbCrLf +
                    iEx.Message;
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
                iError = "Error SP: " + Procedimiento + Constants.vbCrLf +
                    ex.Message;
                dt = null;
                XtraMsg("Error SP: " + Procedimiento + Constants.vbCrLf +
                    ex.Message, MessageBoxIcon.Error);
            }

            da = null;
            cmd = null;
            cn.Close();

            return dt;
        }

        public static bool FormatoImpreso(int Tipo, string Repx, int Empresa)
        {
                                    
            try
            {
                byte[] Data = (byte[])ObtieneDatos("sp_sel_Formatos", 
                    Tipo, 
                    Empresa)
                    .Rows[0]["ChequeD"];

                int Tamano = Data.GetUpperBound(0);
                string Cadena = $"{Application.StartupPath}\\{Repx}.repx";

                if (File.Exists(Cadena))
                    { File.Delete(Cadena); }                

                FileStream Archivo = new FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write);
                Archivo.Write(Data, 0, Tamano);
                Archivo.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }


    }
}
