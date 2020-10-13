using System.Threading.Tasks;
using PTC.DOTIC.ApiClient.Models;

namespace PTC.DOTIC.Services.Account
{
    public interface IAccountService
    {
        AbpAuthenticateModel AbpAuthenticateModel { get; set; }
        AbpAuthenticateResultModel AuthenticateResultModel { get; set; }
        Task LoginUserAsync();
    }
}
