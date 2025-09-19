using Streamo.Application.Models.Lookups;

namespace Streamo.Application.CQRS.Videos.Queries.GetRandomVideo
{
    public class GetRandomVideoQueryResult
    {
        public VideoLookup Video { get; set; } = null!;
    }
}
