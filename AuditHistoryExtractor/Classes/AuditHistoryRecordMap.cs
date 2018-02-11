using AuditHistoryExtractor.AppCode;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditHistoryExtractor.Classes
{
    public sealed class AuditHistoryRecordMap : ClassMap<AuditHistoryRecord>
    {
        public AuditHistoryRecordMap()
        {
            Map(m => m.DateOperation).Name("Date");
            Map(m => m.RecordIdentificator).Name("Identificator");
            Map(m => m.SystemUser).Name("User");
            Map(m => m.Action).Name("Action");
            Map(m => m.NewValue).Name("New Value");
            Map(m => m.OldValue).Name("Old Value");
        }
    }
}
