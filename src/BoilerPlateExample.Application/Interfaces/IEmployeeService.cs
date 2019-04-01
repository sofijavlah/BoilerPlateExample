using System;
using System.Collections.Generic;
using System.Text;
using BoilerPlateExample.Dto;
using BoilerPlateExample.Dto.Employee;
using BoilerPlateExample.Models;

namespace BoilerPlateExample.Interfaces
{
    public interface IEmployeeService
    {
        EmployeeListDto GetAll();

        EmployeeGet Get(int id);

        void Create(EmployeePost dto);

        void Delete(int id);

        void Update(int id, EmployeePost dto);

        Employee GetEmployeeById(int id);
    }
}
