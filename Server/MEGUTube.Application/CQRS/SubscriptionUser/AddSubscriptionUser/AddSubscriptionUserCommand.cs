
using MediatR;
using MEGUTube.Application.CQRS.Identity.Users.Commands.AddSubscriptionUser;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.SubscriptionUser.AddSubscriptionUser
{
    public class AddSubscriptionUserCommand : IRequest<AddSubscriptionUserCommandResult>
    {
        public int User { get; set; }
        public int Subscriber { get; set; }
    }
}