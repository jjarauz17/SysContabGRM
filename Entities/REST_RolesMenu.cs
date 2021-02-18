using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    using System;
    public class REST_RolesMenu
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

        int vMenu_ID;

        public int Menu_ID
        {
            get
            {
                return vMenu_ID;
            }
            set
            {
                vMenu_ID = value;
            }
        }

    }

}
