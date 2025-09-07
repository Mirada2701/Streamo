using Streamo.Application.Models.Lookups;

namespace Streamo.Application.CQRS.Videos.Queries.GetVideoList
{
    public class GetVideoListQueryResult
    {
        public IEnumerable<VideoLookup> Videos { get; set; } = null!;
    }
}
