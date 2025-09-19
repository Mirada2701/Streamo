using Streamo.Application.Common.Models;
using Streamo.Application.Models.Lookups;

namespace Streamo.Application.CQRS.Identity.Users.Commands.AddSubscriptionUser{
    public class AddSubscriptionUserCommandResult
    {
        public int? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ChannelPhotoFileId { get; set; }

    }
}
