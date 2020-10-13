using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PTC.DOTIC
{
    public class DOTICClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DOTICClientModule).GetAssembly());
        }
    }
}
