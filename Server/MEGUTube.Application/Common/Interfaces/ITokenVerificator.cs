using MEGUTube.Application.Common.Models;
using MEGUTube.Application.Models.Lookups;

namespace MEGUTube.Application.Common.Interfaces
{
    public interface ITokenVerificator {
        Task<(Result Result, UserLookup User)> VerifyTokenAsync(string providerToken);
    }
}
