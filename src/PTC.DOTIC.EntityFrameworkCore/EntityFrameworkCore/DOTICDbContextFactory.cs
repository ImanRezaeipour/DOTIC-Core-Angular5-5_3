using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PTC.DOTIC.Configuration;
using PTC.DOTIC.Web;

namespace PTC.DOTIC.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DOTICDbContextFactory : IDesignTimeDbContextFactory<DOTICDbContext>
    {
        public DOTICDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DOTICDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder(), addUserSecrets: true);

            DOTICDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DOTICConsts.ConnectionStringName));

            return new DOTICDbContext(builder.Options);
        }
    }
}