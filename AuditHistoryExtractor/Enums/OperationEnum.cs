using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditHistoryExtractor.Enums
{
    public class Operation
    {
        public int operationid { set; get; }
        public string description { set; get; }

        public Operation(int operationid, string description)
        {
            this.operationid = operationid;
            this.description = description;
        }
    }
}
