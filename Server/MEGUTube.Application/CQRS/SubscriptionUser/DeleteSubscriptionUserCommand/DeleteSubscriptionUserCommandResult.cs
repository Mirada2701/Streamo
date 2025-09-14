using MEGUTube.Application.Common.Models;
using MEGUTube.Application.Models.Lookups;

namespace MEGUTube.Application.CQRS.Identity.Users.Commands.DeleteSubscriptionUserCommand
{
    public class DeleteSubscriptionUserCommandResult
    {
        public int? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ChannelPhotoFileId { get; set; }

    }
}
