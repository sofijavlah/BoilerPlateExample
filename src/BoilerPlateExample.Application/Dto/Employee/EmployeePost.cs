using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BoilerPlateExample.Models;

namespace BoilerPlateExample.Dto.Employee
{
    
    public class EmployeePost : EntityDto
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the office identifier.
        /// </summary>
        /// <value>
        /// The office identifier.
        /// </value>
        public int OfficeId { get; set; }
    }
}
