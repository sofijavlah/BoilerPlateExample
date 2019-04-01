using System;
using System.Collections.Generic;
using System.Linq;
using Abp.Domain.Repositories;
using Abp.UI;
using BoilerPlateExample.Dto.Device;
using BoilerPlateExample.Dto.Employee;
using BoilerPlateExample.Dto.Office;
using BoilerPlateExample.Models;
using Microsoft.EntityFrameworkCore;

namespace BoilerPlateExample.Services
{
    public class DeviceService : BoilerPlateExampleAppServiceBase, IDeviceService
    {
        private readonly IRepository<Device> _deviceRepository;

        private readonly IRepository<DeviceUsage> _usageRepository;

        private readonly IRepository<Employee> _employeeRepository;

        public DeviceService(IRepository<Device> deviceRepository, IRepository<DeviceUsage> usageRepository, IRepository<Employee> employeeRepository)
        {
            _deviceRepository = deviceRepository;
            _usageRepository = usageRepository;
            _employeeRepository = employeeRepository;
        }


        //------------------ GET ------------------//
        public DeviceListDto GetAll()
        {
            var devices = _deviceRepository.GetAll();

            return new DeviceListDto(ObjectMapper.Map<List<DeviceDto>>(devices));
        }

        public DeviceGet Get(int id)
        {
            var device = _deviceRepository.GetAll().Include(x => x.Employee).FirstOrDefault(x => x.Id == id);

            if (device == null)
            {
                throw new UserFriendlyException("Device doesn't exist");
            }

            return ObjectMapper.Map<DeviceGet>(device);
        }

        public Device GetDeviceById(int id)
        {
            var device = _deviceRepository.GetAll().Include(x => x.Employee).FirstOrDefault(x => x.Id == id);

            if (device == null)
            {
                throw new UserFriendlyException("Device doesn't exist");
            }
            return device;
        }


        //---------------- CREATE ------------------//
        public void Create(DevicePost dto)
        {
            Device device = ObjectMapper.Map<Device>(dto);

            var employee = _employeeRepository.GetAll().Include(x => x.Devices).FirstOrDefault(x => x.Id == dto.EmployeeId);
            
            DeviceUsage usage = new DeviceUsage
            {
                From = DateTime.Now,
                To = null,
                Device = device,
                Employee = employee
            };

            _deviceRepository.Insert(device);

            _usageRepository.Insert(usage);
        }


        //---------------- UPDATE -----------------//
        public void Update(int id, DevicePost dto)
        {
            var device = _deviceRepository.Get(id);

            if (device == null)
            {
                throw new UserFriendlyException("Device doesn't exist");
            }

            var employee = _employeeRepository.GetAll().Include(x => x.Devices).FirstOrDefault(x => x.Id == dto.EmployeeId);
            
            var oldUsage = _usageRepository.GetAll().Include(x => x.Device).FirstOrDefault(x => x.Device.Id == id);

            oldUsage.To = DateTime.Now;

            DeviceUsage usage = new DeviceUsage
            {
                From = DateTime.Now,
                To = null,
                Device = device,
                Employee = employee
            };

            _usageRepository.Insert(usage);

            ObjectMapper.Map(dto, device);
        }

       
        //--------------- DELETE ----------------//
        public void Delete(int id)
        {
            var device = _deviceRepository.FirstOrDefault(x => x.Id == id);

            _deviceRepository.Delete(device);
        }
        
    }
}
