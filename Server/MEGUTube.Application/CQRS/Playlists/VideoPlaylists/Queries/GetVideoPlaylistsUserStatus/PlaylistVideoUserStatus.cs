using MEGUTube.Application.Models.Lookups;

namespace MEGUTube.Application.CQRS.Playlists.VideoPlaylists.Queries.GetVideoPlaylistsUserStatus {
    public class PlaylistVideoUserStatus {
        public VideoPlaylistLookup Playlist { get; set; } = null!;
        public bool IsVideoInPlaylist { get; set; }
    }
}
