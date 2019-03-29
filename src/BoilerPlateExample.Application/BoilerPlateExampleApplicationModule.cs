using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerPlateExample.Dto.Employee;
using BoilerPlateExample.Models;

namespace BoilerPlateExample
{
    [DependsOn(
        typeof(BoilerPlateExampleCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BoilerPlateExampleApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(config =>
            {
                config.CreateMap<Employee, EmployeeGet>()
                    .ForMember(dest => dest.FirstName, source => source.MapFrom(src => src.FirstName))
                    .ForMember(dest => dest.LastName, source => source.MapFrom(src => src.LastName))
                    .ForMember(dest => dest.Description, source => source.MapFrom(src => src.Office.Description));

                config.CreateMap<EmployeePost, Employee>()
                    .ForMember(dest => dest.FirstName, source => source.MapFrom(src => src.FirstName))
                    .ForMember(dest => dest.LastName, source => source.MapFrom(src => src.LastName))
                    .ForMember(dest => dest.OfficeId, source => source.MapFrom(src => src.OfficeId))
                    .ForMember(dest => dest.Office, source => source.Ignore());
                
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerPlateExampleApplicationModule).GetAssembly());
        }
    }
}