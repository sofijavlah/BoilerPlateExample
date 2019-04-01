using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerPlateExample.Dto.Employee;
using BoilerPlateExample.Interfaces;

namespace BoilerPlateExample.Web.Dto
{
    public class EmployeeListDtoForSelect
    {
        public EmployeeListDto Employees { get; set; }

        public EmployeeListDtoForSelect(IEmployeeService employeeService)
        {
            Employees = employeeService.GetAll();
        }
    }
}
