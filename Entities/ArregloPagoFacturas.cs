namespace Entities
{
    using System;
    public class ArregloPagoFacturas
    {
        int vIdDetalle;

        public int IdDetalle
        {
            get
            {
                return vIdDetalle;
            }
            set
            {
                vIdDetalle = value;
            }
        }

        int vIdArreglo;

        public int IdArreglo
        {
            get
            {
                return vIdArreglo;
            }
            set
            {
                vIdArreglo = value;
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

        string vFactura;

        public string Factura
        {
            get
            {
                return vFactura;
            }
            set
            {
                vFactura = value;
            }
        }

        string vFecha;

        public string Fecha
        {
            get
            {
                return vFecha;
            }
            set
            {
                vFecha = value;
            }
        }

        string vVencimiento;

        public string Vencimiento
        {
            get
            {
                return vVencimiento;
            }
            set
            {
                vVencimiento = value;
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

    }

}
