using MEGUTube.Application.Models.Lookups;

namespace MEGUTube.Application.CQRS.Videos.Queries.GetVideoListHistory
{
    public class GetVideoListHistoryQueryResult
    {
        public IEnumerable<VideoLookup> Videos { get; set; }
    }
}
