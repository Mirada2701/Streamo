using MediatR;
using Streamo.Application.Models.Lookups;
using Streamo.Domain.Entities;

namespace Streamo.Application.CQRS.Comments.VideoComments.Commands.AddComment {
    public class AddCommentCommand : IRequest<CommentLookup> {
        public string Content { get; set; } = string.Empty;
        public int? VideoId { get; set; } = null;
        public ApplicationUser? Creator { get; set; } = null;
    }
}
