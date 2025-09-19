using MediatR;
using Streamo.Domain.Entities;

namespace Streamo.Application.CQRS.Comments.VideoComments.Commands.DeleteComment {
    public class DeleteCommentCommand : IRequest<Unit> {
        public int CommentId { get; set; }
        public ApplicationUser? Requester { get; set; } = null;
    }
}
