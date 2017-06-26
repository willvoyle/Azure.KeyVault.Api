using System.Threading.Tasks;

namespace Azure.KeyVault.Service.Interfaces
{
    interface IAzureAdHelper
    {
        Task<string> GetAdAccessToken(string authority, string resource, string scope);
    }
}
