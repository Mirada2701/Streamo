using MEGUTube.Application.CQRS.Comments.VideoComments.Commands.AddComment;

namespace MEGUTube.Application.CQRS.Comments.VideoComments.Commands.AddCommentReply {
    public class AddCommentReplyCommand : AddCommentCommand {
        public int? ReplyToCommentId { get; set; } = null;
    }
}