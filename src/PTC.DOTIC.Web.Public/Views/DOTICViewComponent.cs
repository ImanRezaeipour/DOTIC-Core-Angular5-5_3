using Abp.AspNetCore.Mvc.ViewComponents;

namespace PTC.DOTIC.Web.Public.Views
{
    public abstract class DOTICViewComponent : AbpViewComponent
    {
        protected DOTICViewComponent()
        {
            LocalizationSourceName = DOTICConsts.LocalizationSourceName;
        }
    }
}