using MediatR;
using MEGUTube.Application.CQRS.Videos.Queries.GetVideoListHistory;

namespace MEGUTube.Application.CQRS.UserVideoHistories.Queries.GetUserVideoHistoryList
{
    public class GetVideoListHistoryQuery : IRequest<GetVideoListHistoryQueryResult>
    {
        public int? RequesterId { get; set; } = null!;
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
