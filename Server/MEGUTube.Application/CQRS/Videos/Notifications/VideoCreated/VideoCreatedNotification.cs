using MediatR;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.Videos.Notifications.VideoCreated {
    public class VideoCreatedNotification : INotification {
        public VideoEntity Video { get; set; } = null!;
    }
}
