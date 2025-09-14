
using MediatR;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.SubscriptionUser.CheckSubscriptionUser
{
    public class CheckSubscriptionUserCommand : IRequest<bool>
    {
        public int UserID { get; set; }
        public int SubscriptionUserTo { get; set; }
    }
}