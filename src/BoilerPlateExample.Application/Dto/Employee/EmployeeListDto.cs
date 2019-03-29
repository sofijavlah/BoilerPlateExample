using System.Collections.Generic;

namespace BoilerPlateExample.Dto.Employee
{
    public class EmployeeListDto
    {
        public IReadOnlyList<EmployeeGet> Employees { get; }

        public EmployeeListDto(IReadOnlyList<EmployeeGet> employees)
        {
            Employees = employees;
        }
    }
}
