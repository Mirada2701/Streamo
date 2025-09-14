using MediatR;
using MEGUTube.Application.Models.Lookups;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.Comments.VideoComments.Commands.AddComment {
    public class AddCommentCommand : IRequest<CommentLookup> {
        public string Content { get; set; } = string.Empty;
        public int? VideoId { get; set; } = null;
        public ApplicationUser? Creator { get; set; } = null;
    }
}
