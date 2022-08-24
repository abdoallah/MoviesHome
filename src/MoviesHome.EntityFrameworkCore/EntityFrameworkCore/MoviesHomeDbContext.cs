using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MoviesHome.Authorization.Roles;
using MoviesHome.Authorization.Users;
using MoviesHome.MultiTenancy;

namespace MoviesHome.EntityFrameworkCore
{
    public class MoviesHomeDbContext : AbpZeroDbContext<Tenant, Role, User, MoviesHomeDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MoviesHomeDbContext(DbContextOptions<MoviesHomeDbContext> options)
            : base(options)
        {
        }
    }
}
