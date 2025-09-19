using MediatR;
using Streamo.Application.CQRS.Reactions.VideoReactions.Queries.GetVideoCountReactions;

namespace Streamo.Application.CQRS.Reactions.VideoReactions.Queries.GetVideoCountReactionsWithUserReaction {
    public class GetVideoCountReactionsWithUserReactionQuery : IRequest<VideoReactionsCountWithStatus> {
        public int VideoId { get; set; }
        public int? RequesterId { get; set; } = null;
    }
}
