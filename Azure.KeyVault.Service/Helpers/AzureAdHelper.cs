using Azure.KeyVault.Service.Interfaces;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Threading.Tasks;

namespace Azure.KeyVault.Service.Helpers
{
    internal class AzureAdHelper : IAzureAdHelper
    {
        private readonly IConfigHelper _configHelper;

        public AzureAdHelper(IConfigHelper configHelper)
        {
            _configHelper = configHelper;
        }

        public async Task<string> GetAdAccessToken(string authority, string resource, string scope)
        {
            var context = new AuthenticationContext(authority, TokenCache.DefaultShared);
            var clientCredential = new ClientCredential(_configHelper.ClientId, _configHelper.ClientSecret);
            var tokenresponse = await context.AcquireTokenAsync(resource, clientCredential);
            return tokenresponse.AccessToken;
        }
    }
}
