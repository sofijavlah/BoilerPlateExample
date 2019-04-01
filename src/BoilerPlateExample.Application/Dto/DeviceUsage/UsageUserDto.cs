using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;

namespace BoilerPlateExample.Dto.DeviceUsage
{
    public class UsageUserDto : EntityDto
    {
        public DateTime From { get; set; }

        public DateTime? To { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
