using BoilerPlateExample.Configuration;
using BoilerPlateExample.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BoilerPlateExample.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class BoilerPlateExampleDbContextFactory : IDesignTimeDbContextFactory<BoilerPlateExampleDbContext>
    {
        public BoilerPlateExampleDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BoilerPlateExampleDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(BoilerPlateExampleConsts.ConnectionStringName)
            );

            return new BoilerPlateExampleDbContext(builder.Options);
        }
    }
}