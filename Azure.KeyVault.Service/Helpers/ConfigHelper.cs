using Azure.KeyVault.Service.Interfaces;
using System.Configuration;

namespace Azure.KeyVault.Service.Helpers
{
    class ConfigHelper : IConfigHelper
    {
        public string KeyVaultBaseUrl { get => ConfigurationManager.AppSettings["KeyVaultBaseUrl"]; }
        public string ClientId { get => ConfigurationManager.AppSettings["ClientId"]; }
        public string ClientSecret { get => ConfigurationManager.AppSettings["ClientSecret"]; }
    }
}
