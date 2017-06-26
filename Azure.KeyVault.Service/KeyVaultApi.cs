using Azure.KeyVault.Service.Interfaces;
using Azure.KeyVault.Service.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace Azure.KeyVault.Service
{
    public class KeyVaultApi : IKeyVaultApi
    {
        private readonly IKeyVaultService _keyVaultService;

        public KeyVaultApi(IKeyVaultService keyVaultService)
        {
            _keyVaultService = keyVaultService;
        }

        public string GetSecretValue(string secretName)
        {
            return Task.Run(() => _keyVaultService.GetKeyVaultSecret(secretName)).Result;
        }

        public string GetSecretValue(string secretName, string version)
        {
            return Task.Run(() => _keyVaultService.GetKeyVaultSecret(secretName, version)).Result;
        }

        public string GetSecretValue(Uri secretUri)
        {
            return Task.Run(() => _keyVaultService.GetKeyVaultSecret(secretUri)).Result;
        }
    }
}
