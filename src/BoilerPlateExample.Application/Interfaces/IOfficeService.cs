using System.Collections.Generic;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BoilerPlateExample.Dto;

namespace BoilerPlateExample
{
    public interface IOfficeService : IApplicationService
    {
        List<OfficeDto> GetAll();

        OfficeDto Get(int id);

        void Create(OfficeDto office);

        void Delete(int id);

        void Update(int id, OfficeDto dto);
    }
}
