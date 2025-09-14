using MediatR;
using MEGUTube.Application.Common.Models;

namespace MEGUTube.Application.CQRS.Identity.Users.Commands.Recover {
    public class RecoverCommand : IRequest<Result> {
        public string Email { get; set; } = null!;
    }
}
