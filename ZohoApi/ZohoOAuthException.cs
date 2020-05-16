using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoApi
{
    public class ZohoOAuthException : Exception
    {
        private string message;
        private Exception originalException = null;

        //TODO: Inspect this class and learn about Exception class;

        public new string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
        public Exception OriginalException
        {
            get
            {
                return originalException;
            }
            set
            {
                originalException = value;
            }
        }

        public ZohoOAuthException(string errorMessage)
        {
            Message = errorMessage;
        }

        public ZohoOAuthException(Exception e)
        {
            OriginalException = e;
        }

        public override string ToString()
        {
            string returnMessage = typeof(ZohoOAuthException).Name + ".Caused by :";
            if (OriginalException != null)
            {
                returnMessage = returnMessage + OriginalException;
            }
            else
            {
                returnMessage += Message;
            }

            return returnMessage;
        }
    }
}
