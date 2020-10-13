using Abp.Domain.Services;

namespace PTC.DOTIC
{
    public abstract class DOTICDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected DOTICDomainServiceBase()
        {
            LocalizationSourceName = DOTICConsts.LocalizationSourceName;
        }
    }
}
