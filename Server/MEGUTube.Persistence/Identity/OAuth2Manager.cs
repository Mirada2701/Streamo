using Microsoft.Extensions.Options;
using MEGUTube.Application.Common.Exceptions;
using MEGUTube.Application.Common.Interfaces;
using MEGUTube.Application.Common.Models;
using MEGUTube.Application.Models.Lookups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGUTube.Persistence.Identity
{
    public class OAuth2Manager : IProviderAuthManager {
        private IDictionary<string, ITokenVerificator> _verificators;

        public OAuth2Manager(TokenVerificatorsFactory verificatorsFactory) {
            _verificators = verificatorsFactory.CreateVerificators();
        }

        public async Task<(Result Result, UserLookup User)> AuthenticateAsync(string providerName, string providerToken) {
            if (!_verificators.ContainsKey(providerName))
                throw new AuthProviderNotAvailableException(providerName);

            var provider = _verificators[providerName];

            return await provider.VerifyTokenAsync(providerToken);
        }
    }
}
