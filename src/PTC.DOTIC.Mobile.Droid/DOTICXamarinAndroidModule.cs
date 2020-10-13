using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PTC.DOTIC
{
    [DependsOn(typeof(DOTICXamarinSharedModule))]
    public class DOTICXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DOTICXamarinAndroidModule).GetAssembly());
        }
    }
}