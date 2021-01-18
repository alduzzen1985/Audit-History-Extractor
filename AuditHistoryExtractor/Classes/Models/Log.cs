using AuditHistoryExtractor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditHistoryExtractor.Classes.Models
{
    public class Log : IEquatable<Log>
    {
        public string Message
        {
            get
            {
                if (NumberOfChanges == 0) return "No changes found.";
                else return $"{NumberOfChanges} changes found.";
            }
        }
        public string RecordKeyValue { set; get; }
        public Guid recordId { set; get; }

        public InfoLogEnum infoLog
        {
            get
            {
                return (NumberOfChanges > 0) ? Enums.InfoLogEnum.Success : Enums.InfoLogEnum.Info;
            }
        }

        public int NumberOfChanges { set; get; }

        public bool Equals(Log other)
        {
            if ((recordId == null || other.recordId == null || recordId.Equals(Guid.Empty) || other.recordId.Equals(Guid.Empty)))
            {
                return false;
            }
            else
            {
                return recordId.Equals(other.recordId);
            }
        }


        public void AddNumberOfChanges(int nChanges)
        {
            this.NumberOfChanges += nChanges;
        }



    }
}
