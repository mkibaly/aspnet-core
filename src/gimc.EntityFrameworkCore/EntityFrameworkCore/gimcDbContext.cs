using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using gimc.Authorization.Roles;
using gimc.Authorization.Users;
using gimc.MultiTenancy;
using gimc.Models;

namespace gimc.EntityFrameworkCore
{
    public class gimcDbContext : AbpZeroDbContext<Tenant, Role, User, gimcDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<DietaryFlag> DietaryFlags { get; set; }
        public virtual DbSet<ProductFlag> ProductFlags { get; set; }

        public gimcDbContext(DbContextOptions<gimcDbContext> options)
            : base(options)
        {
        }
    }
}
