using MediatR;
using Streamo.Domain.Entities;

namespace Streamo.Application.CQRS.Identity.Users.Queries {
    public class GetUserByIdQuery : IRequest<ApplicationUser> {
        public int UserId { get; set; }
    }
}
