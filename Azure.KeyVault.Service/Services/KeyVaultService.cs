using Azure.KeyVault.Service.Interfaces;
using Azure.KeyVault.Service.Services.Interfaces;
using Microsoft.Azure.KeyVault;
using System;
using System.Threading.Tasks;

namespace Azure.KeyVault.Service.Services
{
    public class KeyVaultService : KeyVaultServiceBase, IKeyVaultService
    {
        private readonly IConfigHelper _configHelper;

        public KeyVaultService(IConfigHelper configHelper, IAzureAdHelper azureAdHelper) : base(azureAdHelper)
        {
            _configHelper = configHelper;
        }

        public async Task<string> GetKeyVaultSecret(string secretName)
        {
            var client = base.GetAzureAdClient();
            var secret = await client.GetSecretAsync(_configHelper.KeyVaultBaseUrl, secretName);
            return secret.Value;
        }

        public async Task<string> GetKeyVaultSecret(string secretName, string secretVersion)
        {
            var client = base.GetAzureAdClient();
            var secret = await client.GetSecretAsync(_configHelper.KeyVaultBaseUrl, secretName, secretVersion);
            return secret.Value;
        }

        public async Task<string> GetKeyVaultSecret(Uri secretUri)
        {
            var client = base.GetAzureAdClient();
            var secret = await client.GetSecretAsync(secretUri.AbsolutePath);
            return secret.Value;
        }
    }
}
