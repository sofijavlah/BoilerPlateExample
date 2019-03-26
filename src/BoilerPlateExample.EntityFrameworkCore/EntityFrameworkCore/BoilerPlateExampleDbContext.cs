using Abp.EntityFrameworkCore;
using BoilerPlateExample.Models;
using Microsoft.EntityFrameworkCore;

namespace BoilerPlateExample.EntityFrameworkCore

{
    public class BoilerPlateExampleDbContext : AbpDbContext
    {
    //Add DbSet properties for your entities...

        /// <summary>
        /// Gets or sets the offices.
        /// </summary>
        /// <value>
        /// The offices.
        /// </value>
        public DbSet<Office> Offices { get; set; }

        /// <summary>
        /// Gets or sets the employees.
        /// </summary>
        /// <value>
        /// The employees.
        /// </value>
        public DbSet<Employee> Employees { get; set; }

        /// <summary>
        /// Gets or sets the devices.
        /// </summary>
        /// <value>
        /// The devices.
        /// </value>
        public DbSet<Device> Devices { get; set; }

        /// <summary>
        /// Gets or sets the device usages.
        /// </summary>
        /// <value>
        /// The device usages.
        /// </value>
        public DbSet<DeviceUsage> DeviceUsages { get; set; }
    
    public BoilerPlateExampleDbContext(DbContextOptions<BoilerPlateExampleDbContext> options) 
            : base(options)
        {

        }
    }
}

