// SubscriptionUserCommandHandler.cs
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Streamo.Application.Common.DbContexts;
using Streamo.Application.CQRS.Identity.Users.Commands.CreateUser;
using Streamo.Domain.Entities;

namespace Streamo.Application.CQRS.SubscriptionUser.AddSubscriptionUser
{
    public class AddSubscriptionUserValidator : AbstractValidator<AddSubscriptionUserCommand>
    {
        public AddSubscriptionUserValidator()
        {
            RuleFor(dto => dto.Subscriber)
                .NotEmpty().WithMessage("Ідентифікатор підписника не може бути порожнім.");

        }
    }
}