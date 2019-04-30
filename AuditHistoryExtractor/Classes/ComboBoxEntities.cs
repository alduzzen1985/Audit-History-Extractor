using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditHistoryExtractor.Classes
{
    public class ComboBoxEntities
    {
        private bool _IsAuditEnabled;
        private string _DisplayName;
        private string _LogicalName;
        private int _ObjectTypeCode;

        public bool IsAuditEnabled { get => _IsAuditEnabled; set => _IsAuditEnabled = value; }
        public string DisplayName { get => _DisplayName; set => _DisplayName = value; }
        public string LogicalName { get => _LogicalName; set => _LogicalName = value; }
        public int ObjectTypeCode { get => _ObjectTypeCode; set => _ObjectTypeCode = value; }
    }
}
