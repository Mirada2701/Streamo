using FluentValidation;
using Streamo.Application.Common.Interfaces;

namespace Streamo.Application.CQRS.Files.Photos.Queries.GetPhotoUrl
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
