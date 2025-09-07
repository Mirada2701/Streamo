using Streamo.Application.Models.Lookups;

namespace Streamo.Application.CQRS.Comments.VideoComments.Queries.GetCommentRepliesList {
    public class GetCommentRepliesListQueryResult {
        public IList<CommentLookup> Comments { get; set; } = new List<CommentLookup>();
    }
}
