using MEGUTube.Application.Models.Lookups;

namespace MEGUTube.Application.CQRS.Videos.Queries.GetVideo
{
    public class GetVideoQueryResult
    {
        public VideoLookup Video { get; set; } = null!;
    }
}
