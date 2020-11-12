using AuditHistoryExtractor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditHistoryExtractor.Classes.Models
{
    public class Log
    {
        public string Message { set; get; }
        public string RecordKeyValue { set; get; }
        public Guid recordId { set; get; }

        public InfoLogEnum infoLog { set; get; }
    }
}
