using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using BoilerPlateExample.Dto;
using BoilerPlateExample.Models;

namespace BoilerPlateExample
{
    public interface IFirstService : IApplicationService
    {
        Task<List<OfficeDto>> GetAll();
    }
}
