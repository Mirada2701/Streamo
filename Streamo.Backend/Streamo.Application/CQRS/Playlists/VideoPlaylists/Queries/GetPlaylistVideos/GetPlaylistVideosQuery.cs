using MediatR;

namespace Streamo.Application.CQRS.Playlists.VideoPlaylists.Queries.GetPlaylistVideos {
    public class GetPlaylistVideosQuery : IRequest<GetPlaylistVideosQueryResult> {
        public int? PlaylistId { get; set; } = null!;
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
