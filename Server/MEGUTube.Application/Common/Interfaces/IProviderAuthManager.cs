using MEGUTube.Application.Common.Models;
using MEGUTube.Application.Models.Lookups;

namespace MEGUTube.Application.Common.Interfaces
{
    public interface IProviderAuthManager {
        Task<(Result Result, UserLookup User)> AuthenticateAsync(
            string providerName, string providerToken);
    }
}
