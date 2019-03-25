using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerPlateExample.Localization;

namespace BoilerPlateExample
{
    public class BoilerPlateExampleCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            BoilerPlateExampleLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerPlateExampleCoreModule).GetAssembly());
        }
    }
}