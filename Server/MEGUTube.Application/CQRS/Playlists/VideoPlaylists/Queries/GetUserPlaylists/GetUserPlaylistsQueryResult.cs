using MEGUTube.Application.Models.Lookups;

namespace MEGUTube.Application.CQRS.Playlists.VideoPlaylists.Queries.GetUserPlaylists {
    public class GetUserPlaylistsQueryResult {
        public IList<VideoPlaylistLookup> Playlists { get; set; } = null!;
    }
}
