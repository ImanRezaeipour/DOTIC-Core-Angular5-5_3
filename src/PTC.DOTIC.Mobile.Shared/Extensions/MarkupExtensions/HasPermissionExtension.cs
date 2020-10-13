using System;
using PTC.DOTIC.Core;
using PTC.DOTIC.Core.Dependency;
using PTC.DOTIC.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PTC.DOTIC.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}