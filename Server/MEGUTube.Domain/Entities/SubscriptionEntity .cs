using MEGUTube.Domain.Entities.Abstract;

namespace MEGUTube.Domain.Entities {
    public class SubscriptionEntity : OwnedEntity {
        public ApplicationUser Subscriber { get; set; }
        public int SubscriberId { get; set; }
    }
}