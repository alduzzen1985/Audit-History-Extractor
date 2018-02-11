using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditHistoryExtractor.AppCode
{
    public class AuditHistoryRecord
    {
        public String DateOperation { set; get; }
        public String Action { set; get; }
        public String SystemUser { set; get; }
        public String RecordIdentificator { set; get; }
        public String Operation { set; get; }
        public String OldValue { set; get; }
        public String NewValue { set; get; }
    }

   
}
