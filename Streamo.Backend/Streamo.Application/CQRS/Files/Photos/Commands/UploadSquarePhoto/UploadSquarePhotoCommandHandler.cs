using MediatR;
using Streamo.Application.Common.Interfaces;

namespace Streamo.Application.CQRS.Files.Photos.Commands.UploadSquarePhoto {
    public class UploadSquarePhotoCommandHandler : IRequestHandler<UploadSquarePhotoCommand, string>
    {
        private readonly IPhotoService _photoService;

        public UploadSquarePhotoCommandHandler(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        public async Task<string> Handle(UploadSquarePhotoCommand request, CancellationToken cancellationToken)
        {
            var result = await _photoService.UploadPhoto(request.Source);
            return result.PhotoId;
        }
    }
}
