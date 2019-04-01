using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BoilerPlateExample.Dto.DeviceUsage;

namespace BoilerPlateExample.Dto.Device
{
    [AutoMap(typeof(Models.Device))]
    public class DeviceUsageHistoryDto : EntityDto
    {
        List<UsageUserDto> UsageList = new List<UsageUserDto>();
    }
}
