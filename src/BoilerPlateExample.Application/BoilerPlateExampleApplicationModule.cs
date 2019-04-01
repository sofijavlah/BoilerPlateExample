using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerPlateExample.Dto.Device;
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

                config.CreateMap<DevicePost, Device>()
                    .ForMember(dest => dest.Name, source => source.MapFrom(src => src.Name))
                    .ForMember(dest => dest.EmployeeId, source => source.MapFrom(src => src.EmployeeId))
                    .ForMember(dest => dest.Employee, source => source.Ignore());

                config.CreateMap<Device, DeviceGet>()
                    .ForMember(dest => dest.FirstName, source => source.MapFrom(src => src.Employee.FirstName))
                    .ForMember(dest => dest.LastName, source => source.MapFrom(src => src.Employee.LastName))
                    .ForMember(dest => dest.Name, source => source.MapFrom(src => src.Name));
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerPlateExampleApplicationModule).GetAssembly());
        }
    }
}