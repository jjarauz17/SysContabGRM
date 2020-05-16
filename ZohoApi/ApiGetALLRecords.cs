namespace ZohoApi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ZohoApi.DictionaryData;

    public class ApiGetALLRecords
    {
        /** Get list of records */
        public void GetALLRecords()
        {
            Console.Clear();
            try
            {
                ZCRMRestClient.Initialize(Dictionary.config);
                ZCRMModule moduleIns = ZCRMModule.GetInstance("Leads"); //To get module instance
                List<string> fields = new List<string>() { "Last_Name", "Company" };
                BulkAPIResponse<ZCRMRecord> response = moduleIns.GetRecords(); 
                //To get module records
                //BulkAPIResponse<ZCRMRecord> response = moduleIns.GetRecords(538518000000091501); //Custom view Id of the module.
                //BulkAPIResponse<ZCRMRecord> response = moduleIns.GetRecords(fields); //List of field API names
                //BulkAPIResponse<ZCRMRecord> response = moduleIns.GetRecords(538518000000091501, fields); //Custom view Id with List of field API names.
                //BulkAPIResponse<ZCRMRecord> response = moduleIns.GetRecords(538518000000091501,1,10, fields); //Custom view Id, page, perPage and List of field API names.
                //BulkAPIResponse<ZCRMRecord> response = moduleIns.GetRecords(538518000000091501, "Last_Name", CommonUtil.SortOrder.asc,fields); //Custom view Id, sortByField, sortOrder and List of field API names.
                //BulkAPIResponse<ZCRMRecord> response = moduleIns.GetRecords(538518000000091501, "Last_Name", CommonUtil.SortOrder.asc,1,10, fields); //Custom view Id, sortByField, sortOrder, page, perPage and List of field API names.
                //BulkAPIResponse<ZCRMRecord> response = moduleIns.GetRecords(538518000000091501, "Last_Name", CommonUtil.SortOrder.asc,1,10, "2019-12-25T04:00:00+02:00", fields); //Custom view Id, sortByField, sortOrder, page, perPage, modifiedSince(Header) and List of field API names.

                List<ZCRMRecord> records = response.BulkData; //To get response List of ZCRMRecord.
                foreach (ZCRMRecord record in records)
                {
                    Console.WriteLine(record.EntityId); //To get record id
                    Console.WriteLine(record.ModuleAPIName); //To get module api name
                    Console.WriteLine(record.LookupLabel); //To get lookup object name

                    ZCRMUser createdBy = record.CreatedBy;
                    Console.WriteLine(createdBy.Id); //To get UserId who created the record
                    Console.WriteLine(createdBy.FullName); //To get User name who created the record

                    ZCRMUser modifiedBy = record.ModifiedBy;
                    Console.WriteLine(modifiedBy.Id); //To get UserId who modified the record
                    Console.WriteLine(modifiedBy.FullName); //To get User name who modified the record

                    ZCRMUser owner = record.Owner;
                    Console.WriteLine(owner.Id); //To get record OwnerId
                    Console.WriteLine(owner.FullName);//To get record Owner name

                    Console.WriteLine(record.CreatedTime); //To get record created time
                    Console.WriteLine(record.ModifiedTime); //To get record modified time
                                                            //Console.WriteLine(record.GetFieldValue("Last_Name")); //To get particular field value 

                    if (record.Tags.Count > 0)
                    {
                        foreach (ZCRMTag tagnames in record.Tags)
                        {
                            Console.WriteLine(tagnames.Id);
                            Console.WriteLine(tagnames.Name);
                        }
                        Console.WriteLine("\n\n");
                    }

                    Dictionary<string, object> recordData = record.Data; //Returns record as Dictionary

                    //Console.WriteLine(record.PriceDetails);
                    //foreach (KeyValuePair<string, object> data in record.Data)
                    //{
                    //    if (data.Value is ZCRMRecord recordValue) //If data.Value is ZCRMRecord instance 
                    //    {
                    //        Console.WriteLine(recordValue.EntityId); //To get record id
                    //        Console.WriteLine(recordValue.ModuleAPIName); //To get module api name
                    //        Console.WriteLine(recordValue.LookupLabel); //To get lookup object name
                    //    }
                    //    else if (data.Value is List<string>)
                    //    {
                    //            Console.WriteLine(data.Key);
                    //            foreach (string tag in (List<string>)data.Value)
                    //            {
                    //                Console.WriteLine(tag);
                    //            }
                    //        Console.WriteLine("\n\n");
                    //    }
                    //    else //data.Value is not ZCRMRecord instance
                    //    {
                    //        Console.WriteLine(data.Key + "\t" + data.Value);
                    //    }
                    //}
                    Console.WriteLine("\n\n");

                    /** Fields which start with "$" are considered to be property fields */
                    //Console.WriteLine(record.GetProperty("$fieldName")); //To get a particular property value
                    Dictionary<string, object> properties = record.Properties; //To get record properties as Dictionary
                    foreach (KeyValuePair<string, object> property in properties)
                    {
                        if (property.Value is List<string>) //If value is an array
                        {
                            Console.WriteLine("\n\n" + property.Key);
                            foreach (string data in (List<string>)property.Value)
                            {
                                Console.WriteLine(data + "\t");
                            }
                        }
                        else if (property.Value is Dictionary<string, object>)
                        {
                            Console.WriteLine("\n\n" + property.Key);
                            foreach (KeyValuePair<string, object> data in (Dictionary<string, object>)property.Value)
                            {
                                if (property.Value is Dictionary<string, object>)
                                {
                                    foreach (KeyValuePair<string, object> data1 in (Dictionary<string, object>)data.Value)
                                    {
                                        Console.WriteLine(data1.Key + "\t" + data1.Value);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(data.Key + "\t" + data.Value);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine(property.Key + "\t" + property.Value);
                        }
                    }

                    //To get Related records of a record
                    BulkAPIResponse<ZCRMRecord> relatedlist = record.GetRelatedListRecords("Products"); 
                    /** Related records is of type ZCRMRecord **/
                    List<ZCRMRecord> lists = relatedlist.BulkData; //To get related list data
                    foreach (ZCRMRecord rec in lists)
                    {
                        Console.WriteLine(rec.EntityId); //To get  record id
                        Console.WriteLine(rec.ModuleAPIName); //To get module api name
                    }

                    //To get record notes
                    BulkAPIResponse<ZCRMNote> noteResponse = record.GetNotes(); 
                   //BulkAPIResponse<ZCRMNote> noteResponse = record.GetNotes(1,10); //page, perPage.
                   //BulkAPIResponse<ZCRMNote> noteResponse = record.GetNotes("title", CommonUtil.SortOrder.asc); //sortByField, sortOrder
                   //BulkAPIResponse<ZCRMNote> noteResponse = record.GetNotes("title", CommonUtil.SortOrder.asc,1,10, "2019-12-25T04:00:00+02:00"); //sortByField, sortOrder, page, perPage and modifiedSince(Header)
                    List<ZCRMNote> notes = noteResponse.BulkData;
                    foreach (ZCRMNote note in notes)
                    {
                        Console.WriteLine(note.Id); //To get note id
                        Console.WriteLine(note.Title); //To get note title
                        Console.WriteLine(note.Content); //To get note content

                        ZCRMRecord parentRecord = note.ParentRecord; //To get note's parent record
                        Console.WriteLine(parentRecord.EntityId); //To get note's parent record id
                        Console.WriteLine(parentRecord.ModuleAPIName); // To get note's parent record Module API name

                        ZCRMUser noteCreatedBy = note.CreatedBy;
                        Console.WriteLine(noteCreatedBy.Id); //To get UserId who created the notes
                        Console.WriteLine(noteCreatedBy.FullName); //To get User name who created the notes

                        ZCRMUser noteModifiedBy = note.ModifiedBy;
                        Console.WriteLine(noteModifiedBy.Id); //To get UserId who modified the notes
                        Console.WriteLine(noteModifiedBy.FullName); //To get User name who modified the notes

                        ZCRMUser noteOwner = note.NotesOwner;
                        Console.WriteLine(noteOwner.Id); //To get notes OwnerId
                        Console.WriteLine(noteOwner.FullName); //To get notes Owner name

                        Console.WriteLine(note.CreatedTime); //To get created time of the note
                        Console.WriteLine(note.ModifiedTime); //To get modified time of the note

                        List<ZCRMAttachment> noteAttachment = note.Attachments; //To get attachments of the note record
                        if (noteAttachment != null) //check If attachments is empty/not
                        {
                            foreach (ZCRMAttachment attachment in noteAttachment)
                            {
                                Console.WriteLine(attachment.Id); //To get the note's attachment id
                                Console.WriteLine(attachment.FileName); //To get the note's attachment file name
                                Console.WriteLine(attachment.FileType); //To get the note's attachment file type
                                Console.WriteLine(attachment.Size); //To get the note's attachment file size

                                ZCRMRecord attachmentRecord = attachment.ParentRecord;
                                Console.WriteLine(attachmentRecord.EntityId); //To get the note's parent record id
                                Console.WriteLine(attachmentRecord.ModuleAPIName); //To get the record name

                                ZCRMUser noteAttachmentCreatedBy = note.CreatedBy;
                                Console.WriteLine(noteAttachmentCreatedBy.Id); // To get user_id who created the note's attachment
                                Console.WriteLine(noteAttachmentCreatedBy.FullName); //To get user name who created the note's attachment

                                ZCRMUser noteAttachmentModifiedBy = note.ModifiedBy;
                                Console.WriteLine(noteAttachmentModifiedBy.Id); //To get user_id who modified the note's attachment
                                Console.WriteLine(noteAttachmentModifiedBy.FullName); //To get user name who modified the note's attachment

                                ZCRMUser noteAttachmentOwner = note.NotesOwner;
                                Console.WriteLine(noteAttachmentOwner.Id); //To get the note's attachment owner id
                                Console.WriteLine(noteAttachmentOwner.FullName); //To get the note's attachment owner name

                                Console.WriteLine(attachment.CreatedTime); //To get attachment created time
                                Console.WriteLine(attachment.ModifiedTime); //To get attachment modified time

                            }
                        }
                    }

                    //To get record's attachments 
                    BulkAPIResponse<ZCRMAttachment> attachmentResponse = record.GetAttachments();
                    //BulkAPIResponse<ZCRMAttachment> attachmentResponse = record.GetAttachments(0,10, "019-12-25T04:00:00+02:00"); 
                    //page, perPage and modifiedSince(Header)
                    // To get list of attachments
                    List<ZCRMAttachment> attachments = attachmentResponse.BulkData; 
                    foreach (ZCRMAttachment attachment in attachments)
                    {
                        Console.WriteLine(attachment.Id); //To get the attachment id
                        Console.WriteLine(attachment.FileName); //To get attachment file name
                        Console.WriteLine(attachment.FileType); // To get attachment file type
                        Console.WriteLine(attachment.Size); //To get attachment file size

                        ZCRMRecord attachmentRecord = attachment.ParentRecord;
                        Console.WriteLine(attachmentRecord.EntityId); //To get the parent record id
                        Console.WriteLine(attachmentRecord.ModuleAPIName); //To get the parent record name

                        ZCRMUser attachmentCreatedBy = attachment.CreatedBy;
                        Console.WriteLine(attachmentCreatedBy.Id); // To get user_id who created the  attachment
                        Console.WriteLine(attachmentCreatedBy.FullName); //To get user name who created the  attachment

                        ZCRMUser attachmentModifiedBy = attachment.ModifiedBy;
                        Console.WriteLine(attachmentModifiedBy.Id); //To get user_id who modified the attachment
                        Console.WriteLine(attachmentModifiedBy.FullName); //To get user name who modified the attachment

                        ZCRMUser noteAttachmentOwner = attachment.Owner;
                        Console.WriteLine(noteAttachmentOwner.Id); //To get the attachment owner id
                        Console.WriteLine(noteAttachmentOwner.FullName); //To get the attachment owner name

                        Console.WriteLine(attachment.CreatedTime); //To get attachment created time
                        Console.WriteLine(attachment.ModifiedTime); //To get attachment modified time

                        //FileAPIResponse fResponse = attachment.DownloadFile(); 
                        //To download the attachment file
                        //Console.WriteLine("File Name:" + fResponse.GetFileName()); 
                        // To get attachment file name
                        //Console.WriteLine("HTTP Status Code:" + fResponse.HttpStatusCode); 
                        //To get HTTP status code 
                        //Stream file = fResponse.GetFileAsStream(); 
                        //To get attachment file content
                        //CommonUtil.SaveStreamAsFile("/Users/Desktop/photo", file, fResponse.GetFileName()); 
                        //To write a new file using the same attachment name
                    }


                    ZCRMLayout layout = record.Layout; //To get record layout
                    if (layout != null)
                    {
                        Console.WriteLine(layout.Id); //To get layout_id
                        Console.WriteLine(layout.Name); //To get layout name 
                    }

                    /** Following methods are being used only by Inventory modules */
                    List<ZCRMTax> taxlists = record.TaxList; //To get the tax list
                    foreach (ZCRMTax tax in taxlists)
                    {
                        Console.WriteLine(tax.TaxName); //To get tax name
                        Console.WriteLine(tax.Percentage); //To get tax percentage
                        Console.WriteLine(tax.Value); //To get tax value
                    }

                    List<ZCRMInventoryLineItem> lineItems = record.LineItems; //To get list of line_items
                    foreach (ZCRMInventoryLineItem lineItem in lineItems)
                    {
                        Console.WriteLine(lineItem.Id); //To get lineItem id
                        Console.WriteLine(lineItem.ListPrice); //To get lineItem list price
                        Console.WriteLine(lineItem.Quantity); //To get lineItem quantity
                        Console.WriteLine(lineItem.Description); //To get lineItem description
                        Console.WriteLine(lineItem.Total); //To get lineItem total amount
                        Console.WriteLine(lineItem.Discount); //To get lineItem discount
                        Console.WriteLine(lineItem.DiscountPercentage); //To get lineItem discount percentage
                        Console.WriteLine(lineItem.TotalAfterDiscount); //To get lineItem amount after discount
                        Console.WriteLine(lineItem.TaxAmount); //To get lineItem tax amount
                        Console.WriteLine(lineItem.NetTotal); //To get lineItem net total amount
                        Console.WriteLine(lineItem.UnitPrice); //To get lineItem unit price
                        Console.WriteLine(lineItem.Product.EntityId); //To get line_item product's entity id
                        Console.WriteLine(lineItem.Product.LookupLabel); //To get line_item product's lookup label

                        List<ZCRMTax> linetaxs = lineItem.LineTax; //To get list of line_tax in lineItem
                        foreach (ZCRMTax tax in linetaxs)
                        {
                            Console.WriteLine(tax.TaxName); //To get line tax name
                            Console.WriteLine(tax.Percentage); //To get line tax percentage
                            Console.WriteLine(tax.Value); //To get line tax value
                        }
                    }

                    List<ZCRMPriceBookPricing> pricedetails = record.PriceDetails; //To get the price details array
                    foreach (ZCRMPriceBookPricing pricedetail in pricedetails)
                    {
                        Console.WriteLine(pricedetail.Id); //To get the record's priceId
                        Console.WriteLine(pricedetail.ToRange); //To get the price detail record's to_range
                        Console.WriteLine(pricedetail.FromRange); //To get the price detail record's from_range
                        Console.WriteLine(pricedetail.Discount); //To get the price detail record's discount
                    }
                    /**  End Inventory **/

                    /** Following method is used only by 'Events' module */
                    List<ZCRMEventParticipant> participants = record.Participants; //To get Event record's participants
                    foreach (ZCRMEventParticipant participant in participants)
                    {
                        Console.WriteLine(participant.Id); //To get the record's participant id
                        Console.WriteLine(participant.Name); //To get the record's participant name
                        Console.WriteLine(participant.Email);//To get the record's participant email
                        Console.WriteLine(participant.Type); //To get the record's participant type
                        Console.WriteLine(participant.IsInvited); //To check if the record's participant(s) are invited or not
                        Console.WriteLine(participant.Status); //To get the record's participants' status
                    }
                    /* End Event */
                }

                //Console.WriteLine("Headers"+response.GetResponseHeaders());
                BulkAPIResponse<ZCRMRecord>.ResponseInfo info = response.Info;
                Console.WriteLine(info.AllowedCount);
                Console.WriteLine(info.MoreRecords);
                Console.WriteLine(info.PageNo);
                Console.WriteLine(info.PerPage);
                Console.WriteLine(info.RecordCount);

                Console.WriteLine("RemainingAPICountForThisDay " + response.GetResponseHeaders().AllowedAPICallsPerMinute);
                Console.WriteLine("RemainingAPICountForThisWindow " + response.GetResponseHeaders().RemainingAPICountForThisWindow);
                Console.WriteLine("RemainingTimeForThisWindowReset " + response.GetResponseHeaders().RemainingTimeForThisWindowReset);

            }
            catch (ZCRMException ex)
            {
                Console.WriteLine(ex.Message); //To get ZCRMException error message 
                Console.WriteLine(ex.Source); //To get ZCRMException error source
                Console.WriteLine(ex.StackTrace);//To get ZCRMException stack trace  
            }
        }

    }
}
