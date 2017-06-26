using System;
using System.Threading.Tasks;

namespace Azure.KeyVault.Service.Services.Interfaces
{
    public interface IKeyVaultService
    {
        Task<string> GetKeyVaultSecret(string secretName);
        Task<string> GetKeyVaultSecret(string secretName, string version);
        Task<string> GetKeyVaultSecret(Uri secretUri);
    }
}