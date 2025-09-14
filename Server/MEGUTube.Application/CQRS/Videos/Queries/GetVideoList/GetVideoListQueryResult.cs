using MEGUTube.Application.Models.Lookups;

namespace MEGUTube.Application.CQRS.Videos.Queries.GetVideoList
{
    public class GetVideoListQueryResult
    {
        public IEnumerable<VideoLookup> Videos { get; set; } = null!;
    }
}
