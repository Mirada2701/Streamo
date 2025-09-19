using Streamo.Application.Common.Models;
using Streamo.Application.Models.Lookups;

namespace Streamo.Application.CQRS.Identity.Users.Commands.DeleteSubscriptionUserCommand
{
    public class DeleteSubscriptionUserCommandResult
    {
        public int? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ChannelPhotoFileId { get; set; }

    }
}
