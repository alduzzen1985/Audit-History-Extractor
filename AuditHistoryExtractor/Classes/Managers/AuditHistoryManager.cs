using AuditHistoryExtractor.Classes;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;

namespace AuditHistoryExtractor.AppCode
{
    public class AuditHistoryManager
    {
        private IOrganizationService _service;



        private Dictionary<string, OptionSetManager> optionSetManagerDictionary = new Dictionary<string, OptionSetManager>();

        public AuditHistoryManager(IOrganizationService service)
        {
            _service = service;
        }


        private string GetValue(Entity attributeAuditHistoryDetail, string fieldKey)
        {
            string value = string.Empty;
            if (attributeAuditHistoryDetail.Contains(fieldKey))
            {
                bool isOldValueAnEntityReference = attributeAuditHistoryDetail[fieldKey] is EntityReference;
                bool isOldValueTypeMoney = attributeAuditHistoryDetail[fieldKey] is Money;
                bool isTypeOptionSet = attributeAuditHistoryDetail[fieldKey] is OptionSetValue;


                if (isOldValueAnEntityReference) { value = GetValueEntityReference(attributeAuditHistoryDetail[fieldKey] as EntityReference); }
                else if (isOldValueTypeMoney) { value = (attributeAuditHistoryDetail[fieldKey] as Money)?.Value.ToString(); }
                else if (isTypeOptionSet)
                {
                    OptionSetValue optSetValue = (attributeAuditHistoryDetail[fieldKey] as OptionSetValue);

                    if (!optionSetManagerDictionary.ContainsKey(fieldKey))
                    {
                        var optionSetManager = new OptionSetManager(_service);
                        optionSetManager.SetupOptionSetValues(attributeAuditHistoryDetail.LogicalName, fieldKey);
                        optionSetManagerDictionary.Add(fieldKey, optionSetManager);
                    }

                    value = optionSetManagerDictionary[fieldKey].GetDescriptionOptionSetValue(optSetValue.Value);
                }
                else { value = attributeAuditHistoryDetail[fieldKey].ToString(); }
            }
            return value;
        }

        private string GetValueForCsv(string value)
        {
            return string.IsNullOrEmpty(value) ? "(no value)" : value;
        }
        
        private string GetValueEntityReference(EntityReference eRef)
        {
            if (eRef == null) { return string.Empty; }
            else return eRef.Name;
        }


        public List<AuditHistory> GetAuditHistoryForRecord(Guid entityID, string entityLogicalName, string recordKeyValue)
        {
            List<AuditHistory> auditHistoryForRecord = new List<AuditHistory>();
            RetrieveRecordChangeHistoryRequest changeRequest = new RetrieveRecordChangeHistoryRequest();
            changeRequest.Target = new EntityReference(entityLogicalName, entityID);

            RetrieveRecordChangeHistoryResponse changeResponse = (RetrieveRecordChangeHistoryResponse)_service.Execute(changeRequest);
            AuditDetailCollection details = changeResponse.AuditDetailCollection;
            foreach (AuditDetail detail in details.AuditDetails)
            {

                auditHistoryForRecord.AddRange(GetRecordChanges(detail, recordKeyValue));
            }
            return auditHistoryForRecord;

        }


        /// <summary>
        /// Extract the audit history for the record and a specific Field
        /// </summary>
        /// <param name="entityID">ID of the Account</param>
        /// <param name="identificatorField">Identificator of the Row</param>
        /// <param name="attributeName">Name of the attribute to retrieve for Audit History</param>
        /// <param name="fileName">File to write</param>
        public List<AuditHistory> GetAuditHistoryForRecordAndField(Guid entityID, string entityLogicalName, string attributeName, string recordKeyValue)
        {
            List<AuditHistory> auditHistoryForRecord = new List<AuditHistory>();
            var attributeChangeHistoryRequest = new RetrieveAttributeChangeHistoryRequest
            {
                Target = new EntityReference(entityLogicalName, entityID),
                AttributeLogicalName = attributeName,

            };

            RetrieveRecordChangeHistoryRequest changeRequest = new RetrieveRecordChangeHistoryRequest();
            changeRequest.Target = new EntityReference(entityLogicalName, entityID);
            


            RetrieveRecordChangeHistoryResponse changeResponse = (RetrieveRecordChangeHistoryResponse)_service.Execute(changeRequest);
            AuditDetailCollection details = changeResponse.AuditDetailCollection;

            var attributeChangeHistoryResponse = (RetrieveAttributeChangeHistoryResponse)_service.Execute(attributeChangeHistoryRequest);
            details = attributeChangeHistoryResponse.AuditDetailCollection;

            foreach (var detail in details.AuditDetails)
            {
                //AuditHistory change = GetRecordChanges(detail);

                auditHistoryForRecord.AddRange(GetRecordChanges(detail, recordKeyValue));
                //if (change != null)
                //{
                //    change.RecordKeyValue = recordKeyValue;
                //    auditHistoryForRecord.Add(change);
                //}
            }
            return auditHistoryForRecord;
        }


        private List<AuditHistory> GetRecordChanges(AuditDetail detail, string recordKeyValue = "")
        {
            AuditHistory auditHistory = new AuditHistory();
            Entity record = (Entity)detail.AuditRecord;
            List<AuditHistory> lsChanges = new List<AuditHistory>();
            // Write out some of the change history information in the audit record. 
            

            Console.WriteLine("\nAudit record created on: {0}", record.GetAttributeValue<DateTime>("createdon").ToLocalTime());
            Console.WriteLine("Entity: {0}, Action: {1}, Operation: {2}, Transaction Id {3}", record.GetAttributeValue<EntityReference>("objectid").LogicalName, record.FormattedValues["action"], record.FormattedValues["operation"], record.GetAttributeValue<Guid>("auditid").ToString());


            Console.WriteLine("USER : {0}", record.GetAttributeValue<EntityReference>("userid").Name);
            // Show additional details for certain AuditDetail sub-types.
            var detailType = detail.GetType();
            if (detailType == typeof(AttributeAuditDetail) && ((AttributeAuditDetail)detail).NewValue != null)
            {
                var attributeDetail = (AttributeAuditDetail)detail;

                // Display the old and new attribute values.
                foreach (KeyValuePair<String, object> attribute in attributeDetail.NewValue.Attributes)
                {
                    auditHistory = new AuditHistory();
                    FillAuditRecordWithBaseInfo(auditHistory, record);
                    auditHistory.RecordKeyValue = recordKeyValue;
                    String oldValue = "(no value)", newValue = "(no value)";

                    //TODO Display the lookup values of those attributes that do not contain strings.
                    if (attributeDetail.OldValue.Contains(attribute.Key))
                    {
                        oldValue = GetValue(attributeDetail.OldValue, attribute.Key);
                    }

                    newValue = GetValue(attributeDetail.NewValue, attribute.Key);

                    Console.WriteLine("Attribute: {0}, old value: {1}, new value: {2}", attribute.Key, oldValue, newValue);


                    auditHistory.OldValue = oldValue;
                    auditHistory.NewValue = newValue;
                    auditHistory.AttributeName = attribute.Key;



                    lsChanges.Add(auditHistory);
                }

                foreach (KeyValuePair<String, object> attribute in attributeDetail.OldValue.Attributes)
                {
                    if (!attributeDetail.NewValue.Contains(attribute.Key))
                    {
                        auditHistory = new AuditHistory();
                        FillAuditRecordWithBaseInfo(auditHistory, record);
                        String newValue = "(no value)";

                        //TODO Display the lookup values of those attributes that do not contain strings.
                        String oldValue = GetValue(attributeDetail.OldValue, attribute.Key);// attributeDetail.OldValue[attribute.Key].ToString();
                        Console.WriteLine("Attribute: {0}, old value: {1}, new value: {2}", attribute.Key, oldValue, newValue);

                        auditHistory.OldValue = oldValue;
                        auditHistory.NewValue = newValue;
                        auditHistory.AttributeName = attribute.Key;

                        lsChanges.Add(auditHistory);
                    }
                }
            }
            else
            {
                auditHistory = null;
            }
            return lsChanges;
        }

        private static void FillAuditRecordWithBaseInfo(AuditHistory auditHistory, Entity record)
        {
            auditHistory.EntityName = record.GetAttributeValue<EntityReference>("objectid").LogicalName;
            auditHistory.CreatedOn = record.GetAttributeValue<DateTime>("createdon");
            auditHistory.ActionId = record.GetAttributeValue<OptionSetValue>("action").Value;
            auditHistory.OperationId = record.GetAttributeValue<OptionSetValue>("operation").Value;
            auditHistory.AuditId = record.GetAttributeValue<Guid>("auditid");
            auditHistory.UserId = record.GetAttributeValue<EntityReference>("userid").Id;
            auditHistory.RecordId = record.GetAttributeValue<EntityReference>("objectid").Id;
            if (record.FormattedValues.Contains("action")) { auditHistory.Action = record.FormattedValues["action"]; }
            if (record.FormattedValues.Contains("operation")) { auditHistory.Operation = record.FormattedValues["operation"]; }
            if (record.GetAttributeValue<EntityReference>("userid") != null) { auditHistory.Username = record.GetAttributeValue<EntityReference>("userid").Name; }
        }
    }
}
