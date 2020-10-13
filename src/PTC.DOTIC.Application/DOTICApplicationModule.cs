using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PTC.DOTIC.Authorization;

namespace PTC.DOTIC
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(DOTICCoreModule)
        )]
    public class DOTICApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DOTICApplicationModule).GetAssembly());
        }
    }
}