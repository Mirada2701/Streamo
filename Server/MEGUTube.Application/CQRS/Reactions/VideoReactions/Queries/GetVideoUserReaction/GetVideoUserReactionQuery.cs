using MediatR;
using MEGUTube.Application.Models.Lookups;

namespace MEGUTube.Application.CQRS.Reactions.VideoReactions.Queries.GetVideoUserReaction {
    public class GetVideoUserReactionQuery : IRequest<ReactionLookup?> {
        public int UserId { get; set; }
        public int VideoId { get; set; }
    }
}
