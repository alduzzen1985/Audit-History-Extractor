using AuditHistoryExtractor.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditHistoryExtractor.Classes.Managers
{
    public static class FilterDataManager
    {



        public static List<AuditHistory> ApplyFilterData(List<AuditHistory> lsAuditHistory, Configuration filterData)
        {
            List<AuditHistory> lsAuditHistoryFiltered = lsAuditHistory;

            if (lsAuditHistoryFiltered == null) { return null; }

            if (filterData.SelectedOperations != null && filterData.SelectedOperations.Count > 0)
            {
                lsAuditHistoryFiltered = lsAuditHistoryFiltered.Where(x => filterData.SelectedOperations.Contains(x.OperationId)).ToList();
            }

            if (filterData.SelectedActions != null && filterData.SelectedActions.Count > 0)
            {
                lsAuditHistoryFiltered = lsAuditHistoryFiltered.Where(x => filterData.SelectedActions.Contains(x.ActionId)).ToList();
            }


            if (filterData.SelectedUsers != null && filterData.SelectedUsers.Count > 0)
            {
                lsAuditHistoryFiltered = lsAuditHistoryFiltered.Where(x => (filterData.SelectedUsers).Contains(x.UserId)).ToList();
            }

            if (filterData.DateFrom != null)
            {
                lsAuditHistoryFiltered = lsAuditHistoryFiltered.Where(x => x.CreatedOn >= filterData.DateFrom).ToList();
            }


            if (filterData.DateTo != null)
            {
                lsAuditHistoryFiltered = lsAuditHistoryFiltered.Where(x => x.CreatedOn <= filterData.DateTo).ToList();
            }


            if (filterData.ListAttributes != null && filterData.ListAttributes.Count > 0)
            {
                lsAuditHistoryFiltered = lsAuditHistoryFiltered.Where(x => filterData.ListAttributes.Where(a => x.AttributeName == a).Any()).ToList();
            }



            return lsAuditHistoryFiltered;
        }
    }
}
