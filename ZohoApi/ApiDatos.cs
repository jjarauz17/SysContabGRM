namespace ZohoApi
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ZohoApi.DictionaryData;
    //using ZCRMSDK.CRM.Library.Setup.RestClient;
    //using ZCRMSDK.CRM.Library.Api.Response;
    //using ZCRMSDK.CRM.Library.CRUD;
    //using ZCRMSDK.CRM.Library.Common;
    public class ApiDatos
    {
        public void GetModulos()
        {
            ZCRMRestClient.Initialize(Dictionary.config);

            ZCRMRestClient RestClient = ZCRMRestClient.GetInstance();
            BulkAPIResponse<ZCRMModule> response = RestClient.GetAllModules();
            List<ZCRMModule> modules = response.BulkData;

            var l = modules;
           
        }

        public void GetAllModules()
        {
            ZCRMRestClient.Initialize(Dictionary.config);
            ZCRMRestClient restClient = ZCRMRestClient.GetInstance();

            BulkAPIResponse<ZCRMModule> response = restClient.GetAllModules();
            Console.WriteLine(response.HttpStatusCode); //Based on API Response    
            List<ZCRMModule> modules = response.BulkData; // modules - list of ZCRMModule instances

            foreach (ZCRMModule module in modules)
            {
                Console.WriteLine(module.ApiName);
                Console.WriteLine(module.Id);

                Console.WriteLine(module.ModifiedTime);
                Console.WriteLine(module.PluralLabel);
                Console.WriteLine(module.SingularLabel);
                Console.WriteLine(module.SystemName);
                List<ZCRMProfile> AccessibleProfiles = module.AccessibleProfiles;
                foreach (ZCRMProfile profile in AccessibleProfiles)
                {
                    Console.WriteLine(profile.Id);
                    Console.WriteLine(profile.Name);
                }
                Console.WriteLine(module.ApiSupported);
                List<string> BussinessCardFields = module.BussinessCardFields;
                foreach (string BussinessCardField in BussinessCardFields)
                {
                    Console.WriteLine(BussinessCardField);
                }
                Console.WriteLine(module.Convertable);
                Console.WriteLine(module.Creatable);
                Console.WriteLine(module.CustomModule);
                Console.WriteLine(module.Deletable);
                Console.WriteLine(module.Editable);

                ZCRMUser ModifiedBy = module.ModifiedBy;
                if (ModifiedBy != null)
                {
                    Console.WriteLine(ModifiedBy.Id);
                    Console.WriteLine(ModifiedBy.FullName);
                }
                List<ZCRMModuleRelation> relations = module.RelatedLists;
                foreach (ZCRMModuleRelation relation in relations)
                {
                    Console.WriteLine(relation.ApiName);
                    Console.WriteLine(relation.Id);
                }
                Console.WriteLine(module.Viewable);
            }
        }


        public void GetLeads()
        {

            ZCRMRestClient.Initialize(Dictionary.config);
            ZCRMModule module = ZCRMModule.GetInstance("Leads");

            BulkAPIResponse<ZCRMRecord> response =
                module.SearchByCriteria("((Last_Name:starts_with:B) or (Email:equals:burns.mary@xyz.com))");

            List<ZCRMRecord> records = response.BulkData; //To get response List of ZCRMRecord.

            //if (records.Count > 0)
            //    {

            //    foreach (KeyValuePair<string, string> data in records[0].Data)
            //    {
            //        var s = data["Company"];
            //    }
            //}
            

                MessageBox.Show(records[0].Data["Company"].ToString() + "/n" +
                records[1].Data["Company"].ToString() + "/n" +
                records[2].Data["Company"].ToString() + "/n" +
                records[3].Data["Company"].ToString() + "/n" +
                records[4].Data["Company"].ToString() + "/n" +
                records[5].Data["Company"].ToString() + "/n" +
                records[6].Data["Company"].ToString() + "/n" +
                records[7].Data["Company"].ToString() + "/n" +
                records[8].Data["Company"].ToString() + "/n" +
                records[9].Data["Company"].ToString() + "/n" +
                records[10].Data["Company"].ToString() + "/n" +
                records[11].Data["Company"].ToString() + "/n" +
                records[12].Data["Company"].ToString() + "/n" +
                records[13].Data["Company"].ToString() + "/n" +
                records[14].Data["Company"].ToString());


            //ZCRMModule moduleIns = ZCRMModule.GetInstance("Leads"); //module api name
            //List<string> fields = new List<string> { "Last_Name", "Company", "Email", "id" }; //field api name
            //BulkAPIResponse<ZCRMRecord> response = moduleIns.GetRecords(
            //    3372164000000087503, 
            //    "Company", 
            //    CommonUtil.SortOrder.asc, 1, 4, fields); // get Records with cvId, sortByField, sortOrder, startIndex, endIndex and fieldApiNamelist.

            //List<ZCRMRecord> records = response.BulkData; //records - list of ZCRMRecord instance

        }


        /** To get All Users */
        public void GetAllUsers()
        {
            ZCRMRestClient restClient = ZCRMRestClient.GetInstance();
            BulkAPIResponse<ZCRMUser> response = restClient.GetOrganizationInstance().GetAllUsers();
            List<ZCRMUser> allUsers = response.BulkData; // users - list of ZCRMUser instances
            foreach (ZCRMUser user in allUsers)
            {
                Console.WriteLine(user.Country);
                ZCRMRole Role = user.Role;
                if (Role != null)
                {
                    Console.WriteLine(Role.Id);
                    Console.WriteLine(Role.Name);
                }
                if (user.CustomizeInfo != null)
                {
                    ZCRMUserCustomizeInfo customizeInfo = user.CustomizeInfo;
                    Console.WriteLine(customizeInfo.NotesDesc);
                    Console.WriteLine(customizeInfo.IsToShowRightPanel);
                    Console.WriteLine(customizeInfo.IsBcView);
                    Console.WriteLine(customizeInfo.IsToShowHome);
                    Console.WriteLine(customizeInfo.IsToShowDetailView);
                    Console.WriteLine(customizeInfo.UnpinRecentItem);
                }
                Console.WriteLine(user.City);
                Console.WriteLine(user.Signature);
                Console.WriteLine(user.NameFormat);
                Console.WriteLine(user.Language);
                Console.WriteLine(user.Locale);
                Console.WriteLine(user.MicrosoftAppUser);
                Console.WriteLine(user.IsPersonalAccount);
                Console.WriteLine(user.IsOnline);
                Console.WriteLine(user.DefaultTabGroup);
                ZCRMUser ModifiedBy = user.ModifiedBy;
                if (ModifiedBy != null)
                {
                    Console.WriteLine(ModifiedBy.Id);
                    Console.WriteLine(ModifiedBy.FullName);
                }
                Console.WriteLine(user.Number);
                Console.WriteLine(user.Street);
                Console.WriteLine(user.Alias);
                if (user.Theme != null)
                {
                    ZCRMUserTheme theme = user.Theme;
                    Console.WriteLine(theme.NormalTabFontColor);
                    Console.WriteLine(theme.NormalTabBackground);
                    Console.WriteLine(theme.SelectedTabFontColor);
                    Console.WriteLine(theme.SelectedTabBackground);
                    Console.WriteLine(theme.New_background);
                    Console.WriteLine(theme.Background);
                    Console.WriteLine(theme.Screen);
                    Console.WriteLine(theme.Type);

                }
                Console.WriteLine(user.Id);
                Console.WriteLine(user.State);
                Console.WriteLine(user.Fax);
                Console.WriteLine(user.CountryLocale);
                Console.WriteLine(user.FirstName);
                Console.WriteLine(user.EmailId);
                ZCRMUser ReportingTo = user.ReportingTo;
                if (ReportingTo != null)
                {
                    Console.WriteLine(ReportingTo.Id);
                    Console.WriteLine(ReportingTo.FullName);
                }
                Console.WriteLine(user.Zip);
                Console.WriteLine(user.DecimalSeparator);
                Console.WriteLine(user.CreatedTime);
                Console.WriteLine(user.ModifiedTime);
                Console.WriteLine(user.Website);
                Console.WriteLine(user.TimeFormat);
                Console.WriteLine(user.OffSet);
                ZCRMProfile Profile = user.Profile;
                if (Profile != null)
                {
                    Console.WriteLine(Profile.Id);
                    Console.WriteLine(Profile.Name);
                }
                Console.WriteLine(user.Mobile);
                Console.WriteLine(user.LastName);
                Console.WriteLine(user.TimeZone);
                ZCRMUser CreatedBy = user.CreatedBy;
                if (CreatedBy != null)
                {
                    Console.WriteLine(CreatedBy.Id);
                    Console.WriteLine(CreatedBy.FullName);
                }
                Console.WriteLine(user.ZuId);
                Console.WriteLine(user.Confirm);
                Console.WriteLine(user.FullName);
                if (user.Territories != null && user.Territories.Count > 0)
                {
                    foreach (ZCRMTerritory territory in user.Territories)
                    {
                        Console.WriteLine(territory.IsManager);
                        Console.WriteLine(territory.Name);
                        Console.WriteLine(territory.Id);
                    }
                }
                Console.WriteLine(user.Phone);
                Console.WriteLine(user.DateOfBirth);
                Console.WriteLine(user.DateFormat);
                Console.WriteLine(user.Status);
            }
        }



        public List<ZCRMUser> GetUser()
        {
            ZCRMRestClient.Initialize(Dictionary.config);
            ZCRMRestClient restClient = ZCRMRestClient.GetInstance();
            BulkAPIResponse<ZCRMUser> response = restClient.GetOrganizationInstance().GetAllUsers();
            List<ZCRMUser> allUsers = response.BulkData; //response - list of ZCRMUser instances

            foreach (ZCRMUser user in allUsers)
            {

            }

                return allUsers;
            
        }
   }
}
