using Streamo.Application.Models.Lookups;

namespace Streamo.Application.CQRS.Playlists.VideoPlaylists.Queries.GetUserPlaylists {
    public class GetUserPlaylistsQueryResult {
        public IList<VideoPlaylistLookup> Playlists { get; set; } = null!;
    }
}
