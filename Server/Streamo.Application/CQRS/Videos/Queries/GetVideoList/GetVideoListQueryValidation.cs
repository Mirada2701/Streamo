using FluentValidation;

namespace Streamo.Application.CQRS.Videos.Queries.GetVideoList
{
    public class GetVideoListQueryValidation : AbstractValidator<GetVideoListQuery>
    {
        public GetVideoListQueryValidation()
        {
            RuleFor(c => c.Page)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(c => c.PageSize)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
