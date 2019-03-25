using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerPlateExample.Configuration;
using BoilerPlateExample.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace BoilerPlateExample.Web.Startup
{
    [DependsOn(
        typeof(BoilerPlateExampleApplicationModule), 
        typeof(BoilerPlateExampleEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class BoilerPlateExampleWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public BoilerPlateExampleWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(BoilerPlateExampleConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<BoilerPlateExampleNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(BoilerPlateExampleApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerPlateExampleWebModule).GetAssembly());
        }
    }
}