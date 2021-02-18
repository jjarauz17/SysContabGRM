namespace Entities
{
    using System;
    public class ClientesComiteCredito
    {
        int vIdComite;

        public int IdComite
        {
            get
            {
                return vIdComite;
            }
            set
            {
                vIdComite = value;
            }
        }

        int vIdUsuario;

        public int IdUsuario
        {
            get
            {
                return vIdUsuario;
            }
            set
            {
                vIdUsuario = value;
            }
        }

        int vEmpresa;

        public int Empresa
        {
            get
            {
                return vEmpresa;
            }
            set
            {
                vEmpresa = value;
            }
        }

    }

}
