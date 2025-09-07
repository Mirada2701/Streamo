using Streamo.Domain.Entities.Abstract;

namespace Streamo.Domain.Entities {
    public class SubscriptionEntity : OwnedEntity {
        public ApplicationUser Subscriber { get; set; }
        public int SubscriberId { get; set; }
    }
}