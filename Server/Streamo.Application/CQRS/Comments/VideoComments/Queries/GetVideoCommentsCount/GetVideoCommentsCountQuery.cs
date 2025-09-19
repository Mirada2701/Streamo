using MediatR;

namespace Streamo.Application.CQRS.Comments.VideoComments.Queries.GetVideoCommentsCount {
    public class GetVideoCommentsCountQuery : IRequest<int> {
        public int VideoId { get; set; }
    }
}
