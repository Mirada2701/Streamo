
using MediatR;
using Streamo.Application.CQRS.Identity.Users.Commands.AddSubscriptionUser;
using Streamo.Domain.Entities;

namespace Streamo.Application.CQRS.SubscriptionUser.AddSubscriptionUser
{
    public class AddSubscriptionUserCommand : IRequest<AddSubscriptionUserCommandResult>
    {
        public int User { get; set; }
        public int Subscriber { get; set; }
    }
}