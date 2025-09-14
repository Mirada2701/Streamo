using MediatR;

namespace MEGUTube.Application.CQRS.Identity.Users.Commands.BanUser
{
    public class BanUserCommand : IRequest<BanUserCommandResult>
    {
        public int UserId { get; set; } 
    }
}
