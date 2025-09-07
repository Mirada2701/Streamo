using MediatR;
using Streamo.Domain.Entities;

namespace Streamo.Application.CQRS.Videos.Notifications.VideoCreated {
    public class VideoCreatedNotification : INotification {
        public VideoEntity Video { get; set; } = null!;
    }
}
