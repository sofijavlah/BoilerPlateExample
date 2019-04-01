using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerPlateExample.Dto.Device
{
    public class DeviceListDto
    {
        public IReadOnlyList<DeviceDto> Devices { get; }

        public DeviceListDto(IReadOnlyList<DeviceDto> devices)
        {
            Devices = devices;
        }
    }
}
