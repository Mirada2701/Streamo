using MediatR;
using MEGUTube.Application.Models.Lookups;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.Playlists.VideoPlaylists.Commands.CreatePlaylist {
    public class CreatePlaylistCommand : IRequest<VideoPlaylistLookup> {
        public string Title { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
        public Stream? PreviewImageStream { get; set; }
    }
}
