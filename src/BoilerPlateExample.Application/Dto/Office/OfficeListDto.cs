using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoilerPlateExample.Dto
{
    public class OfficeListDto
    {
        public IReadOnlyList<OfficeDto> Offices { get; }

        public OfficeListDto(IReadOnlyList<OfficeDto> offices)
        {
            Offices = offices;
        }

    }
}
