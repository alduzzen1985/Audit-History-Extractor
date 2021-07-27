using System;

namespace AuditHistoryExtractor.Classes
{
    public class AuditHistory
    {
        public Guid RecordId { get; set; }

        public Guid AuditId { get; set; }

        public int EntityId { get; set; }

        public int ActionId { get; set; }

        public int OperationId { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }
            

        public DateTime CreatedOn { get; set; }

        public string EntityName { get; set; }

        public Guid UserId { get; set; }

        public string AttributeName { get; set; }

        public string RecordKeyValue { get; set; }

        public string Action { get; set; }

        public string Operation { get; set; }

        public string Username { get; set; }


        public Guid LookupOldValue { get; set; }

        public Guid LookupNewValue { get; set; }
    }
}
