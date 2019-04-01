using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace BoilerPlateExample.Dto
{
    [AutoMap(typeof(Models.Office))]
    public class OfficeDto : EntityDto //(za mapiranje id-ja)
    {
        /// <summary>
        /// Gets or sets the name of the office.
        /// </summary>
        /// <value>
        /// The name of the office.
        /// </value>
        public string Description { get; set; }

    }
}
