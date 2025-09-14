using FluentValidation;

namespace MEGUTube.Application.CQRS.Videos.Commands.DeleteVideo
{
    public class DeleteVideoCommandValidation : AbstractValidator<DeleteVideoCommand>
    {
        public DeleteVideoCommandValidation()
        {
            RuleFor(c => c.VideoId)
                .NotNull()
                .GreaterThan(0);
        }
    }
}
