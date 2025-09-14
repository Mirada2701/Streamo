using MEGUTube.Application.Models.Lookups;

namespace MEGUTube.Application.CQRS.Comments.VideoComments.Queries.GetCommentRepliesList {
    public class GetCommentRepliesListQueryResult {
        public IList<CommentLookup> Comments { get; set; } = new List<CommentLookup>();
    }
}
