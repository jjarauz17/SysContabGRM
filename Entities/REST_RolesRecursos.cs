using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    using System;
    public class REST_RolesRecursos
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

        int vRecurso_Id;

        public int Recurso_Id
        {
            get
            {
                return vRecurso_Id;
            }
            set
            {
                vRecurso_Id = value;
            }
        }

    }


}
