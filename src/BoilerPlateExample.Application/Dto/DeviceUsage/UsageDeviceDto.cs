using System;
using Abp.Application.Services.Dto;

namespace BoilerPlateExample.Dto.DeviceUsage
{
    public class UsageDeviceDto : EntityDto
    {
        public DateTime From { get; set; }

        public DateTime? To { get; set; }

        public string Name { get; set; }
    }
}
