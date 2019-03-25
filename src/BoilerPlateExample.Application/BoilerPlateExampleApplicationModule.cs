using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace BoilerPlateExample
{
    [DependsOn(
        typeof(BoilerPlateExampleCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BoilerPlateExampleApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerPlateExampleApplicationModule).GetAssembly());
        }
    }
}