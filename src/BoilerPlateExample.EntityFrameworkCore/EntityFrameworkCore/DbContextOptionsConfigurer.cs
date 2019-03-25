using Microsoft.EntityFrameworkCore;

namespace BoilerPlateExample.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<BoilerPlateExampleDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for BoilerPlateExampleDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
