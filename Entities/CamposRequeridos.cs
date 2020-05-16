namespace Entities
{
    using System;
    public class CamposRequeridos
    {
        int vIdRequerido;

        public int IdRequerido
        {
            get
            {
                return vIdRequerido;
            }
            set
            {
                vIdRequerido = value;
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

        string vFormulario;

        public string Formulario
        {
            get
            {
                return vFormulario;
            }
            set
            {
                vFormulario = value;
            }
        }

        string vCampo;

        public string Campo
        {
            get
            {
                return vCampo;
            }
            set
            {
                vCampo = value;
            }
        }

    }

}
