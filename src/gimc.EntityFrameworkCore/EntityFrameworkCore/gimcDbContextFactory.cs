using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using gimc.Configuration;
using gimc.Web;

namespace gimc.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class gimcDbContextFactory : IDesignTimeDbContextFactory<gimcDbContext>
    {
        public gimcDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<gimcDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            gimcDbContextConfigurer.Configure(builder, configuration.GetConnectionString(gimcConsts.ConnectionStringName));

            return new gimcDbContext(builder.Options);
        }
    }
}
