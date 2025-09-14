using MediatR;
using MEGUTube.Application.CQRS.Reactions.VideoReactions.Queries.GetVideoCountReactions;

namespace MEGUTube.Application.CQRS.Reactions.VideoReactions.Queries.GetVideoCountReactionsWithUserReaction {
    public class GetVideoCountReactionsWithUserReactionQuery : IRequest<VideoReactionsCountWithStatus> {
        public int VideoId { get; set; }
        public int? RequesterId { get; set; } = null;
    }
}
