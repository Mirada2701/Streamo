using MediatR;

namespace MEGUTube.Application.CQRS.Identity.Users.Queries
{
    public class GetAllUsersQuery : IRequest<GetAllUsersQueryResult>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
