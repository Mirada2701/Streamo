using FluentValidation;

namespace Streamo.Application.CQRS.Videos.Queries.GetVideo
{
    public class GetVideoQueryValidation : AbstractValidator<GetVideoQuery>
    {
        public GetVideoQueryValidation()
        {
            RuleFor(c => c.VideoId)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
