using System.Threading.Tasks;

namespace Azure.KeyVault.Service.Interfaces
{
    public interface IAzureAdHelper
    {
        Task<string> GetAdAccessToken(string authority, string resource, string scope);
    }
}
