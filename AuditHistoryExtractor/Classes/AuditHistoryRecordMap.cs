using CsvHelper.Configuration;

namespace AuditHistoryExtractor.Classes
{
    public sealed class AuditHistoryRecordMap : ClassMap<AuditHistory>
    {
        public AuditHistoryRecordMap(string fieldIdentificatorName)
        {
            Map(m => m.CreatedOn).Name("Date");
            Map(m => m.RecordKeyValue).Name(fieldIdentificatorName);
            Map(m => m.Username).Name("User");
            Map(m => m.Action).Name("Action");
            Map(m => m.AttributeName).Name("Attribute Name");
            Map(m => m.OldValue).Name("Old Value");
            Map(m => m.NewValue).Name("New Value");


        }
    }
}
