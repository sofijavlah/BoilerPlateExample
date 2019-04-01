using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.UI;
using BoilerPlateExample.Dto;
using BoilerPlateExample.Dto.Office;
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

        public OfficeEmployeeListDto Get(int id)
        {
            var office = _officeRepository.GetAll().Include(x => x.Employees).FirstOrDefault(x => x.Id == id);

            return ObjectMapper.Map<OfficeEmployeeListDto>(office);
        }

        public Office GetOfficeById(int id)
        {
            return _officeRepository.Get(id);
        }

        public void Create(OfficeDto dto)
        {
            Office office = ObjectMapper.Map<Office>(dto);

            _officeRepository.Insert(office);

        }

        public void Update(int id, OfficeDto dto)
        {
            var office = _officeRepository.Get(id);

            ObjectMapper.Map(dto, office);
        }

        public void Delete(int id)
        {
            var office = _officeRepository.FirstOrDefault(x => x.Id == id);

            if (office == null)
            {
                throw new UserFriendlyException("Bad id");
            }

            _officeRepository.Delete(office);
        }
    }
}
