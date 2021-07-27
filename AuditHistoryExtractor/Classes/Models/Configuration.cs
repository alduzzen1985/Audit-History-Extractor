using AuditHistoryExtractor.AppCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditHistoryExtractor.Classes.Models
{
    public class Configuration
    {
        public List<int> SelectedOperations { set; get; }
        public List<int> SelectedActions { set; get; }
        public DateTime? DateFrom { set; get; }
        public DateTime? DateTo { set; get; }
        public List<string> ListAttributes { set; get; }
        public List<Guid> SelectedUsers { set; get; }

        public string OrganizationID { set; get; }
        public string OrganizationURLName { set; get; }
        public void SetListAttributes(List<ComboBoxEntityField> lsAttributes)
        {
            ListAttributes = lsAttributes.Select(x => x.Value).ToList();
        }


        public string EntityLogicalName { set; get; }
        public string PrimaryKeyLogicalName { set; get; }
        public bool ShowPersonalViews { set; get; }
        public string FilterDataUsing { set; get; }
        public Guid ViewID { set; get; }

        public string FetchXML { set; get; }




    }
}
