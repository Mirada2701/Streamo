using MediatR;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.Reactions.VideoReactions.Commands.SetReaction {
    public class SetReactionCommand : IRequest<Unit> {
        public ApplicationUser Requester { get; set; } = null!;
        public int? ReactedVideoId { get; set; } = null!;
        public VideoReactionEntity.VideoReactionType ReactionType { get; set; }
    }
}
