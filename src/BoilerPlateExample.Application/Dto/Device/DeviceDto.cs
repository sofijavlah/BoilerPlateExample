using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;

namespace BoilerPlateExample.Dto.Device
{
    public class DeviceDto : EntityDto
    {
        public string Name { get; set; }
    }
}
