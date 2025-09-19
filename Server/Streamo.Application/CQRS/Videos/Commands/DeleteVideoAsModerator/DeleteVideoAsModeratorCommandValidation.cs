using FluentValidation;

namespace Streamo.Application.CQRS.Videos.Commands.DeleteVideoAsModerator
{
    public class DeleteVideoAsModeratorCommandValidation : AbstractValidator<DeleteVideoAsModeratorCommand>
    {
        public DeleteVideoAsModeratorCommandValidation()
        {
            RuleFor(c => c.VideoId)
                .NotNull()
                .GreaterThan(0);
        }
    }
}
