using MEGUTube.Domain.Entities;
using static MEGUTube.Domain.Entities.NotificationEntity;

namespace MEGUTube.Application.Models.Lookups {
    public class NotificationLookup {
        public NotificationType? Type { get; set; } = null;
        public UserLookup? NotificationIssuer { get; set; } = null;
        public VideoLookup? NotificationData { get; set; } = null;
        public DateTime DateCreated { get; set; }
    }
}
