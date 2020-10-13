using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PTC.DOTIC
{
    [DependsOn(typeof(DOTICClientModule), typeof(AbpAutoMapperModule))]
    public class DOTICXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DOTICXamarinSharedModule).GetAssembly());
        }
    }
}