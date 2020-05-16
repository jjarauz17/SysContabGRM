namespace Entities
{
    using System;
    public class FacturasElectronicasComprasDetalle
    {
        double vIdDetalle;

        public double IdDetalle
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

        int vIdFactura;

        public int IdFactura
        {
            get
            {
                return vIdFactura;
            }
            set
            {
                vIdFactura = value;
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

        string vCodigo;

        public string Codigo
        {
            get
            {
                return vCodigo;
            }
            set
            {
                vCodigo = value;
            }
        }

        double vCantidad;

        public double Cantidad
        {
            get
            {
                return vCantidad;
            }
            set
            {
                vCantidad = value;
            }
        }

        double vCosto;

        public double Costo
        {
            get
            {
                return vCosto;
            }
            set
            {
                vCosto = value;
            }
        }

        double vDescuento;

        public double Descuento
        {
            get
            {
                return vDescuento;
            }
            set
            {
                vDescuento = value;
            }
        }

        double vImpuesto;

        public double Impuesto
        {
            get
            {
                return vImpuesto;
            }
            set
            {
                vImpuesto = value;
            }
        }

        string vTipo;

        public string Tipo
        {
            get
            {
                return vTipo;
            }
            set
            {
                vTipo = value;
            }
        }

    }

}
