namespace ZohoApi.Entities
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Net;
    using System.Net.Mail;

    public abstract class ClComun : ClConexion
    {

        int vCodError;
        static string VMensajeError;
        string vUsuario;

        public enum TieneTransaccion
        {
            Si = 1,
            No = 0
        };

        public string Usuario
        {
            get
            {
                return vUsuario;
            }
            set
            {
                vUsuario = value;
            }
        }

        protected void InicializarMensajeError()
        {
            vCodError = 0;
            VMensajeError = "";
        }

        public static string MensajeError
        {
            get
            {
                return VMensajeError;
            }
            set
            {
                VMensajeError = value;
            }
        }

        public int CodigoError
        {
            get
            {
                return vCodError;
            }
            set
            {
                vCodError = value;
            }
        }

        public string ObtenerParametrosWebConfig(string Param)
        {
            return "jjarauz17@gmail.com";
        }

        //protected void SendEmail(string MensajeError)
        //{

        //    //MethodInfo rf;

        //    string NombreClase;
        //    bool flag = true;

        //        foreach (MethodInfo rf in this.GetType.GetMethods)
        //    {
        //        NombreClase = rf.DeclaringType.FullName;
        //        if (flag)
        //        {
        //            SendEmail(ObtenerParametrosWebConfig("EmailError"), NombreClase, MensajeError);
        //            flag = false;
        //        }
        //    }
        //}

        private string SendEmail(string email, string nombreclase, string mensajeerror)
        {
            try
            {
                using (MailMessage mm = new MailMessage())
                {

                    string LoginN = "admin";

                    mm.From = new MailAddress("jjarauz17@gmail.com", "Informática, Dpto. Análisis y Desarrollo!", System.Text.Encoding.UTF8);
                    mm.To.Add(email);
                    //mm.Bcc.Add("ernestina@ramac.com.ni");
                    mm.Subject = "Error en Sistema Integración de Factura Electronica,  Clase " + nombreclase;

                    mm.Body = "<p style=" + "FONT-WEIGHT: bold; FONT-SIZE: 10px; COLOR: navy; FONT-FAMILY: Verdana, Arial" + "> " +
                        "Fyi. <br>" + " Le informomos del siguiente error de sistema: <br><br> " + " Error: <b> " + mensajeerror +
                        "  </b><br>" + " Usuario: <b> " + LoginN + "  </b><br>" + " Host: <b> " + Environment.MachineName + "  </b><br>" +
                        " <br> Un Cordial saludo, <br> " + " Ing. Jonnys Arauz <br> " + " Analista Programador de Sistemas Automatizados <br></p>";

                    mm.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "mail.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred = new NetworkCredential("jjarauz17@gmail.com", "Pa$$w0rd2018*");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;
                    smtp.Send(mm);

                    return "Send";
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public SqlCommand ConfigurarComando(string NombreProcedimiento, object[] ListaValoresParametros)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = this.ConeccionSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreProcedimiento;
            SqlCommandBuilder.DeriveParameters(cmd);
            cmd.CommandTimeout = 0;
            AsignarParametros(cmd, ListaValoresParametros);
            return cmd;
        }

        public SqlCommand ConfigurarComando(TieneTransaccion Trans,
            string NombreProcedimiento,
            object[] ListaValoresParametros)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = AsignaComando(NombreProcedimiento);

            if (Trans == TieneTransaccion.Si)
            {
                cmd.Transaction = this.BeginTranSql();
            }

            //' Recupera los parametros del sp
            SqlCommandBuilder.DeriveParameters(cmd);
            //'asigna parametros
            AsignarParametros(cmd, ListaValoresParametros);
            return cmd;
        }
        public SqlCommand ConfigurarComando(TieneTransaccion Trans,
            string NombreProcedimiento,
            object[] ListaValoresParametros,
            string varOpcion)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = AsignaComando(NombreProcedimiento);

            if (Trans == TieneTransaccion.Si)
            {
                cmd.Transaction = this.BeginTranSql();
            }

            //Recupera los parametros del sp
            SqlCommandBuilder.DeriveParameters(cmd);
            //asigna parametros
            AsignarParametros(cmd, ListaValoresParametros, varOpcion);
            return cmd;
        }

        private SqlCommand AsignaComando(string NombreProcedimiento)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = this.ConeccionSql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreProcedimiento;
            cmd.CommandTimeout = 0;
            return cmd;
        }

        private void AsignarParametros(SqlCommand cmd,
                                        object[] ListaValoresParametros,
                                        string varOpcion)
        {
            int i;
            SqlCommandBuilder.DeriveParameters(cmd);

            for (i = 1; i <= ListaValoresParametros.Length; i++)
            {

                cmd.Parameters[i].Value = ListaValoresParametros[i - 1];
                if (i == 1)
                {
                    cmd.Parameters[i].Direction = ParameterDirection.InputOutput;
                }
                else
                {
                    cmd.Parameters[i].Direction = ParameterDirection.Input;
                }
            }
        }

        private void AsignarParametros(SqlCommand cmd, object[] ListaValoresParametros)
        {
            int i;
            SqlCommandBuilder.DeriveParameters(cmd);

            for (i = 1; i <= ListaValoresParametros.Length; i++)
            {
                cmd.Parameters[i].Value = ListaValoresParametros[i - 1];
            }
        }

        public SqlCommand ConfigurarComando(string NombreProcedimiento)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = AsignaComando(NombreProcedimiento);
            return cmd;
        }

        public SqlCommand ConfigurarComando(TieneTransaccion Trans,
            string NombreProcedimiento)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = AsignaComando(NombreProcedimiento);
            if (Trans == TieneTransaccion.Si)
            {
                cmd.Transaction = this.BeginTranSql();
            }
            return cmd;
        }

    }
}
