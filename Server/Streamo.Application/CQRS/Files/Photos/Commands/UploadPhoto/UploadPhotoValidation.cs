using FluentValidation;
using Streamo.Application.Common.Interfaces;

namespace Streamo.Application.CQRS.Files.Photos.Commands.UploadPhoto
{
    public class UploadPhotoValidation : AbstractValidator<UploadPhotoCommand> {
        public UploadPhotoValidation(IPhotoService photoService) {
            RuleFor(c => c.Source)
                .NotNull()
                .MustAsync(async (s, cancellation) =>
                {
                    if (!await photoService.IsFileImageAsync(s))
                        return false;

                    return true;
                })
                .WithMessage((c) => $"File must be image");
        }
    }
}
