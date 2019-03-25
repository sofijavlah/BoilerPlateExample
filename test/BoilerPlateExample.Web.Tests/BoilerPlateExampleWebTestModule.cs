using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerPlateExample.Web.Startup;
namespace BoilerPlateExample.Web.Tests
{
    [DependsOn(
        typeof(BoilerPlateExampleWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class BoilerPlateExampleWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerPlateExampleWebTestModule).GetAssembly());
        }
    }
}