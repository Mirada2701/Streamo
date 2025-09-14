using MediatR;

namespace MEGUTube.Application.CQRS.Reactions.VideoReactions.Queries.GetVideoCountReactions {
    public class GetVideoCountReactionsQuery : IRequest<VideoReactionsCount> {
        public int VideoId { get; set; }
    }
}
