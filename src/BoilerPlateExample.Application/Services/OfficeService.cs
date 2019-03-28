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

        public void Create(OfficeDto dto)
        {
            Office office = ObjectMapper.Map<Office>(dto);

            _officeRepository.Insert(office);

        }

        public void Update(int id, OfficeDto dto)
        {

        }

        public void Delete(int id1)
        {

        }

        
    }
}
