
using MediatR;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.SubscriptionUser.Queries
{
    public class GetSubscriptionListQuery : IRequest<GetSubscriptionsListQueryResult>
    {

        public int SubscriptionUserTo { get; set; }
    }
}