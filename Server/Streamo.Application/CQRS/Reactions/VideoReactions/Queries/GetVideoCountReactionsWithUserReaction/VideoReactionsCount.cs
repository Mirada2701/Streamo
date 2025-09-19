using Streamo.Application.CQRS.Reactions.VideoReactions.Queries.GetVideoCountReactions;

namespace Streamo.Application.CQRS.Reactions.VideoReactions.Queries.GetVideoCountReactionsWithUserReaction {
    public class VideoReactionsCountWithStatus : VideoReactionsCount {
        public bool WasLikedByRequester { get; set; }
        public bool WasDislikedByRequester { get; set; }
    }
}
