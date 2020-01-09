using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace gimc.EntityFrameworkCore
{
    public static class gimcDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<gimcDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<gimcDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
