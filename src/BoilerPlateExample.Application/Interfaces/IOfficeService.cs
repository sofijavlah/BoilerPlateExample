using System.Collections.Generic;
using Abp.Application.Services;
using BoilerPlateExample.Dto;

namespace BoilerPlateExample
{
    public interface IOfficeService : IApplicationService
    {
        List<OfficeDto> GetAll();

        OfficeDto Get(int id);

        void Create(OfficeDto office);
    }
}
