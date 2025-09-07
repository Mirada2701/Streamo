using Streamo.Application.Common.Models;
using Streamo.Application.Models.Lookups;

namespace Streamo.Application.Common.Interfaces
{
    public interface ITokenVerificator {
        Task<(Result Result, UserLookup User)> VerifyTokenAsync(string providerToken);
    }
}
