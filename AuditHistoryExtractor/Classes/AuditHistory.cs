using System;

namespace AuditHistoryExtractor.Classes
{
    public class AuditHistory
    {
        Guid _RecordId;
        Guid _AuditId;
        int _EntityId;
        int _ActionId;
        int _OperationId;
        string _OldValue;
        string _NewValue;
        DateTime createdOn;
        string _EntityName;
        Guid _userId;
        string _attributeName;
        string _recordKeyValue;
        string _action;
        string _operation;
        string _username;


        public Guid RecordId { get => _RecordId; set => _RecordId = value; }
        public Guid AuditId { get => _AuditId; set => _AuditId = value; }
        public int EntityId { get => _EntityId; set => _EntityId = value; }
        public int ActionId { get => _ActionId; set => _ActionId = value; }
        public int OperationId { get => _OperationId; set => _OperationId = value; }
        public string OldValue { get => _OldValue; set => _OldValue = value; }
        public string NewValue { get => _NewValue; set => _NewValue = value; }
        public DateTime CreatedOn { get => createdOn; set => createdOn = value; }
        public string EntityName { get => _EntityName; set => _EntityName = value; }
        public Guid UserId { get => _userId; set => _userId = value; }
        public string AttributeName { get => _attributeName; set => _attributeName = value; }
        public string RecordKeyValue { get => _recordKeyValue; set => _recordKeyValue = value; }
        public string Action { get => _action; set => _action = value; }
        public string Operation { get => _operation; set => _operation = value; }
        public string Username { get => _username; set => _username = value; }
    }
}
