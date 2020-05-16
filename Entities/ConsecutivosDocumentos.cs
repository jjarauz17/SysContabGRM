using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    using System;
    public class ConsecutivosDocumentos
    {
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

        string vDocumento;

        public string Documento
        {
            get
            {
                return vDocumento;
            }
            set
            {
                vDocumento = value;
            }
        }

        int vConsecutivo;

        public int Consecutivo
        {
            get
            {
                return vConsecutivo;
            }
            set
            {
                vConsecutivo = value;
            }
        }

    }


}
