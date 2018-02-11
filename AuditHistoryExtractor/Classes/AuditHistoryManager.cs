using AuditHistoryExtractor.Classes;
using CsvHelper;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditHistoryExtractor.AppCode
{
    public class AuditHistoryManager
    {
        private const string ErrorMessageUnableToWrite = "Impossible write the file. Be sure that the file isn't used";

        CsvWriter csvWriter;
        private IOrganizationService _service;
        private string delimiter;
        private List<AuditHistoryRecord> lsAuditHistoryRecords;

        public AuditHistoryManager(IOrganizationService service, string identificatorField, string delimiter)
        {
            lsAuditHistoryRecords = new List<AuditHistoryRecord>();
            this.delimiter = delimiter;
            _service = service;
        }

        /// <summary>
        /// Extract the audit history for the record
        /// </summary>
        /// <param name="entityID">ID of the Account</param>
        /// <param name="identificatorField">Identificator of the Row</param>
        /// <param name="attributeName">Name of the attribute to retrieve for Audit History</param>
        /// <param name="fileName">File to write</param>
        public void ExtractAuditHistoryForRecord(Guid entityID, string entityLogicalName, string identificatorField, string attributeName)
        {

            var attributeChangeHistoryRequest = new RetrieveAttributeChangeHistoryRequest
            {
                Target = new EntityReference(entityLogicalName, entityID),
                AttributeLogicalName = attributeName
            };

            RetrieveRecordChangeHistoryRequest changeRequest = new RetrieveRecordChangeHistoryRequest();
            changeRequest.Target = new EntityReference(entityLogicalName, entityID);

            RetrieveRecordChangeHistoryResponse changeResponse = (RetrieveRecordChangeHistoryResponse)_service.Execute(changeRequest);
            AuditDetailCollection details = changeResponse.AuditDetailCollection;

            var attributeChangeHistoryResponse = (RetrieveAttributeChangeHistoryResponse)_service.Execute(attributeChangeHistoryRequest);

            details = attributeChangeHistoryResponse.AuditDetailCollection;

            foreach (var detail in details.AuditDetails)
            {
                GetRecordChanges(detail, identificatorField);
            }

        }


        /// <summary>
        /// Get the record for the Audit History
        /// </summary>
        /// <param name="detail">Audit row retrieved</param>
        /// <param name="identificatorField">Account number</param>
        private void GetRecordChanges(AuditDetail detail, string identificatorField)
        {


            Entity record = (Entity)detail.AuditRecord;
            string date = record.GetAttributeValue<DateTime>("createdon").ToLocalTime().ToString();
            string action = record.FormattedValues["action"];
            string operation = record.FormattedValues["operation"];
            string user = (record["userid"] as EntityReference).Name;

            EntityReference newValueRef = null;


            var detailType = detail.GetType();
            if (detailType == typeof(AttributeAuditDetail))
            {
                var attributeDetail = (AttributeAuditDetail)detail;

                // Display the old and new attribute values.
                foreach (KeyValuePair<String, object> attribute in attributeDetail.NewValue.Attributes)
                {
                    String oldValue = "(no value)", newValue = "(no value)";

                    //TODO Display the lookup values of those attributes that do not contain strings.
                    if (attributeDetail.OldValue.Contains(attribute.Key))
                    {
                        bool isOldValueAnEntityReference = attributeDetail.OldValue[attribute.Key].GetType().Equals(typeof(EntityReference));
                        if (isOldValueAnEntityReference) { oldValue = GetValueEntityReference(attributeDetail.OldValue[attribute.Key] as EntityReference); }
                        else { oldValue = attributeDetail.OldValue[attribute.Key].ToString(); }
                    }
                    else
                    {
                        oldValue = string.Empty;
                    }


                    bool isNewValueAnEntityReference = attributeDetail.NewValue[attribute.Key].GetType().Equals(typeof(EntityReference));
                    if (isNewValueAnEntityReference) { newValue = GetValueEntityReference(attributeDetail.NewValue[attribute.Key] as EntityReference); }
                    else { newValue = attributeDetail.NewValue[attribute.Key].ToString(); }


                    newValueRef = attributeDetail.NewValue[attribute.Key] as EntityReference;


                    lsAuditHistoryRecords.Add(new AuditHistoryRecord()
                    {
                        DateOperation = date,
                        Action = action,
                        SystemUser = user,
                        RecordIdentificator = identificatorField,
                        Operation = operation,
                        NewValue = newValue,
                        OldValue = oldValue
                    });

                }

                foreach (KeyValuePair<String, object> attribute in attributeDetail.OldValue.Attributes)
                {
                    if (!attributeDetail.NewValue.Contains(attribute.Key))
                    {
                        String newValue = "(no value)";

                        //TODO Display the lookup values of those attributes that do not contain strings.
                        String oldValue = "";

                        bool isOldValueAnEntityReference = attributeDetail.OldValue[attribute.Key].GetType().Equals(typeof(EntityReference));
                        if (isOldValueAnEntityReference) { oldValue = GetValueEntityReference(attributeDetail.OldValue[attribute.Key] as EntityReference); }
                        else { oldValue = attributeDetail.OldValue[attribute.Key].ToString(); }



                        lsAuditHistoryRecords.Add(new AuditHistoryRecord()
                        {
                            DateOperation = date,
                            Action = action,
                            SystemUser = user,
                            RecordIdentificator = identificatorField,
                            Operation = operation,
                            NewValue = newValue,
                            OldValue = oldValue
                        });
                    }
                }
            }
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


        public void WriteFile(string fileName)
        {
            try
            {
                using (TextWriter writer = new StreamWriter(fileName))
                {
                    csvWriter = new CsvWriter(writer);
                    csvWriter.Configuration.Delimiter = delimiter;
                    csvWriter.Configuration.QuoteAllFields = true;
                    csvWriter.Configuration.RegisterClassMap(new AuditHistoryRecordMap());
                    csvWriter.WriteRecords(lsAuditHistoryRecords); // where values implements IEnumerable
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ErrorMessageUnableToWrite);
            }
        }
    }
}
