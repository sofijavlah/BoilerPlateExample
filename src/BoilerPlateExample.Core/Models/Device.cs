using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace BoilerPlateExample.Models
{
    /// <summary>
    /// Device model class
    /// </summary>
    public class Device : Entity
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        /// <value>
        /// The employee.
        /// </value>
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        /// <summary>
        /// Gets or sets the usage list.
        /// </summary>
        /// <value>
        /// The usage list.
        /// </value>
        public List<DeviceUsage> UsageList { get; set; } = new List<DeviceUsage>();

    }
}
