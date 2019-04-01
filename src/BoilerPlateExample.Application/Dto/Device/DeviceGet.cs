using Abp.Application.Services.Dto;

namespace BoilerPlateExample.Dto.Device
{
    public class DeviceGet : EntityDto
    {
        public string Name { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
