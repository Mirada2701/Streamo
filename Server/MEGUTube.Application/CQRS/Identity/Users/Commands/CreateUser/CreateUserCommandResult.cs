using MEGUTube.Application.Common.Models;

namespace MEGUTube.Application.CQRS.Identity.Users.Commands.CreateUser {
    public class CreateUserCommandResult
    {
        public Result Result { get; set; } = null!;
        public string? Token { get; set; }
        public int? UserId { get; set; }

        public string? VerificationToken { get; set;}
    }
}
