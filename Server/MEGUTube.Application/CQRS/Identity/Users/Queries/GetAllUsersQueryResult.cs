using MEGUTube.Application.Models.Lookups;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.Identity.Users.Queries
{
    public class GetAllUsersQueryResult
    {
        public IEnumerable<UserLookup> Users { get; set; } = null!;
    }
}
