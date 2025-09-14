using MEGUTube.Application.Common.Models;
using MEGUTube.Application.Models.Lookups;

namespace MEGUTube.Application.CQRS.Identity.Users.Commands.SignInUser
{
    public class SignInUserCommandResult
    {
        public Result Result { get; set; } = null!;
        public string Token { get; set; } = null!;
        public UserLookup User { get; set; } = null!;
    }
}
