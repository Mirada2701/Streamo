using MediatR;

namespace MEGUTube.Application.CQRS.Comments.VideoComments.Queries.GetVideoCommentsCount {
    public class GetVideoCommentsCountQuery : IRequest<int> {
        public int VideoId { get; set; }
    }
}
