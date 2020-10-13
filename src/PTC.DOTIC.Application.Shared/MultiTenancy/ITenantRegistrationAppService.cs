using System.Threading.Tasks;
using Abp.Application.Services;
using PTC.DOTIC.Editions.Dto;
using PTC.DOTIC.MultiTenancy.Dto;

namespace PTC.DOTIC.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}