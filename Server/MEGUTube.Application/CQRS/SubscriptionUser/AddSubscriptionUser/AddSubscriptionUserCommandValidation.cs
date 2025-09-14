// SubscriptionUserCommandHandler.cs
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MEGUTube.Application.Common.DbContexts;
using MEGUTube.Application.CQRS.Identity.Users.Commands.CreateUser;
using MEGUTube.Domain.Entities;

namespace MEGUTube.Application.CQRS.SubscriptionUser.AddSubscriptionUser
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