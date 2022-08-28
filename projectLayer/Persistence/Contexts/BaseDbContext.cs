using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using projectLayer.Domain.Entities;

namespace projectLayer.Persistence.Contexts
{
    public class BaseDbContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public DbSet<Product> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductStock> ProductStocks { get; set; }

        public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //    base.OnConfiguring(
            //        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SomeConnectionString")));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(a =>
            {
                a.ToTable("Categories").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.CategoryName).HasColumnName("CategoryName");
            });
            modelBuilder.Entity<Product>(a =>
            {
                a.ToTable("Products").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.CategoryId).HasColumnName("CategoryId");
                a.Property(p => p.ProductName).HasColumnName("ProductName");
                a.Property(p => p.Price).HasColumnName("Price");
                a.Property(p => p.ListPrice).HasColumnName("ListPrice");
            });
            modelBuilder.Entity<ProductStock>(a =>
            {
                a.ToTable("ProductStocks").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.UnitStock).HasColumnName("UnitStock");
            });

            //Category[] categoryEntitySeeds = { new(1, "Kadın"), new(2, "Erkek") };
            //modelBuilder.Entity<Category>().HasData(categoryEntitySeeds);
        }
    }
}