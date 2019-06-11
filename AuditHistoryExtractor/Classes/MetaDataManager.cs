using AuditHistoryExtractor.Classes;
using Microsoft.Crm.Sdk.Messages;
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



        public static List<EntityMetadata> GetStringFieldsFieldListForEntity(IOrganizationService service, string entityLogicalName)
        {
            MetadataFilterExpression EntityFilter = new MetadataFilterExpression(LogicalOperator.And);
            EntityFilter.Conditions.Add(new MetadataConditionExpression("LogicalName", MetadataConditionOperator.Equals, entityLogicalName));

            MetadataConditionExpression metadataExpression = new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.String);
            MetadataFilterExpression AttributeFilter = new
            MetadataFilterExpression(LogicalOperator.And);
            AttributeFilter.Conditions.Add(metadataExpression);

            AttributeQueryExpression Attributefilters = new AttributeQueryExpression()
            {
                Criteria = AttributeFilter
            };

            EntityQueryExpression entityQueryExpression = new EntityQueryExpression()
            {
                Criteria = EntityFilter,
                AttributeQuery = Attributefilters

            };

            RetrieveMetadataChangesResponse initialRequest = GetMetadataChanges(service, entityQueryExpression, null, DeletedMetadataFilters.All);
            return initialRequest.EntityMetadata.ToList();
        }

        public static List<EntityMetadata> GetListFieldsForEntity(IOrganizationService service, string entityLogicalName)
        {
            MetadataFilterExpression EntityFilter = new MetadataFilterExpression(LogicalOperator.And);
            EntityFilter.Conditions.Add(new MetadataConditionExpression("LogicalName", MetadataConditionOperator.Equals, entityLogicalName));
            EntityQueryExpression entityQueryExpression = new EntityQueryExpression()
            {
                Criteria = EntityFilter,
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


        public static List<ComboBoxEntities> GetListEntities(IOrganizationService service)
        {
            MetadataPropertiesExpression EntityProperties = new MetadataPropertiesExpression()
            {
                AllProperties = false
            };
            EntityProperties.PropertyNames.AddRange(new string[] { "IsAuditEnabled", "DisplayName", "LogicalName", "ObjectTypeCode" });


            MetadataFilterExpression EntityFilter = new MetadataFilterExpression(LogicalOperator.And);
            EntityFilter.Conditions.Add(new MetadataConditionExpression("IsIntersect", MetadataConditionOperator.Equals, false));

            EntityQueryExpression entityQueryExpression = new EntityQueryExpression()
            {
                Properties = EntityProperties,
            };


            RetrieveMetadataChangesResponse initialRequest = GetMetadataChanges(service, entityQueryExpression, null, DeletedMetadataFilters.OptionSet);

            List<ComboBoxEntities> lsEntities = initialRequest.EntityMetadata.Where(f => f.DisplayName.UserLocalizedLabel != null).Select(x => new ComboBoxEntities()
            {
                DisplayName = x.DisplayName.UserLocalizedLabel.Label,
                IsAuditEnabled = x.IsAuditEnabled.Value,
                ObjectTypeCode = x.ObjectTypeCode.Value,
                LogicalName = x.LogicalName
            }).OrderBy(o => o.DisplayName).ToList();

            return lsEntities;

        }


        public static List<ViewDetail> GetListViews(IOrganizationService service, string entityLogicalName, int entityTypeCode, bool systemView)
        {
            // Retrieve Views
            QueryExpression mySavedQuery = new QueryExpression
            {
                ColumnSet = new ColumnSet("savedqueryid", "name", "querytype", "isdefault", "returnedtypecode", "fetchxml"),
                EntityName = "savedquery",
                Criteria = new FilterExpression
                {
                    Conditions =
            {
                new ConditionExpression
                {
                    AttributeName = "querytype",
                    Operator = ConditionOperator.Equal,
                    Values = { 0 }
                },
                new ConditionExpression
                {
                    AttributeName = "returnedtypecode",
                    Operator = ConditionOperator.Equal,
                    Values = { entityTypeCode }
                },
                new ConditionExpression
                {
                    AttributeName = "isquickfindquery",
                    Operator= ConditionOperator.Equal,
                    Values = {false}
                }

            }
                }
            };


            RetrieveMultipleRequest retrieveSavedQueriesRequest = new RetrieveMultipleRequest { Query = mySavedQuery };

            RetrieveMultipleResponse retrieveSavedQueriesResponse = (RetrieveMultipleResponse)service.Execute(retrieveSavedQueriesRequest);

            DataCollection<Entity> savedQueries = retrieveSavedQueriesResponse.EntityCollection.Entities;

            return savedQueries.Select(x => new ViewDetail
            {
                Name = x.GetAttributeValue<string>("name"),
                FetchXML = x.GetAttributeValue<string>("fetchxml"),
                Savedqueryid = x.Id
            }).ToList();

        }

        public static List<ViewDetail> GetListUserViews(IOrganizationService service, string entityLogicalName, int entityTypeCode)
        {

            WhoAmIRequest systemUserRequest = new WhoAmIRequest();
            WhoAmIResponse systemUserResponse = (WhoAmIResponse)service.Execute(systemUserRequest);
            Guid userId = systemUserResponse.UserId;

            var query = new QueryExpression
            {
                EntityName = "userquery",
                ColumnSet = new ColumnSet("userqueryid", "name", "fetchxml"),
                Criteria = new FilterExpression
                {
                    FilterOperator = LogicalOperator.And,
                    Conditions = {
                        new ConditionExpression
                        {
                            AttributeName = "returnedtypecode",
                            Operator = ConditionOperator.Equal,
                            Values = { entityTypeCode }
                        },
                        new ConditionExpression
                        {
                            AttributeName = "owninguser",
                            Operator = ConditionOperator.Equal,
                            Values = { userId }
                        }
                    }
                }
            };

            RetrieveMultipleRequest retrieveSavedQueriesRequest = new RetrieveMultipleRequest { Query = query };

            RetrieveMultipleResponse retrieveSavedQueriesResponse = (RetrieveMultipleResponse)service.Execute(retrieveSavedQueriesRequest);

            DataCollection<Entity> savedQueries = retrieveSavedQueriesResponse.EntityCollection.Entities;

            return savedQueries.Select(x => new ViewDetail
            {
                Name = x.GetAttributeValue<string>("name"),
                FetchXML = x.GetAttributeValue<string>("fetchxml"),
                Savedqueryid = x.Id
            }).ToList();


        }



    }
}
