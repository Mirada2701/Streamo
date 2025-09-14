using MediatR;

namespace MEGUTube.Application.CQRS.Identity.Users.Commands.AssignModerator
{
    public class AssignModeratorCommand : IRequest<AssignModeratorCommandResult>
    {
        public int UserId { get; set; } 
    }
}
