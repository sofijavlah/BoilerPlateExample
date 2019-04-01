using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace BoilerPlateExample.Dto.Employee
{
    [AutoMap(typeof(Models.Employee))]
    public class EmployeeDto : EntityDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
