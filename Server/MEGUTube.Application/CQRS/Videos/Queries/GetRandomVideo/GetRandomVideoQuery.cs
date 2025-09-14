using MediatR;

namespace MEGUTube.Application.CQRS.Videos.Queries.GetRandomVideo
{
    public class GetRandomVideoQuery : IRequest<GetRandomVideoQueryResult>
    {
    }
}
