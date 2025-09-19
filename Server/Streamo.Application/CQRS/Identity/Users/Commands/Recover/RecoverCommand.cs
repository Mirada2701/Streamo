using MediatR;
using Streamo.Application.Common.Models;

namespace Streamo.Application.CQRS.Identity.Users.Commands.Recover {
    public class RecoverCommand : IRequest<Result> {
        public string Email { get; set; } = null!;
    }
}
