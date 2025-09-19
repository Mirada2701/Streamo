using MediatR;
using Streamo.Application.Common.Models;

namespace Streamo.Application.CQRS.Identity.Users.Commands.ChangePassword {
    public class ChangePasswordCommand : IRequest<Result> {
        public string Password { get; set; } = null!;
        public int UserId { get; set; }
        public string NewPassword { get; set; } = null!;
    }
}
