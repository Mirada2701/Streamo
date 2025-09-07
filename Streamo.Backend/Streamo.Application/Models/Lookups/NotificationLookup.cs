using Streamo.Domain.Entities;
using static Streamo.Domain.Entities.NotificationEntity;

namespace Streamo.Application.Models.Lookups {
    public class NotificationLookup {
        public NotificationType? Type { get; set; } = null;
        public UserLookup? NotificationIssuer { get; set; } = null;
        public VideoLookup? NotificationData { get; set; } = null;
        public DateTime DateCreated { get; set; }
    }
}
