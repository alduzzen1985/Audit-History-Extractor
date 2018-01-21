using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditHistoryExtractor.AppCode
{
    public class AuditHistoryManager
    {
        private StringBuilder csvFile;
        private IOrganizationService _service;
        private string separator;


        public AuditHistoryManager(IOrganizationService service, string identificatorField, string separator)
        {
            csvFile = new StringBuilder();
            this.separator = separator;
            csvFile.AppendFormat("Date§Action§System User§{0}§Operation§OldValue§NewValue\n", identificatorField).Replace("§", separator);
            _service = service;
        }

        /// <summary>
        /// Write a line in the file
        /// </summary>
        /// <param name="entityID">ID of the Account</param>
        /// <param name="identificatorField">Identificator of the Row</param>
        /// <param name="attributeName">Name of the attribute to retrieve for Audit History</param>
        /// <param name="fileName">File to write</param>
        public void WriteFileAuditHistory(Guid entityID, string entityLogicalName, string identificatorField, string attributeName, string fileName)
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
                GetLineForCSV(detail, identificatorField);
            }
            try
            {
                System.IO.File.WriteAllText(fileName, csvFile.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible write the file. Be sure that the file isn't used");
            }
        }


        /// <summary>
        /// Write a line in the file
        /// </summary>
        /// <param name="detail">Audit row retrieved</param>
        /// <param name="identificatorField">Account number</param>
        private void GetLineForCSV(AuditDetail detail, string identificatorField)
        {
            Audit record = (Audit)detail.AuditRecord;
            string date = record.CreatedOn.Value.ToLocalTime().ToString();
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


                    csvFile.AppendFormat("{0}§{1}§{2}§{3}§{4}§{5}§{6}\n", date, action, user, identificatorField, operation, GetValueForCsv(oldValue), GetValueForCsv(newValue)).Replace("§", separator);
                    Console.WriteLine("Attribute: {0}, old value: {1}, new value: {2}", attribute.Key, GetValueForCsv(oldValue), GetValueForCsv(newValue));
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

                        csvFile.AppendFormat("{0}§{1}§{2}§{3}§{4}§{5}§{6}\n", date, action, user, identificatorField, operation, GetValueForCsv(oldValue), GetValueForCsv(newValue)).Replace("§", separator);
                        Console.WriteLine("Attribute: {0}, old value: {1}, new value: {2}", attribute.Key, GetValueForCsv(oldValue), GetValueForCsv(newValue));
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

    }
}
