using System;

namespace AuditHistoryExtractor.Classes
{
    public class ViewDetail
    {
        private Guid savedqueryid;
        private string name;
        private string fetchXML;

        public Guid Savedqueryid { get => savedqueryid; set => savedqueryid = value; }
        public string Name { get => name; set => name = value; }
        public string FetchXML { get => fetchXML; set => fetchXML = value; }
    }
}
