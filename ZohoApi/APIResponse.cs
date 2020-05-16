﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ZohoApi
{
    public class APIResponse : CommonAPIResponse
    {

        private ZCRMEntity data;
        private string status;
        private string message;


        public APIResponse() { }

        public APIResponse(HttpWebResponse response) : base(response) { }

        public ZCRMEntity Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        public string Message
        {
            get
            {
                return message;
            }
            private set
            {
                message = value;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }
            internal set
            {
                status = value;
            }
        }


        protected override void ProcessDataResponse()
        {
            JObject msgJSON = ResponseJSON;
            if (msgJSON.ContainsKey(APIConstants.DATA))
            {
                JArray recordsArray = (JArray)ResponseJSON.GetValue(APIConstants.DATA);
                msgJSON = (JObject)recordsArray[0];
            }
            if (msgJSON.ContainsKey(APIConstants.TAGS))
            {
                JArray tagsArray = (JArray)ResponseJSON.GetValue(APIConstants.TAGS);
                msgJSON = (JObject)tagsArray[0];
            }
            if (msgJSON.ContainsKey(APIConstants.USERS))
            {
                JArray usersArray = (JArray)ResponseJSON.GetValue(APIConstants.USERS);
                msgJSON = (JObject)usersArray[0];
            }
            if (msgJSON.ContainsKey(APIConstants.MESSAGE))
            {
                Message = msgJSON.GetValue(APIConstants.MESSAGE).ToString();
            }

            if (msgJSON.ContainsKey(APIConstants.STATUS))
            {
                Status = msgJSON.GetValue(APIConstants.STATUS).ToString();
                if (Status.Equals(APIConstants.CODE_ERROR))
                {
                    if (msgJSON.ContainsKey(APIConstants.DETAILS))
                    {
                        //TODO: Inspect the working of this part;
                        throw new ZCRMException(msgJSON.GetValue(APIConstants.CODE).ToString(), Message, msgJSON.GetValue(APIConstants.DETAILS) as JObject);
                    }
                    throw new ZCRMException(msgJSON.GetValue(APIConstants.CODE).ToString(), Message);
                }
            }
            //NOTE: For the user photo download method.
            else if (msgJSON.ContainsKey("status_code"))
            {
                Status = msgJSON["status_code"].ToString();
                if (msgJSON.ContainsKey("errors"))
                {
                    JArray errorDetails = (JArray)msgJSON["errors"];
                    throw new ZCRMException("Status_code :" + (string)msgJSON["status_code"] + ", Error details: " + errorDetails[0]["code"] + ", Resource :" + errorDetails[0]["resource"]);
                }
                throw new ZCRMException("Status_code :" + (string)msgJSON["status_code"] + msgJSON.ToString());

            }
        }

        protected override void HandleFaultyResponse()
        {
            if (HttpStatusCode == APIConstants.ResponseCode.NO_CONTENT)
            {
                throw new ZCRMException(APIConstants.INVALID_DATA, APIConstants.INVALID_ID_MSG);
            }
            ZCRMLogger.LogError(ResponseJSON[APIConstants.CODE] + " " + ResponseJSON[APIConstants.MESSAGE]);
            throw new ZCRMException(ResponseJSON.GetValue(APIConstants.CODE).ToString(), ResponseJSON.GetValue(APIConstants.MESSAGE).ToString());
        }
    }
}
