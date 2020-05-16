﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ZohoApi
{
    public class TagAPIHandler : CommonAPIHandler, IAPIHandler
    {
        private ZCRMModule module;

        private TagAPIHandler(ZCRMModule zcrmModule)
        {
            module = zcrmModule;
        }
        public static TagAPIHandler GetInstance(ZCRMModule zcrmModule = null)
        {
            return new TagAPIHandler(zcrmModule);
        }

        public BulkAPIResponse<ZCRMTag> GetTags()
        {
            try
            {
                requestMethod = APIConstants.RequestMethod.GET;
                urlPath = "settings/tags?module=" + module.ApiName + "";
                BulkAPIResponse<ZCRMTag> response = APIRequest.GetInstance(this).GetBulkAPIResponse<ZCRMTag>();
                List<ZCRMTag> tags = new List<ZCRMTag>();
                JObject responseJSON = response.ResponseJSON;
                if (responseJSON.ContainsKey(APIConstants.TAGS))
                {
                    JArray tagsArray = (JArray)responseJSON[APIConstants.TAGS];
                    foreach (JObject tagDetails in tagsArray)
                    {
                        ZCRMTag tag = ZCRMTag.GetInstance(Convert.ToInt64(tagDetails["id"]));
                        SetTagProperties(tag, tagDetails);
                        tags.Add(tag);
                    }
                }
                response.BulkData = tags;
                return response;
            }
            catch (Exception e) when ((e is ZCRMException))
            {
                ZCRMLogger.LogError(e);
                throw new ZCRMException(APIConstants.SDK_ERROR, e);
            }
        }

        public APIResponse GetTagCount(long? tagId)
        {
            try
            {
                requestMethod = APIConstants.RequestMethod.GET;
                urlPath = "settings/tags/" + tagId + "/actions/records_count?module=" + module.ApiName + "";

                APIResponse response = APIRequest.GetInstance(this).GetAPIResponse();

                JObject responseJSON = response.ResponseJSON;
                ZCRMTag tag = ZCRMTag.GetInstance(Convert.ToInt64(tagId));
                SetTagProperties(tag, responseJSON);
                response.Data = tag;
                return response;
            }
            catch (Exception e) when (!(e is ZCRMException))
            {
                ZCRMLogger.LogError(e);
                throw new ZCRMException(APIConstants.SDK_ERROR, e);
            }
        }

        public BulkAPIResponse<ZCRMTag> CreateTags(List<ZCRMTag> tags)
        {
            if (tags.Count > 50)
            {
                throw new ZCRMException(APIConstants.API_MAX_TAGS_MSG);
            }
            try
            {
                requestMethod = APIConstants.RequestMethod.POST;
                urlPath = "settings/tags?module=" + module.ApiName;
                JObject requestBodyObject = new JObject();
                JArray dataArray = new JArray();
                foreach (ZCRMTag tag in tags)
                {
                    if (tag.Id == null)
                    {
                        dataArray.Add(GetZCRMTagAsJSON(tag));
                    }
                    else
                    {
                        throw new ZCRMException("Tag ID MUST be null for CreateTags operation.");
                    }
                }
                requestBodyObject.Add(APIConstants.TAGS, dataArray);
                requestBody = requestBodyObject;
                BulkAPIResponse<ZCRMTag> response = APIRequest.GetInstance(this).GetBulkAPIResponse<ZCRMTag>();
                List<ZCRMTag> createtags = new List<ZCRMTag>();
                List<EntityResponse> responses = response.BulkEntitiesResponse;
                int responseSize = responses.Count;
                for (int i = 0; i < responseSize; i++)
                {
                    EntityResponse entityResponse = responses[i];
                    if (entityResponse.Status.Equals(APIConstants.CODE_SUCCESS))
                    {
                        JObject responseData = entityResponse.ResponseJSON;
                        JObject tagDetails = (JObject)responseData[APIConstants.DETAILS];
                        ZCRMTag newTag = tags[i];
                        SetTagProperties(newTag, tagDetails);
                        createtags.Add(newTag);
                        entityResponse.Data = newTag;
                    }
                    else
                    {
                        entityResponse.Data = null;
                    }
                }
                response.BulkData = createtags;
                return response;
            }
            catch (Exception e) when ((e is ZCRMException))
            {
                ZCRMLogger.LogError(e);
                throw new ZCRMException(APIConstants.SDK_ERROR, e);
            }
        }

        public BulkAPIResponse<ZCRMTag> UpdateTags(List<ZCRMTag> tags)
        {
            if (tags.Count > 50)
            {
                throw new ZCRMException(APIConstants.API_MAX_TAGS_MSG);
            }
            try
            {
                requestMethod = APIConstants.RequestMethod.PUT;
                urlPath = "settings/tags?module=" + module.ApiName + "";
                JObject requestBodyObject = new JObject();
                JArray dataArray = new JArray();
                foreach (ZCRMTag tag in tags)
                {
                    dataArray.Add(GetZCRMTagAsJSON(tag));
                }
                requestBodyObject.Add(APIConstants.TAGS, dataArray);
                requestBody = requestBodyObject;
                BulkAPIResponse<ZCRMTag> response = APIRequest.GetInstance(this).GetBulkAPIResponse<ZCRMTag>();
                List<ZCRMTag> updatetags = new List<ZCRMTag>();
                List<EntityResponse> responses = response.BulkEntitiesResponse;
                int responseSize = responses.Count;
                for (int i = 0; i < responseSize; i++)
                {
                    EntityResponse entityResponse = responses[i];
                    if (entityResponse.Status.Equals(APIConstants.CODE_SUCCESS))
                    {
                        JObject responseData = entityResponse.ResponseJSON;
                        JObject tagDetails = (JObject)responseData[APIConstants.DETAILS];
                        ZCRMTag updatedTag = tags[i];
                        SetTagProperties(updatedTag, tagDetails);
                        updatetags.Add(updatedTag);
                        entityResponse.Data = updatedTag;
                    }
                    else
                    {
                        entityResponse.Data = null;
                    }
                }
                response.BulkData = updatetags;
                return response;
            }
            catch (Exception e) when ((e is ZCRMException))
            {
                ZCRMLogger.LogError(e);
                throw new ZCRMException(APIConstants.SDK_ERROR, e);
            }
        }

        public APIResponse Delete(long? tagid)
        {
            try
            {
                requestMethod = APIConstants.RequestMethod.DELETE;
                urlPath = "settings/tags/" + tagid;
                return APIRequest.GetInstance(this).GetAPIResponse();
            }
            catch (Exception e) when (!(e is ZCRMException))
            {
                ZCRMLogger.LogError(e);
                throw new ZCRMException(APIConstants.SDK_ERROR, e);
            }
        }

        public APIResponse Merge(long? tagId, long? mergetagId)
        {
            try
            {
                requestMethod = APIConstants.RequestMethod.POST;
                urlPath = "settings/tags/" + mergetagId + "/actions/merge";

                JObject requestBodyObject = new JObject();
                JArray dataArray = new JArray();
                JObject TagJSON = new JObject();
                TagJSON.Add("conflict_id", tagId);
                dataArray.Add(TagJSON);
                requestBodyObject.Add(APIConstants.TAGS, dataArray);
                requestBody = requestBodyObject;

                APIResponse response = APIRequest.GetInstance(this).GetAPIResponse();
                JArray responseDataArray = (JArray)response.ResponseJSON[APIConstants.TAGS];
                JObject responseData = (JObject)responseDataArray[0];
                JObject tagDetails = (JObject)responseData[APIConstants.DETAILS];
                ZCRMTag mergetag = ZCRMTag.GetInstance(Convert.ToInt64(tagDetails["id"]));
                SetTagProperties(mergetag, tagDetails);
                response.Data = mergetag;
                return response;
            }
            catch (Exception e) when (!(e is ZCRMException))
            {
                ZCRMLogger.LogError(e);
                throw new ZCRMException(APIConstants.SDK_ERROR, e);
            }
        }

        public APIResponse Update(ZCRMTag tag)
        {
            try
            {
                requestMethod = APIConstants.RequestMethod.PUT;
                urlPath = "settings/tags/" + tag.Id + "?module=" + tag.ModuleApiName;

                JObject requestBodyObject = new JObject();
                JArray dataArray = new JArray();
                JObject TagJSON = new JObject();
                TagJSON.Add("name", tag.Name);
                dataArray.Add(TagJSON);
                requestBodyObject.Add(APIConstants.TAGS, dataArray);
                requestBody = requestBodyObject;

                APIResponse response = APIRequest.GetInstance(this).GetAPIResponse();
                JArray responseDataArray = (JArray)response.ResponseJSON[APIConstants.TAGS];
                JObject responseData = (JObject)responseDataArray[0];
                JObject tagDetails = (JObject)responseData[APIConstants.DETAILS];
                ZCRMTag updatetag = tag;
                SetTagProperties(updatetag, tagDetails);
                response.Data = updatetag;
                return response;
            }
            catch (Exception e) when (!(e is ZCRMException))
            {
                ZCRMLogger.LogError(e);
                throw new ZCRMException(APIConstants.SDK_ERROR, e);
            }
        }

        public APIResponse AddTags(ZCRMRecord record, List<string> tagNames)
        {
            if (tagNames.Count > 10)
            {
                throw new ZCRMException(APIConstants.API_MAX_RECORD_TAGS_MSG);
            }
            try
            {
                string tagname = "";
                requestMethod = APIConstants.RequestMethod.POST;
                foreach (string name in tagNames)
                {
                    tagname += name + ",";
                }
                urlPath = "" + record.ModuleAPIName + "/" + record.EntityId + "/actions/add_tags?tag_names=" + tagname + "";
                APIResponse response = APIRequest.GetInstance(this).GetAPIResponse();
                JArray responseDataArray = (JArray)response.ResponseJSON[APIConstants.DATA];
                JObject responseData = (JObject)responseDataArray[0];
                JObject recordDetails = (JObject)responseData[APIConstants.DETAILS];
                ZCRMRecord tag = record;
                EntityAPIHandler.GetInstance(tag).SetRecordProperties(recordDetails);
                response.Data = tag;
                return response;
            }
            catch (Exception e) when (!(e is ZCRMException))
            {
                ZCRMLogger.LogError(e);
                throw new ZCRMException(APIConstants.SDK_ERROR, e);
            }
        }

        public BulkAPIResponse<ZCRMRecord> AddTagsToRecords(List<long> recordId, List<string> tagNames)
        {
            if (tagNames.Count > 10)
            {
                throw new ZCRMException(APIConstants.API_MAX_RECORD_TAGS_MSG);
            }
            if (recordId.Count > 100)
            {
                throw new ZCRMException(APIConstants.API_MAX_RECORDS_MSG);
            }
            try
            {
                string tagname = "", recordid = "";
                requestMethod = APIConstants.RequestMethod.POST;
                foreach (long id in recordId)
                {
                    recordid += id + ",";
                }
                foreach (string tag in tagNames)
                {
                    tagname += tag + ",";
                }
                urlPath = "" + module.ApiName + "/actions/add_tags?ids=" + recordid + "&tag_names=" + tagname + "";
                BulkAPIResponse<ZCRMRecord> response = APIRequest.GetInstance(this).GetBulkAPIResponse<ZCRMRecord>();
                List<ZCRMRecord> addtags = new List<ZCRMRecord>();
                List<EntityResponse> responses = response.BulkEntitiesResponse;
                foreach (EntityResponse entityResponse in responses)
                {
                    if (entityResponse.Status.Equals(APIConstants.CODE_SUCCESS))
                    {
                        JObject responseData = entityResponse.ResponseJSON;
                        JObject tagDetails = (JObject)responseData[APIConstants.DETAILS];
                        ZCRMRecord addTag = ZCRMRecord.GetInstance(module.ApiName, Convert.ToInt64(tagDetails["id"]));
                        EntityAPIHandler.GetInstance(addTag).SetRecordProperties(tagDetails);
                        addtags.Add(addTag);
                        entityResponse.Data = addTag;
                    }
                    else
                    {
                        entityResponse.Data = null;
                    }
                }
                response.BulkData = addtags;
                return response;
            }
            catch (Exception e) when (!(e is ZCRMException))
            {
                ZCRMLogger.LogError(e);
                throw new ZCRMException(APIConstants.SDK_ERROR, e);
            }
        }

        public APIResponse RemoveTags(ZCRMRecord record, List<string> tagNames)
        {
            if (tagNames.Count > 10)
            {
                throw new ZCRMException(APIConstants.API_MAX_RECORD_TAGS_MSG);
            }
            try
            {
                string tagname = "";
                requestMethod = APIConstants.RequestMethod.POST;
                foreach (string name in tagNames)
                {
                    tagname += name + ",";
                }
                urlPath = "" + record.ModuleAPIName + "/" + record.EntityId + "/actions/remove_tags?tag_names=" + tagname + "";
                APIResponse response = APIRequest.GetInstance(this).GetAPIResponse();
                JArray responseDataArray = (JArray)response.ResponseJSON[APIConstants.DATA];
                JObject responseData = (JObject)responseDataArray[0];
                JObject recordDetails = (JObject)responseData[APIConstants.DETAILS];
                ZCRMRecord tag = record;
                EntityAPIHandler.GetInstance(tag).SetRecordProperties(recordDetails);
                response.Data = tag;
                return response;
            }
            catch (Exception e) when (!(e is ZCRMException))
            {
                ZCRMLogger.LogError(e);
                throw new ZCRMException(APIConstants.SDK_ERROR, e);
            }
        }

        public BulkAPIResponse<ZCRMRecord> RemoveTagsFromRecords(List<long> recordId, List<string> tagNames)
        {
            if (tagNames.Count > 10)
            {
                throw new ZCRMException(APIConstants.API_MAX_RECORD_TAGS_MSG);
            }
            if (recordId.Count > 100)
            {
                throw new ZCRMException(APIConstants.API_MAX_RECORDS_MSG);
            }
            try
            {
                string tagname = "", recordid = "";
                requestMethod = APIConstants.RequestMethod.POST;
                foreach (long id in recordId)
                {
                    recordid += id + ",";
                }
                foreach (string tag in tagNames)
                {
                    tagname += tag + ",";
                }
                urlPath = "" + module.ApiName + "/actions/remove_tags?ids=" + recordid + "&tag_names=" + tagname + "";
                BulkAPIResponse<ZCRMRecord> response = APIRequest.GetInstance(this).GetBulkAPIResponse<ZCRMRecord>();
                List<ZCRMRecord> removetags = new List<ZCRMRecord>();
                List<EntityResponse> responses = response.BulkEntitiesResponse;
                foreach (EntityResponse entityResponse in responses)
                {
                    if (entityResponse.Status.Equals(APIConstants.CODE_SUCCESS))
                    {
                        JObject responseData = entityResponse.ResponseJSON;
                        JObject tagDetails = (JObject)responseData[APIConstants.DETAILS];
                        ZCRMRecord removeTag = ZCRMRecord.GetInstance(module.ApiName, Convert.ToInt64(tagDetails["id"]));
                        EntityAPIHandler.GetInstance(removeTag).SetRecordProperties(tagDetails);
                        removetags.Add(removeTag);
                        entityResponse.Data = removeTag;
                    }
                    else
                    {
                        entityResponse.Data = null;
                    }
                }
                response.BulkData = removetags;
                return response;
            }
            catch (Exception e) when (!(e is ZCRMException))
            {
                ZCRMLogger.LogError(e);
                throw new ZCRMException(APIConstants.SDK_ERROR, e);
            }
        }

        private void SetTagProperties(ZCRMTag tag, JObject tagDetails)
        {
            foreach (KeyValuePair<string, JToken> token in tagDetails)
            {
                string fieldAPIName = token.Key;
                if (fieldAPIName.Equals("id"))
                {
                    tag.Id = Convert.ToInt64(token.Value);
                }
                if (fieldAPIName.Equals("name"))
                {
                    tag.Name = Convert.ToString(token.Value);
                }
                else if (fieldAPIName.Equals("created_by") && token.Value.Type != JTokenType.Null)
                {
                    JObject createdObject = (JObject)token.Value;
                    ZCRMUser createdUser = ZCRMUser.GetInstance(Convert.ToInt64(createdObject["id"]), (string)createdObject["name"]);
                    tag.CreatedBy = createdUser;
                }
                else if (fieldAPIName.Equals("modified_by") && token.Value.Type != JTokenType.Null)
                {
                    JObject modifiedObject = (JObject)token.Value;
                    ZCRMUser modifiedBy = ZCRMUser.GetInstance(Convert.ToInt64(modifiedObject["id"]), (string)modifiedObject["name"]);
                    tag.ModifiedBy = modifiedBy;
                }
                else if (fieldAPIName.Equals("created_time"))
                {
                    tag.CreatedTime = CommonUtil.removeEscaping((string)JsonConvert.SerializeObject(token.Value));
                }
                else if (fieldAPIName.Equals("modified_time"))
                {
                    tag.ModifiedTime = CommonUtil.removeEscaping((string)JsonConvert.SerializeObject(token.Value));
                }
                else if (fieldAPIName.Equals("count"))
                {
                    tag.Count = Convert.ToInt32(token.Value);
                }
            }
        }


        public JObject GetZCRMTagAsJSON(ZCRMTag tagvalue)
        {
            JObject TagJSON = new JObject();
            if (tagvalue.Name != null)
            {
                TagJSON.Add("name", tagvalue.Name);
            }
            if (tagvalue.Id != 0)
            {
                TagJSON.Add("id", tagvalue.Id);
            }
            return TagJSON;
        }
    }
}
