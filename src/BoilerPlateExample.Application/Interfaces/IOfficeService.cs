using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using BoilerPlateExample.Dto;
using BoilerPlateExample.Models;

namespace BoilerPlateExample
{
    public interface IOfficeService : IApplicationService
    {
        List<OfficeDto> GetAll();

        OfficeDto Get(int id);

        void Create(OfficeDto office);
    }
}
