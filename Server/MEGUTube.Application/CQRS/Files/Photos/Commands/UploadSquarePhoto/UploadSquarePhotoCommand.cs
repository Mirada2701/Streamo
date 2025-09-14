using MediatR;

namespace MEGUTube.Application.CQRS.Files.Photos.Commands.UploadSquarePhoto {
    public class UploadSquarePhotoCommand : IRequest<string>
    {
        public Stream Source { get; set; } = null!;
    }
}
