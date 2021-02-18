using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    using System;
    public class FacturasCuotasDetalle
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

        int vId;

        public int Id
        {
            get
            {
                return vId;
            }
            set
            {
                vId = value;
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

        int vNumero;

        public int Numero
        {
            get
            {
                return vNumero;
            }
            set
            {
                vNumero = value;
            }
        }

        string vFechaPago;

        public string FechaPago
        {
            get
            {
                return vFechaPago;
            }
            set
            {
                vFechaPago = value;
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

        double vCuota;

        public double Cuota
        {
            get
            {
                return vCuota;
            }
            set
            {
                vCuota = value;
            }
        }

        double vInteres;

        public double Interes
        {
            get
            {
                return vInteres;
            }
            set
            {
                vInteres = value;
            }
        }

        int vComp_No;

        public int Comp_No
        {
            get
            {
                return vComp_No;
            }
            set
            {
                vComp_No = value;
            }
        }

        int vPer_Id;

        public int Per_Id
        {
            get
            {
                return vPer_Id;
            }
            set
            {
                vPer_Id = value;
            }
        }

        int vMes;

        public int Mes
        {
            get
            {
                return vMes;
            }
            set
            {
                vMes = value;
            }
        }

        int vAplicada;

        public int Aplicada
        {
            get
            {
                return vAplicada;
            }
            set
            {
                vAplicada = value;
            }
        }

    }

}
