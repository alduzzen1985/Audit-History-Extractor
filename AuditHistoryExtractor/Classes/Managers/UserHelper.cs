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

            query.PageInfo = new PagingInfo();
            query.PageInfo.Count = 5000;
            query.PageInfo.PageNumber = 1;

            List<User> lsUsers = new List<User>();

            while (true)
            {
                // Retrieve the page.
                EntityCollection results = _service.RetrieveMultiple(query);
                if (results.Entities != null)
                {

                    lsUsers.AddRange(results.Entities.Select(x => new User(x.Id, x.GetAttributeValue<string>("domainname"), x.GetAttributeValue<string>("fullname"))).ToList());
                }

                // Check for more records, if it returns true.
                if (results.MoreRecords)
                {
                    // Increment the page number to retrieve the next page.
                    query.PageInfo.PageNumber++;

                    // Set the paging cookie to the paging cookie returned from current results.
                    query.PageInfo.PagingCookie = results.PagingCookie;
                }
                else
                {
                    // If no more records are in the result nodes, exit the loop.
                    break;
                }
            }


            //List<User> lsUsers = _service.RetrieveMultiple(query).Entities.Select(x => new User(x.Id, x.GetAttributeValue<string>("domainname"), x.GetAttributeValue<string>("fullname"))).ToList();
            return lsUsers;
        }
    }
}
