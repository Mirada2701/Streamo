using Streamo.Application.Models.Lookups;

namespace Streamo.Application.CQRS.Videos.Queries.GetVideoListHistory
{
    public class GetVideoListHistoryQueryResult
    {
        public IEnumerable<VideoLookup> Videos { get; set; }
    }
}
