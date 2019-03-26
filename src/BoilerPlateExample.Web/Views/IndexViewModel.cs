using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerPlateExample.Dto;

namespace BoilerPlateExample.Web.Views
{
    public class IndexViewModel
    {
        public IReadOnlyList<OfficeDto> Offices { get; }

        public IndexViewModel(IReadOnlyList<OfficeDto> offices)
        {
            Offices = offices;
        }

    }
}
