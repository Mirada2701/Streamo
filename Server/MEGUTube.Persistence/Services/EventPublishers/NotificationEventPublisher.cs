using MediatR;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using MEGUTube.Application.Common.DbContexts;
using MEGUTube.Application.Common.Interfaces;
using MEGUTube.Application.Models.Lookups;
using MEGUTube.Infrastructure.Hubs;

namespace MEGUTube.Persistence.Services.EventPublishers {
    public class NotificationEventPublisher : IEventPublisher {
        private readonly IHubContext<NotificationsHub> _hub;
        private readonly IApplicationDbContext _db;

        public NotificationEventPublisher(IHubContext<NotificationsHub> hubContext, IApplicationDbContext db) {
            _hub = hubContext;
            _db = db;
        }

        public async Task SendEvent(object data) {
            var videoCreatedNotification = data as NotificationLookup;

            // take a subscribers list of user that created current video
            var result = await _db.Subscriptions
                .Where(s => s.SubscriberId == videoCreatedNotification.NotificationIssuer.UserId) // get list of user subscribers
                .Select(s => s.CreatorId!.ToString() ?? "")
                .ToListAsync();

            // and notify them about the event
            await _hub.Clients
                .Users(result)
                .SendAsync("OnNotificationReceived", videoCreatedNotification);
        }
    }
}
