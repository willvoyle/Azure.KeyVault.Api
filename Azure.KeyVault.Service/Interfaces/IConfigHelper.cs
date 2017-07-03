namespace Azure.KeyVault.Service.Interfaces
{
    public interface IConfigHelper
    {
        string KeyVaultBaseUrl { get; }
        string ClientId { get; }
        string ClientSecret { get; }
    }
}
