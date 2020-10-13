using System.Threading.Tasks;
using Abp.Application.Services;
using PTC.DOTIC.Configuration.Host.Dto;

namespace PTC.DOTIC.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
