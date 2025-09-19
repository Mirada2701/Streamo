using MediatR;
using Streamo.Application.Models.Lookups;

namespace Streamo.Application.CQRS.Reactions.VideoReactions.Queries.GetVideoUserReaction {
    public class GetVideoUserReactionQuery : IRequest<ReactionLookup?> {
        public int UserId { get; set; }
        public int VideoId { get; set; }
    }
}
