using System;
using System.Collections.Generic;
using System.Text;
using BoilerPlateExample.Dto.Device;

namespace BoilerPlateExample.Dto.Office
{
    public interface IDeviceService
    {
        DeviceListDto GetAll();

        DeviceGet Get(int id);

        void Create(DevicePost dto);

        void Delete(int id);

        void Update(int id, DevicePost dto);

        Models.Device GetDeviceById(int id);
    }
}
