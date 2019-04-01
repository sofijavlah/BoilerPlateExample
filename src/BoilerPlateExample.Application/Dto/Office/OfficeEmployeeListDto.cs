using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BoilerPlateExample.Dto.Employee;

namespace BoilerPlateExample.Dto.Office
{
    [AutoMap(typeof(Models.Office))]
    public class OfficeEmployeeListDto : EntityDto
    {
        public string Description { get; set; }

        public List<EmployeeDto> Employees { get; set; } = new List<EmployeeDto>();
    }
}
