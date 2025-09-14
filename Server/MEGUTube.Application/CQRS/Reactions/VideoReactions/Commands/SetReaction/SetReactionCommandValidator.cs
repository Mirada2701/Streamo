using FluentValidation;
using MEGUTube.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGUTube.Application.CQRS.Reactions.VideoReactions.Commands.SetReaction {
    public class SetReactionCommandValidator : AbstractValidator<SetReactionCommand> {
        public SetReactionCommandValidator() {
            RuleFor(c => c.ReactionType)
                .IsInEnum();
        }
    }
}
