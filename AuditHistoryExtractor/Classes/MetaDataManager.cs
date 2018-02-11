using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Metadata.Query;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditHistoryExtractor.AppCode
{
    public static class MetaDataManager
    {
        public static List<EntityMetadata> GetEntitiesWithAuditListEnabledOrDisabled(IOrganizationService service, bool auditEnabled)
        {
            MetadataFilterExpression EntityFilter = new MetadataFilterExpression(LogicalOperator.And);
            EntityFilter.Conditions.Add(new MetadataConditionExpression("IsAuditEnabled", MetadataConditionOperator.Equals, auditEnabled));

            EntityQueryExpression entityQueryExpression = new EntityQueryExpression()
            {
                Criteria = EntityFilter
            };

            RetrieveMetadataChangesResponse initialRequest = GetMetadataChanges(service, entityQueryExpression, null, DeletedMetadataFilters.All);
            return initialRequest.EntityMetadata.ToList();
        }



        public static List<EntityMetadata> GetFieldListForEntity(IOrganizationService service, string entityLogicalName)
        {
            MetadataFilterExpression EntityFilter = new MetadataFilterExpression(LogicalOperator.And);
            //EntityFilter.Conditions.Add(new MetadataConditionExpression("IsAuditEnabled", MetadataConditionOperator.Equals, true));
            EntityFilter.Conditions.Add(new MetadataConditionExpression("LogicalName", MetadataConditionOperator.Equals, entityLogicalName));
            EntityQueryExpression entityQueryExpression = new EntityQueryExpression()
            {
                Criteria = EntityFilter
            };

            RetrieveMetadataChangesResponse initialRequest = GetMetadataChanges(service, entityQueryExpression, null, DeletedMetadataFilters.All);


            return initialRequest.EntityMetadata.ToList();
        }


        private static RetrieveMetadataChangesResponse GetMetadataChanges(IOrganizationService service, EntityQueryExpression entityQueryExpression, String clientVersionStamp, DeletedMetadataFilters deletedMetadataFilter)
        {
            RetrieveMetadataChangesRequest retrieveMetadataChangesRequest = new RetrieveMetadataChangesRequest()
            {
                Query = entityQueryExpression,
                ClientVersionStamp = clientVersionStamp,
                DeletedMetadataFilters = deletedMetadataFilter
            };
            return (RetrieveMetadataChangesResponse)service.Execute(retrieveMetadataChangesRequest);
        }
    }
}
