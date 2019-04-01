using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using JetBrains.Annotations;

namespace BoilerPlateExample.Dto.DeviceUsage
{
    [AutoMap(typeof(Models.DeviceUsage))]
    public class UsageDto : EntityDto
    {
        public DateTime From { get; set; }

        public DateTime? To { get; set; }
    }
}
