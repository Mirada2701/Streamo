using MEGUTube.Application.Models.Lookups;

namespace MEGUTube.Application.CQRS.Videos.Queries.GetRandomVideo
{
    public class GetRandomVideoQueryResult
    {
        public VideoLookup Video { get; set; } = null!;
    }
}
