using Streamo.Application.Common.Models;
using Streamo.Application.Models.Lookups;

namespace Streamo.Application.CQRS.Identity.Users.Commands.SignInUser
{
    public class SignInUserCommandResult
    {
        public Result Result { get; set; } = null!;
        public string Token { get; set; } = null!;
        public UserLookup User { get; set; } = null!;
    }
}
