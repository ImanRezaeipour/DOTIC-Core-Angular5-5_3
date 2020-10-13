using System.Threading.Tasks;
using PTC.DOTIC.ApiClient.Models;

namespace PTC.DOTIC.ApiClient
{
    public interface IAccessTokenManager
    {
        Task<string> GetAccessTokenAsync();
         
        Task<AbpAuthenticateResultModel> LoginAsync();

        void Logout();

        bool IsUserLoggedIn { get; }
    }
}