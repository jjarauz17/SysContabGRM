namespace Entities
{
    using System;
    public class BitacoraFacturasVencidas
    {
        int vIdBitacora;

        public int IdBitacora
        {
            get
            {
                return vIdBitacora;
            }
            set
            {
                vIdBitacora = value;
            }
        }

        int vIdCliente;

        public int IdCliente
        {
            get
            {
                return vIdCliente;
            }
            set
            {
                vIdCliente = value;
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

        string vDescripcion;

        public string Descripcion
        {
            get
            {
                return vDescripcion;
            }
            set
            {
                vDescripcion = value;
            }
        }

        string vFacturas;

        public string Facturas
        {
            get
            {
                return vFacturas;
            }
            set
            {
                vFacturas = value;
            }
        }

        string vMoneda;

        public string Moneda
        {
            get
            {
                return vMoneda;
            }
            set
            {
                vMoneda = value;
            }
        }

        double vSaldo;

        public double Saldo
        {
            get
            {
                return vSaldo;
            }
            set
            {
                vSaldo = value;
            }
        }

        DateTime vFecha_Creacion;

        public DateTime Fecha_Creacion
        {
            get
            {
                return vFecha_Creacion;
            }
            set
            {
                vFecha_Creacion = value;
            }
        }

        string vUsuario;

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

    }

}
