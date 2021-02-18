using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    using System;
    public class REST_RolesAcciones
    {
        int vRol_Id;

        public int Rol_Id
        {
            get
            {
                return vRol_Id;
            }
            set
            {
                vRol_Id = value;
            }
        }

        int vAccion_ID;

        public int Accion_ID
        {
            get
            {
                return vAccion_ID;
            }
            set
            {
                vAccion_ID = value;
            }
        }

    }


}
