using System.Threading.Tasks;
using Abp.Application.Services;

namespace PTC.DOTIC.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task UpgradeTenantToEquivalentEdition(int upgradeEditionId);
    }
}
