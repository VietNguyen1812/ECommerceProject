using Microsoft.EntityFrameworkCore;
using Rookie.Ecom.DataAccessor.Entities;
using Rookie.Ecom.DataAccessor.Extensions;

namespace Rookie.Ecom.DataAccessor.Data
{
    public class EcommerceDbContext : DbContext
    {

        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable(name: "Category");
            });
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable(name: "Product");
            });
            modelBuilder.Entity<Product>()
                .HasOne(_=>_.Category).WithMany(_=>_.Products).HasForeignKey(_=>_.CategoryId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.SeedProduct();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
