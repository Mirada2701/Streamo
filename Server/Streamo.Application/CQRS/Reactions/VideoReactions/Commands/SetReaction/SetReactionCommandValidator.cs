using FluentValidation;
using Streamo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streamo.Application.CQRS.Reactions.VideoReactions.Commands.SetReaction {
    public class SetReactionCommandValidator : AbstractValidator<SetReactionCommand> {
        public SetReactionCommandValidator() {
            RuleFor(c => c.ReactionType)
                .IsInEnum();
        }
    }
}
