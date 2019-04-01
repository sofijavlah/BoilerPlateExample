using System.Collections.Generic;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BoilerPlateExample.Dto;
using BoilerPlateExample.Dto.Office;
using BoilerPlateExample.Models;

namespace BoilerPlateExample
{
    public interface IOfficeService : IApplicationService
    {
        List<OfficeDto> GetAll();

        OfficeEmployeeListDto Get(int id);

        Office GetOfficeById(int id);

        void Create(OfficeDto office);

        void Delete(int id);

        void Update(int id, OfficeDto dto);
    }
}
