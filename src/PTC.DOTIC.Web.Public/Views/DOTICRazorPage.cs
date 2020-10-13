using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace PTC.DOTIC.Web.Public.Views
{
    public abstract class DOTICRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected DOTICRazorPage()
        {
            LocalizationSourceName = DOTICConsts.LocalizationSourceName;
        }
    }
}
