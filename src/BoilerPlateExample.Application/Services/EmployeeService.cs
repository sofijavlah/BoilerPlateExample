using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Domain.Repositories;
using Abp.UI;
using BoilerPlateExample.Dto;
using BoilerPlateExample.Dto.Employee;
using BoilerPlateExample.Interfaces;
using BoilerPlateExample.Models;
using Microsoft.EntityFrameworkCore;

namespace BoilerPlateExample.Services
{
    public class EmployeeService : BoilerPlateExampleAppServiceBase, IEmployeeService
    {
        private readonly IRepository<Employee> _employeeRepository;

        public EmployeeService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public EmployeeListDto GetAll()
        {
            var employees = _employeeRepository.GetAll().Include(x => x.Office);

            return new EmployeeListDto(ObjectMapper.Map<List<EmployeeGet>>(employees));
        }

        public EmployeeGet Get(int id)
        {
            var employee = _employeeRepository.GetAll().Include(x => x.Office).FirstOrDefault(x => x.Id == id);

            if (employee == null)
            {
                throw new UserFriendlyException("Employee doesn't exist");
            }

            return ObjectMapper.Map<EmployeeGet>(employee);
        }

        public void Create(EmployeePost dto)
        {
            Employee employee = ObjectMapper.Map<Employee>(dto);

            _employeeRepository.Insert(employee);

        }

        public void Update(int id, EmployeePost dto)
        {
            var employee = _employeeRepository.Get(id);

            if (employee == null)
            {
                throw new UserFriendlyException("Employee doesn't exist");
            }

            ObjectMapper.Map(dto, employee);
        }

        public void Delete(int id)
        {
            var employee = _employeeRepository.FirstOrDefault(x => x.Id == id);
            
            _employeeRepository.Delete(employee);
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = _employeeRepository.GetAll().Include(x => x.Office).FirstOrDefault(x => x.Id == id);

            if (employee == null)
            {
                throw new UserFriendlyException("Employee doesn't exist");
            }
            return employee;
        }
    }
}
