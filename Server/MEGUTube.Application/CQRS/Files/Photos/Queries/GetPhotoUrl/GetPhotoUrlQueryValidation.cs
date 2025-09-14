using FluentValidation;
using MEGUTube.Application.Common.Interfaces;

namespace MEGUTube.Application.CQRS.Files.Photos.Queries.GetPhotoUrl
{
    public class GetPhotoUrlQueryValidation : AbstractValidator<GetPhotoUrlQuery>
    {
        public GetPhotoUrlQueryValidation(IPhotoService photoService)
        {
            RuleFor(q => q.PhotoId)
                .NotEmpty();
        }
    }
}
