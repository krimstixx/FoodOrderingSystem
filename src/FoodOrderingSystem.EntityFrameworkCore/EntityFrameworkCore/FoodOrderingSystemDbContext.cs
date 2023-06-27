using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FoodOrderingSystem.Authorization.Roles;
using FoodOrderingSystem.Authorization.Users;
using FoodOrderingSystem.MultiTenancy;
using FoodOrderingSystem.Entities;

namespace FoodOrderingSystem.EntityFrameworkCore
{
    public class FoodOrderingSystemDbContext : AbpZeroDbContext<Tenant, Role, User, FoodOrderingSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FoodOrderingSystemDbContext(DbContextOptions<FoodOrderingSystemDbContext> options)
            : base(options)
        {
        }
        public DbSet <Division> Divisions { get; set; }
        public DbSet <Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FoodType> FoodTypes { get; set; }
    }
}
