using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    using System;
    public class ClientesSeguimiento
    {
        int vIdSeguimiento;

        public int IdSeguimiento
        {
            get
            {
                return vIdSeguimiento;
            }
            set
            {
                vIdSeguimiento = value;
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

        string vFechaLlamada;

        public string FechaLlamada
        {
            get
            {
                return vFechaLlamada;
            }
            set
            {
                vFechaLlamada = value;
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

        string vHoraPago;

        public string HoraPago
        {
            get
            {
                return vHoraPago;
            }
            set
            {
                vHoraPago = value;
            }
        }

        string vAcuerdo;

        public string Acuerdo
        {
            get
            {
                return vAcuerdo;
            }
            set
            {
                vAcuerdo = value;
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

        string vFecha_Creacion;

        public string Fecha_Creacion
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

        string vFecha_Modificacion;

        public string Fecha_Modificacion
        {
            get
            {
                return vFecha_Modificacion;
            }
            set
            {
                vFecha_Modificacion = value;
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

        string vUsuario_Modifica;

        public string Usuario_Modifica
        {
            get
            {
                return vUsuario_Modifica;
            }
            set
            {
                vUsuario_Modifica = value;
            }
        }

        int vActivo;

        public int Activo
        {
            get
            {
                return vActivo;
            }
            set
            {
                vActivo = value;
            }
        }

    }

}
