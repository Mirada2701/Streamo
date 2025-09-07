using MediatR;
using Streamo.Application.Models.Lookups;
using Streamo.Domain.Entities;

namespace Streamo.Application.CQRS.Videos.Commands.UploadVideo
{
    public class UploadVideoCommand : IRequest<VideoLookup>
    {
        public Stream Source { get; set; } = null!;
        public Stream PreviewPhotoSource { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ApplicationUser? Creator { get; set; }
        public string? AccessModificator { get; set; } = null;
    }
}
