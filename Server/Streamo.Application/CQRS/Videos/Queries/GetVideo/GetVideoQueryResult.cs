using Streamo.Application.Models.Lookups;

namespace Streamo.Application.CQRS.Videos.Queries.GetVideo
{
    public class GetVideoQueryResult
    {
        public VideoLookup Video { get; set; } = null!;
    }
}
