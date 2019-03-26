using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using BoilerPlateExample.Dto;
using BoilerPlateExample.Models;
using Microsoft.EntityFrameworkCore;

namespace BoilerPlateExample
{
    public class FirstService : BoilerPlateExampleAppServiceBase, IFirstService
    {
        private readonly IRepository<Office> _officeRepository;

        public FirstService(IRepository<Office> officeRepository)
        {
            _officeRepository = officeRepository;
        }

        public async Task<List<OfficeDto>> GetAll()
        {
            var offices = await _officeRepository.GetAll().OrderByDescending(x => x.Description).ToListAsync();

            return new List<OfficeDto>(ObjectMapper.Map<List<OfficeDto>>(offices));
        }
    }
}
