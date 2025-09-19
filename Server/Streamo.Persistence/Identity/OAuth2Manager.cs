using Microsoft.Extensions.Options;
using Streamo.Application.Common.Exceptions;
using Streamo.Application.Common.Interfaces;
using Streamo.Application.Common.Models;
using Streamo.Application.Models.Lookups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streamo.Persistence.Identity
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
