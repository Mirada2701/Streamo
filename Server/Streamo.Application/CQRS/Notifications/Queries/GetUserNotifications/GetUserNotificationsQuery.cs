using MediatR;
using Streamo.Application.Models.Lookups;

namespace Streamo.Application.CQRS.Notifications.Queries.GetUserNotifications {
    public class GetUserNotificationsQuery : IRequest<IList<NotificationLookup>> {
        public int UserId { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
