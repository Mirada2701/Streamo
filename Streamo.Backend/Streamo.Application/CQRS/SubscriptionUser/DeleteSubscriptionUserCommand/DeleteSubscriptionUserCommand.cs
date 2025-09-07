
using MediatR;
using Streamo.Application.CQRS.Identity.Users.Commands.AddSubscriptionUser;
using Streamo.Application.CQRS.Identity.Users.Commands.DeleteSubscriptionUserCommand;
using Streamo.Domain.Entities;

namespace Streamo.Application.CQRS.SubscriptionUser.DeleteSubscriptionUserCommand
{
    public class DeleteSubscriptionUserCommand : IRequest<DeleteSubscriptionUserCommandResult>
    {
        public int User { get; set; }
        public int Subscriber { get; set; }
    }
}