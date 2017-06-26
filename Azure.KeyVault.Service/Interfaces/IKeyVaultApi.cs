using System;

namespace Azure.KeyVault.Service.Interfaces
{
    public interface IKeyVaultApi
    {
        string GetSecretValue(string secretName);
        string GetSecretValue(string secretName, string version);
        string GetSecretValue(Uri secretUri);

    }
}