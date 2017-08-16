using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using PhoogleZero.Configuration;
using PhoogleZero.Web;

namespace PhoogleZero.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PhoogleZeroDbContextFactory : IDbContextFactory<PhoogleZeroDbContext>
    {
        public PhoogleZeroDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<PhoogleZeroDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PhoogleZeroDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PhoogleZeroConsts.ConnectionStringName));
            
            return new PhoogleZeroDbContext(builder.Options);
        }
    }
}