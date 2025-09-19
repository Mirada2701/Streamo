using Streamo.Application.Common.Models;
using Streamo.Application.Models.Lookups;

namespace Streamo.Application.Common.Interfaces
{
    public interface IProviderAuthManager {
        Task<(Result Result, UserLookup User)> AuthenticateAsync(
            string providerName, string providerToken);
    }
}
