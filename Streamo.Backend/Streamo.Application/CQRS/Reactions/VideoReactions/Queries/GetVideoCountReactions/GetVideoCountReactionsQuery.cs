using MediatR;

namespace Streamo.Application.CQRS.Reactions.VideoReactions.Queries.GetVideoCountReactions {
    public class GetVideoCountReactionsQuery : IRequest<VideoReactionsCount> {
        public int VideoId { get; set; }
    }
}
