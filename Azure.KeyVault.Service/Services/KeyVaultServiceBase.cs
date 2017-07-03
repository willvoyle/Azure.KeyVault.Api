using Azure.KeyVault.Service.Interfaces;
using Microsoft.Azure.KeyVault;
using System.Net.Http;

namespace Azure.KeyVault.Service.Services
{
    public abstract class KeyVaultServiceBase
    {
        private readonly IAzureAdHelper _azureAdHelper;

        public KeyVaultServiceBase(IAzureAdHelper azureAdHelper)
        {
            _azureAdHelper = azureAdHelper;
        }

        protected KeyVaultClient GetAzureAdClient()
        {
            var callback = new KeyVaultClient.AuthenticationCallback(_azureAdHelper.GetAdAccessToken);
            return new KeyVaultClient(callback, new HttpClient());
        }
    }
}
