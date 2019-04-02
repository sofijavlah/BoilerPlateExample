using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BoilerPlateExample.Dto.DeviceUsage;

namespace BoilerPlateExample.Dto.Device
{
    public class DeviceUsageHistoryDto : EntityDto
    {
        public List<UsageUserDto> UsageList = new List<UsageUserDto>();
    }
}
