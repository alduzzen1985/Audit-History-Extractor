using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditHistoryExtractor.AppCode
{
    public class ComboBoxEntityField
    {
        public string Value { set; get; }
        public string Text { set; get; }
        public string AttributeType { set; get; }

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
