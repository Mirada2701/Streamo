using MEGUTube.Application.CQRS.Reactions.VideoReactions.Queries.GetVideoCountReactions;

namespace MEGUTube.Application.CQRS.Reactions.VideoReactions.Queries.GetVideoCountReactionsWithUserReaction {
    public class VideoReactionsCountWithStatus : VideoReactionsCount {
        public bool WasLikedByRequester { get; set; }
        public bool WasDislikedByRequester { get; set; }
    }
}
