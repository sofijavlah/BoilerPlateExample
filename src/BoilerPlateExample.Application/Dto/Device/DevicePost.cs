using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;

namespace BoilerPlateExample.Dto.Device
{
    public class DevicePost : EntityDto
    {
        public string Name { get; set; }

        public int EmployeeId { get; set; }
    }
}
