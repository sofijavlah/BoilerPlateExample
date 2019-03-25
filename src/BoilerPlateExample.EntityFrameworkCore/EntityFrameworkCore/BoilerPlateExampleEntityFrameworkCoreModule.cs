using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace BoilerPlateExample.EntityFrameworkCore
{
    [DependsOn(
        typeof(BoilerPlateExampleCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class BoilerPlateExampleEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerPlateExampleEntityFrameworkCoreModule).GetAssembly());
        }
    }
}