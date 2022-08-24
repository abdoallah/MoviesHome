using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MoviesHome.EntityFrameworkCore
{
    public static class MoviesHomeDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MoviesHomeDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MoviesHomeDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
