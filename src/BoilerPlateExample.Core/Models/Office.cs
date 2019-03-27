using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;
using Abp.Domain.Entities;
using Abp.Timing;

namespace BoilerPlateExample.Models
{
    [Table("Offices")]
    /// <summary>
    /// 
    /// </summary>
    public class Office : Entity
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the employees.
        /// </summary>
        /// <value>
        /// The employees.
        /// </value>
        public List<Employee> Employees { get; set; } = new List<Employee>();

    }
}
