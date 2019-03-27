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
    public class OfficeService : BoilerPlateExampleAppServiceBase, IOfficeService
    {
        private readonly IRepository<Office> _officeRepository;

        public OfficeService(IRepository<Office> officeRepository)
        {
            _officeRepository = officeRepository;
        }

        public List<OfficeDto> GetAll()
        {
            var offices = _officeRepository.GetAll();

            return new List<OfficeDto>(ObjectMapper.Map<List<OfficeDto>>(offices));
        }

        public OfficeDto Get(int id)
        {
            var office = _officeRepository.Get(id);

            return ObjectMapper.Map<OfficeDto>(office);
        }

        public void Create(OfficeDto office)
        {
            Office newOffice = ObjectMapper.Map<Office>(office);

            _officeRepository.Insert(newOffice);

        }
        
    }
}
