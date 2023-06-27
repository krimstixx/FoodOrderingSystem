using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderingSystem.EntityFrameworkCore
{
    public static class FoodOrderingSystemDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FoodOrderingSystemDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FoodOrderingSystemDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
