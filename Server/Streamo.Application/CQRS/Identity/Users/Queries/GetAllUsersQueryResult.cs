using Streamo.Application.Models.Lookups;
using Streamo.Domain.Entities;

namespace Streamo.Application.CQRS.Identity.Users.Queries
{
    public class GetAllUsersQueryResult
    {
        public IEnumerable<UserLookup> Users { get; set; } = null!;
    }
}
