using MEGUTube.Application.Models.Lookups;

namespace MEGUTube.Application.CQRS.Playlists.VideoPlaylists.Queries.GetPlaylistVideos {
    public class GetPlaylistVideosQueryResult {
        public string? Title { get; set; }
        public int? TotalCount { get; set; }
        public IList<VideoLookup> Videos { get; set; } = null!;
    }
}
