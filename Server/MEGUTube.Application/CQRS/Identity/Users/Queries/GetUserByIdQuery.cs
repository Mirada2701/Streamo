using MediatR;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.Identity.Users.Queries {
    public class GetUserByIdQuery : IRequest<ApplicationUser> {
        public int UserId { get; set; }
    }
}
