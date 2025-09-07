using MediatR;

namespace Streamo.Application.CQRS.Identity.Users.Commands.BanUser
{
    public class BanUserCommand : IRequest<BanUserCommandResult>
    {
        public int UserId { get; set; } 
    }
}
