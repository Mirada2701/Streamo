using MEGUTube.Application.Models.Lookups;

namespace MEGUTube.Application.CQRS.Videos.Queries.GetVideoListChannel
{
    public class GetVideoListChannelQueryResult
    {
        public IEnumerable<VideoLookup> Videos { get; set; } = null;
    }
}
