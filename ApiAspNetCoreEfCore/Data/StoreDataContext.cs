using Microsoft.EntityFrameworkCore;
using ApiAspNetCoreEfCore.Data.Maps;
using ApiAspNetCoreEfCore.Models;

namespace ApiAspNetCoreEfCore.Data
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=prodcat;User ID=sa;Password=Code@2021");
            //optionsBuilder.UseInMemoryDatabase("database");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductMap());
        }
    }
}