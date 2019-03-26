using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.Timing;

namespace BoilerPlateExample.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Office : Entity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public long Id { get; set; }

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

        //public DateTime CreationTime { get; set; }

        //public Office()
        //{
        //    CreationTime = Clock.Now;
        //}
    }
}
