using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using System.Collections.Generic;
using System.Linq;

namespace AuditHistoryExtractor.Classes
{
    public class OptionSetManager
    {

        private IOrganizationService _service;
        private Dictionary<int, string> optionSetValues;



        public OptionSetManager(IOrganizationService service)
        {
            _service = service;
        }


        public void SetupOptionSetValues(string entityLogicalName, string attributeLogicalName)
        {

            var attributeRequest = new RetrieveAttributeRequest
            {
                EntityLogicalName = entityLogicalName,
                LogicalName = attributeLogicalName,
                RetrieveAsIfPublished = true
            };

            var attributeResponse = (RetrieveAttributeResponse)_service.Execute(attributeRequest);
            var attributeMetadata = (EnumAttributeMetadata)attributeResponse.AttributeMetadata;

            optionSetValues = (from o in attributeMetadata.OptionSet.Options
                               select new { Value = o.Value.GetValueOrDefault(0), Text = o.Label.UserLocalizedLabel.Label }).ToDictionary(t => t.Value, t => t.Text);
        }


        public string GetDescriptionOptionSetValue(int value)
        {
            return optionSetValues.ContainsKey(value) ? optionSetValues[value] : "N/A";
        }



    }
}
