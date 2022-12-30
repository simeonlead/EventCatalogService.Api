using Microservice.Framework.Domain.Queries;
using Microservice.Framework.Persistence.EFCore.Queries.CriteriaQueries;
using Microservice.Framework.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventCatalogService.Domain.DomainModel.EventCatalogDomainModel.Entities;

namespace EventCatalogService.Domain.DomainModel.EventCatalogDomainModel.Queries
{
    public class GetEventQuery : EFCoreCriteriaDomainQuery<Event>, IQuery<IEnumerable<Event>>
    {
        #region Contructor

        public GetEventQuery(CategoryId categoryId)
        {

            categoryId = categoryId;

        }

        #endregion

        #region Properties

        public CategoryId CategoryId { get; }

        #endregion
        
    }

    public class GetEventsQueryHandler : EFCoreCriteriaDomainQueryHandler<Event>, IQueryHandler<GetEventQuery, IEnumerable<Event>>
    {
        public GetEventsQueryHandler(IPersistenceFactory persistenceFactory)
            : base(persistenceFactory)
        {

        }

        public Task<Event> ExecuteQueryAsync(GetEventQuery query, CancellationToken cancellationToken)
        {
           // return FindAll(query);
        }

        Task<IEnumerable<Event>> IQueryHandler<GetEventQuery, IEnumerable<Event>>.ExecuteQueryAsync(GetEventQuery query, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
