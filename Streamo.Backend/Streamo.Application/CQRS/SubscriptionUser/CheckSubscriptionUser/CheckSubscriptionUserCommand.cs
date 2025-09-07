
using MediatR;
using Streamo.Domain.Entities;

namespace Streamo.Application.CQRS.SubscriptionUser.CheckSubscriptionUser
{
    public class CheckSubscriptionUserCommand : IRequest<bool>
    {
        public int UserID { get; set; }
        public int SubscriptionUserTo { get; set; }
    }
}