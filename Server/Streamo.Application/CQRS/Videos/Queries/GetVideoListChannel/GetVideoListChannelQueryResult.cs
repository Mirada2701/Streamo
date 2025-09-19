using Streamo.Application.Models.Lookups;

namespace Streamo.Application.CQRS.Videos.Queries.GetVideoListChannel
{
    public class GetVideoListChannelQueryResult
    {
        public IEnumerable<VideoLookup> Videos { get; set; } = null;
    }
}
