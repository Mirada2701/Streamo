using MediatR;
using Streamo.Application.Common.DbContexts;
using Streamo.Application.Common.Interfaces;
using Streamo.Application.Models.Lookups;
using Streamo.Domain.Entities;

namespace Streamo.Application.CQRS.Videos.Notifications.VideoCreated {
    public class VideoCreatedDatabaseNotificationHandler : INotificationHandler<VideoCreatedNotification> {
        private readonly IApplicationDbContext _context;
        private readonly IDateTimeService _dateTimeService;

        public VideoCreatedDatabaseNotificationHandler(IApplicationDbContext context, IDateTimeService dateTimeService) {
            _context = context;
            _dateTimeService = dateTimeService;
        }

        public async Task Handle(VideoCreatedNotification notification, CancellationToken cancellationToken) {
            var videoLookup = new VideoLookup() {
                Id = notification.Video.Id,
                Name = notification.Video.Name,
                PreviewPhotoFile = notification.Video.PreviewPhotoFileId,
                Creator = new UserLookup() {
                    FirstName = notification.Video.Creator!.FirstName,
                    LastName = notification.Video.Creator!.LastName,
                    ChannelPhoto = notification.Video.Creator!.ChannelPhotoFileId!.ToString(),
                }
            };

            var notificationEntity = new NotificationEntity() {
                DateCreated = _dateTimeService.Now,
                NotificationIssuer = notification.Video.Creator,
                NotificationIssuerId = notification.Video.CreatorId,
                Type = NotificationEntity.NotificationType.NewVideo,
                NotificationData = notification.Video
            };

            _context.Notifications.Add(notificationEntity);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
