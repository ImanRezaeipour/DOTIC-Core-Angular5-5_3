using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PTC.DOTIC.EntityFrameworkCore
{
    public static class DOTICDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DOTICDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DOTICDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}