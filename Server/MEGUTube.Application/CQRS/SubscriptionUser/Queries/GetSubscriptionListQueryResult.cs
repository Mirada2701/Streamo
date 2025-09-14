using MEGUTube.Application.Models.Lookups;

namespace MEGUTube.Application.CQRS.SubscriptionUser.Queries
{
    public class GetSubscriptionsListQueryResult
    {
        public IList<SubscriptionLookup> Subscriptions { get; set; } = new List<SubscriptionLookup>();
    }
}