using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace BoilerPlateExample.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class DeviceUsage : Entity
    {
        /// <summary>
        /// Gets or sets from.
        /// </summary>
        /// <value>
        /// From.
        /// </value>
        public DateTime From { get; set; }

        /// <summary>
        /// Gets or sets to.
        /// </summary>
        /// <value>
        /// To.
        /// </value>
        public DateTime? To { get; set; }

        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        /// <value>
        /// The employee.
        /// </value>
        public Employee Employee { get; set; }

        /// <summary>
        /// Gets or sets the device.
        /// </summary>
        /// <value>
        /// The device.
        /// </value>
        public Device Device { get; set; }

    }
}
