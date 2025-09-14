
using MediatR;
using MEGUTube.Application.CQRS.Identity.Users.Commands.AddSubscriptionUser;
using MEGUTube.Application.CQRS.Identity.Users.Commands.DeleteSubscriptionUserCommand;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.SubscriptionUser.DeleteSubscriptionUserCommand
{
    public class DeleteSubscriptionUserCommand : IRequest<DeleteSubscriptionUserCommandResult>
    {
        public int User { get; set; }
        public int Subscriber { get; set; }
    }
}