using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoilerPlateExample.Dto
{
    public class OfficeListDto
    {
        public List<OfficeDto> Offices { get; }

        public OfficeListDto(List<OfficeDto> offices)
        {
            Offices = offices;
        }

    }
}
