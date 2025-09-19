
using MediatR;
using Streamo.Domain.Entities;

namespace Streamo.Application.CQRS.SubscriptionUser.Queries
{
    public class GetSubscriptionListQuery : IRequest<GetSubscriptionsListQueryResult>
    {

        public int SubscriptionUserTo { get; set; }
    }
}