using MediatR;

namespace Streamo.Application.CQRS.Videos.Queries.GetRandomVideo
{
    public class GetRandomVideoQuery : IRequest<GetRandomVideoQueryResult>
    {
    }
}
