using MediatR;
using Streamo.Application.Models.Lookups;
using Streamo.Domain.Entities;

namespace Streamo.Application.CQRS.Playlists.VideoPlaylists.Commands.CreatePlaylist {
    public class CreatePlaylistCommand : IRequest<VideoPlaylistLookup> {
        public string Title { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
        public Stream? PreviewImageStream { get; set; }
    }
}
