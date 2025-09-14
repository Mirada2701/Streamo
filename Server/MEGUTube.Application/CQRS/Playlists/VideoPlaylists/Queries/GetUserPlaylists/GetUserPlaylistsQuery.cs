using MediatR;

namespace MEGUTube.Application.CQRS.Playlists.VideoPlaylists.Queries.GetUserPlaylists {
    public class GetUserPlaylistsQuery : IRequest<GetUserPlaylistsQueryResult> {
        public int UserId { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
