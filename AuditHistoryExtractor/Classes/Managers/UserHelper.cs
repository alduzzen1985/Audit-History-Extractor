using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditHistoryExtractor.Classes.Managers
{
    class UserHelper
    {
        private IOrganizationService _service;

        public UserHelper(IOrganizationService service)
        {
            _service = service;
        }


        public List<User> GetListUsers()
        {
            QueryExpression query = new QueryExpression("systemuser");
            query.ColumnSet.AddColumns("fullname", "domainname");
            query.Orders.Add(new OrderExpression("fullname", OrderType.Ascending));
            List<User> lsUsers = _service.RetrieveMultiple(query).Entities.Select(x => new User(x.Id, x.GetAttributeValue<string>("domainname"), x.GetAttributeValue<string>("fullname"))).ToList();
            return lsUsers;
        }
    }
}
