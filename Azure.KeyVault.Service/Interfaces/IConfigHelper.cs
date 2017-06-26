namespace Azure.KeyVault.Service.Interfaces
{
    internal interface IConfigHelper
    {
        string KeyVaultBaseUrl { get; }
        string ClientId { get; }
        string ClientSecret { get; }
    }
}
