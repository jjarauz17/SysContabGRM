using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connectivity
{

    public class Response
    {

        public bool IsSuccess
        {
            get;
            set;
        }

        public string Mensaje
        {
            get;
            set;
        }

        public object Result
        {
            get;
            set;
        }

    }
}
