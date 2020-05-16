using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ZohoApi
{
    public class FileAPIResponse : APIResponse
    {

        public FileAPIResponse(HttpWebResponse response) : base(response) { }

        public string GetFileName()
        {
            string fileMetaData = Response.Headers["Content-Disposition"];
            string fileName = fileMetaData.Split(new string[] { "=" }, StringSplitOptions.None)[1];
            if (fileName.Contains("''"))
            {
                fileName = fileName.Split(new string[] { "''" }, StringSplitOptions.None)[1];

            }
            fileName = fileName.Trim('\"');
            return fileName;
        }


        protected override void SetResponseJSON()
        {
            if (HttpStatusCode == APIConstants.ResponseCode.OK || HttpStatusCode == APIConstants.ResponseCode.NO_CONTENT)
            {
                ResponseJSON = new JObject();
                string contentDisposition = Response.GetResponseHeader("Content-Disposition");
                if (HttpStatusCode == APIConstants.ResponseCode.OK && !string.IsNullOrEmpty(contentDisposition))
                {
                    Status = APIConstants.CODE_SUCCESS;
                }
                else
                {
                    string responseString = new StreamReader(Response.GetResponseStream()).ReadToEnd();
                    if (responseString != null && responseString != "")
                    {
                        ResponseJSON = JObject.Parse(responseString);
                    }
                }
            }
        }

        public Stream GetFileAsStream()
        {
            Stream outStream = Response.GetResponseStream();
            return outStream;
        }


    }
}
