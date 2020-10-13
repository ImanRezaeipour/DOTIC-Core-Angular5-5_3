using System.Threading.Tasks;
using Abp.Application.Services;
using PTC.DOTIC.Sessions.Dto;

namespace PTC.DOTIC.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
