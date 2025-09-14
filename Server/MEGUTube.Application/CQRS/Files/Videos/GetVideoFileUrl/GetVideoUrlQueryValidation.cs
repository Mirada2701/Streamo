using FluentValidation;
using MEGUTube.Application.Common.Interfaces;

namespace MEGUTube.Application.CQRS.Files.Videos.GetVideoFileUrl
{
    public class GetVideoUrlQueryValidation : AbstractValidator<GetVideoUrlQuery>
    {
        public GetVideoUrlQueryValidation(IVideoService videoService)
        {
            RuleFor(q => q.VideoFileId)
                .NotEmpty()
                .MustAsync(async (s, cancellation) =>
                {
                    if (!await videoService.IsVideoExists(s))
                        return false;

                    return true;
                })
                .WithMessage("Video doesn't exists");
        }
    }
}
