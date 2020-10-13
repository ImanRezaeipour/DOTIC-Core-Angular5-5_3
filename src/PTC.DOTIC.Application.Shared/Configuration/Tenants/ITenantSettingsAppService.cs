using System.Threading.Tasks;
using Abp.Application.Services;
using PTC.DOTIC.Configuration.Tenants.Dto;

namespace PTC.DOTIC.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
