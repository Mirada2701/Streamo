using Streamo.Application.Models.Lookups;

namespace Streamo.Application.CQRS.SubscriptionUser.Queries
{
    public class GetSubscriptionsListQueryResult
    {
        public IList<SubscriptionLookup> Subscriptions { get; set; } = new List<SubscriptionLookup>();
    }
}