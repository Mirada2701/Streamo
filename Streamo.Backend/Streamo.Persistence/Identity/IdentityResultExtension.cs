using Microsoft.AspNetCore.Identity;
using Streamo.Application.Common.Models;

namespace Streamo.Persistence.Identity
{
    public static class IdentityResultExtension
    {
        public static Result ToApplicationResult(this IdentityResult result)
        {
            return result.Succeeded
                ? Result.Success()
                : Result.Failure(result.Errors.Select(e => e.Description));
        }
    }
}
