using FluentValidation;
using MEGUTube.Application.CQRS.Videos.Queries.GetVideoListChannel;

namespace MEGUTube.Application.CQRS.UserVideoHistories.Queries.GetUserVideoHistoryList
{
    public class GetVideoListHistoryQueryValidation : AbstractValidator<GetVideoListChannelQuery>
    {
        public GetVideoListHistoryQueryValidation()
        {
            RuleFor(q => q.Page)
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(q => q.PageSize)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
