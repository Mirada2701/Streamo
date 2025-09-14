using MediatR;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.Comments.VideoComments.Commands.DeleteComment {
    public class DeleteCommentCommand : IRequest<Unit> {
        public int CommentId { get; set; }
        public ApplicationUser? Requester { get; set; } = null;
    }
}
