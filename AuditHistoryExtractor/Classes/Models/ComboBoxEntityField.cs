using Microsoft.Xrm.Sdk.Metadata;

namespace AuditHistoryExtractor.AppCode
{
    public class ComboBoxEntityField
    {
        public string Value { set; get; }
        public string Text { set; get; }
        public string AttributeType { set; get; }

        public string DisplayName { set; get; }


        public ComboBoxEntityField()
        {

        }


        public ComboBoxEntityField(AttributeMetadata attributeMetadataInfo)
        {
            if (attributeMetadataInfo.DisplayName.UserLocalizedLabel != null)
            {
                Text = attributeMetadataInfo.DisplayName.UserLocalizedLabel.Label + " (" + attributeMetadataInfo.LogicalName + ")";
                Value = attributeMetadataInfo.LogicalName;
                AttributeType = attributeMetadataInfo.AttributeTypeName.Value;
            }
        }
    }
}
