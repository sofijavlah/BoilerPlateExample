using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerPlateExample.Models;

namespace BoilerPlateExample.Dto
{
    public class OfficeListDtoForSelect
    {
        public List<OfficeDto> Offices { get; set; }

        public OfficeListDtoForSelect(IOfficeService officeService)
        {
            Offices = officeService.GetAll();
        }

    }
}
