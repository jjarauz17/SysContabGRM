﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZohoApi
{
    public class ZCRMRestClient
    {

        private static readonly ThreadLocal<string> CURRENT_USER_EMAIL = new ThreadLocal<string>();

        public static readonly ThreadLocal<Dictionary<string, string>> DYNAMIC_HEADERS = new ThreadLocal<Dictionary<string, string>>();

        public static Dictionary<string, string> StaticHeaders { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// To get RestClient Instance.
        /// </summary>
        /// <returns>ZCRMRestClient class instance.</returns>
        public static ZCRMRestClient GetInstance()
        {
            return new ZCRMRestClient();
        }

        /// <summary>
        /// To Initialize SDK with configuration property values through app.config.
        /// </summary>
       /* public static void Initialize()
        {
            Initialize(true);
        }

        public static void Initialize(bool handleAuthentication)
        {
            ZCRMConfigUtil.Initialize(handleAuthentication, null, null);
        }

        /// <summary>
        /// To Initialize SDK with configuration property values through text file like stream data.
        /// </summary>
        /// <param name="inputStream">File stream data.(Stream)</param>
        public static void Initialize(Stream inputStream)
        {
            ZCRMConfigUtil.CustomInitialize(inputStream);
        }*/

        /// <summary>
        /// To Initialize SDK with configuration property values through Dictionary.
        /// </summary>
        /// <param name="config">Is the Dictionary contains C#SDK configuration key values.</param>
        public static void Initialize(Dictionary<string, string> config)
        {
            ZCRMConfigUtil.CustomInitialize(config);
        }

        /// <summary>
        /// To set current user mail Id.
        /// </summary>
        /// <param name="userEmail">User email Id (String)</param>
        public static void SetCurrentUser(string userEmail)
        {
            CURRENT_USER_EMAIL.Value = userEmail;
        }

        /// <summary>
        /// To get Current User mail Id.
        /// </summary>
        /// <returns>Current user email Id.</returns>
        public static string GetCurrentUserEmail()
        {
            return CURRENT_USER_EMAIL.Value;
        }

        /// <summary>
        /// To set DynamicHeaders values through Dictionary.
        /// </summary>
        /// <param name="headers">Is the Dictionary contains Dynamic headers key values</param>
        public static void SetDynamicHeaders(Dictionary<string, string> headers)
        {
            DYNAMIC_HEADERS.Value = headers;
        }

        /// <summary>
        /// To get DynamicHeaders values.
        /// </summary>
        /// <returns>Dictionary key values.</returns>
        public static Dictionary<string, string> GetDynamicHeaders()
        {
            return DYNAMIC_HEADERS.Value;
        }

        /// <summary>
        /// To get ZohoCRM Organization instance.
        /// </summary>
        /// <returns>ZCRMOrganization class instance.</returns>
        public ZCRMOrganization GetOrganizationInstance()
        {
            return ZCRMOrganization.GetInstance();
        }

        /// <summary>
        /// To get ZohoCRM Organization Details.
        /// </summary>
        /// <returns>APIResponse class instance.</returns>
        public APIResponse GetOrganizationDetails()
        {
            return OrganizationAPIHandler.GetInstance().GetOrganizationDetails();
        }

        /// <summary>
        /// To get current user in ZohoCRM Organization.
        /// </summary>
        /// <returns>APIResponse class instance.</returns>
        public APIResponse GetCurrentUser()
        {
            return OrganizationAPIHandler.GetInstance().GetCurrentUser();
        }

        /// <summary>
        /// To get ZohoCRM modules' instance by passing module API name.
        /// </summary>
        /// <returns>ZCRMModule class instance.</returns>
        /// <param name="moduleAPIName">modules' API name (String)</param>
        public ZCRMModule GetModuleInstance(string moduleAPIName)
        {
            return ZCRMModule.GetInstance(moduleAPIName);
        }

        /// <summary>
        /// To get ZohoCRM record instance by passing module API name and entity(record) Id.
        /// </summary>
        /// <returns>ZCRMRecord class instance.</returns>
        /// <param name="moduleAPIName">modules' API name (String)</param>
        /// <param name="entityId">entity(record) Id (Long)</param>
        public ZCRMRecord GetRecordInstance(string moduleAPIName, long entityId)
        {
            return ZCRMRecord.GetInstance(moduleAPIName, entityId);
        }

        /// <summary>
        /// To get all ZohoCRM modules' details.
        /// </summary>
        /// <returns>BulkAPIResponse&lt;ZCRMModule&gt; class instance of type ZCRMModule.</returns>
        public BulkAPIResponse<ZCRMModule> GetAllModules()
        {
            return GetAllModules(null);
        }

        /// <summary>
        /// To get All ZohoCRM modules' details that are modified after the date-time specified in the If-Modified-Since Header.
        /// </summary>
        /// <returns>BulkAPIResponse&lt;ZCRMModule&gt; class instance.</returns>
        /// <param name="modifiedSince">DateTime(ISO8601 format) to display modules which are modified after the given input datetime (String)</param>
        public BulkAPIResponse<ZCRMModule> GetAllModules(string modifiedSince)
        {
            return MetaDataAPIHandler.GetInstance().GetAllModules(modifiedSince);
        }

        /// <summary>
        /// To get specified modules' details by passing modules' API name.
        /// </summary>
        /// <returns>APIResponse class instance.</returns>
        /// <param name="moduleName">modules' API name (String)</param>
        public APIResponse GetModule(string moduleName)
        {
            return MetaDataAPIHandler.GetInstance().GetModule(moduleName);
        }
    }
}
