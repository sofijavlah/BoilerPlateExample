using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BoilerPlateExample.EntityFrameworkCore
{
    public class BoilerPlateExampleDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public BoilerPlateExampleDbContext(DbContextOptions<BoilerPlateExampleDbContext> options) 
            : base(options)
        {

        }
    }
}
