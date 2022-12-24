using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Persistence.Concrete.Contexts
{
    public class BaseDbContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandImage> BrandImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Feature> Feature { get; set; }
        public DbSet<FeatureValue> FeatureValues { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<ProductStock> ProductStocks { get; set; }
        public DbSet<Customer> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<VariantValue> VariantValues { get; set; }

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
            modelBuilder.Entity<Brand>(b =>
            {
                b.ToTable("Brands").HasKey(k => k.Id);
                b.Property(p => p.Id).HasColumnName("Id");

                b.Property(p => p.BrandName).HasColumnName("BrandName");
                b.Property(p => p.BrandName).IsRequired();
                b.Property(p => p.BrandName).HasMaxLength(30);
            });

            modelBuilder.Entity<BrandImage>(b =>
            {
                b.ToTable("BrandImages").HasKey(k => k.Id);
                b.Property(p => p.Id).HasColumnName("Id");
                
                b.Property(p => p.BrandId).HasColumnName("BrandId").IsRequired();
                b.HasOne(p => p.Brand).WithMany(p => p.BrandImages).HasForeignKey(p => p.BrandId);
                
                b.Property(p => p.FileName).HasColumnName("FileName").IsRequired();
                b.Property(p => p.FileName).HasMaxLength(50);
                
                b.Property(p => p.FilePath).HasColumnName("FileName").IsRequired();
                b.Property(p => p.FilePath).HasMaxLength(255);

                b.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
                b.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate").IsRequired();
            });

            modelBuilder.Entity<Category>(c =>
            {
                c.ToTable("Categories").HasKey(k => k.Id);
                c.Property(p => p.Id).HasColumnName("Id");

                c.Property(p => p.CategoryName).HasColumnName("CategoryName").IsRequired();
                c.Property(p => p.CategoryName).HasMaxLength(30);
            });

            modelBuilder.Entity<Favorite>(f =>
            {
                f.ToTable("Favorites").HasKey(k => k.Id);
                f.Property(p => p.Id).HasColumnName("Id");

                f.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
                f.HasOne(p => p.Product).WithMany(p => p.Favorites).HasForeignKey(p => p.ProductId);

                f.Property(p => p.CustomerId).HasColumnName("UserId").IsRequired();
                f.HasOne(p => p.Customer).WithMany(p => p.Favorites).HasForeignKey(p => p.CustomerId);
            });

            modelBuilder.Entity<Feature>(f =>
            {
                f.ToTable("Features").HasKey(k => k.Id);
                f.Property(p => p.Id).HasColumnName("Id");

                f.Property(p => p.FeatureName).HasColumnName("FeatureName").IsRequired();
                f.Property(p => p.FeatureName).HasMaxLength(30);
            });

            modelBuilder.Entity<FeatureValue>(f =>
            {
                f.ToTable("FeatureValues").HasKey(k => k.Id);
                f.Property(p => p.Id).HasColumnName("Id");

                f.Property(p => p.FeatureId).HasColumnName("FeatureId").IsRequired();
                f.HasOne(p => p.Feature).WithMany(p => p.FeatureValues).HasForeignKey(p => p.FeatureId);

                f.Property(p => p.Value).HasColumnName("Value").IsRequired();
                f.Property(p => p.Value).HasMaxLength(40);
            });

            modelBuilder.Entity<OperationClaim>(o =>
            {
                o.ToTable("OperationClaims").HasKey(k => k.Id);
                o.Property(p => p.Id).HasColumnName("Id");

                o.Property(p => p.Name).HasColumnName("Name").IsRequired();
                o.Property(p => p.Name).HasMaxLength(30);
            });

            modelBuilder.Entity<Product>(p =>
            {
                p.ToTable("Products").HasKey(k => k.Id);
                p.Property(p => p.Id).HasColumnName("Id");

                p.Property(p => p.ProductName).HasColumnName("ProductName");
                p.Property(p => p.ProductName).HasMaxLength(40);
                
                p.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
                
                p.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            modelBuilder.Entity<ProductBrand>(p =>
            {
                p.ToTable("ProductBrands").HasKey(k => k.Id);
                p.Property(p => p.Id).HasColumnName("Id");
                
                p.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
                p.HasOne(p => p.Product).WithMany(p => p.ProductBrands).HasForeignKey(p => p.ProductId);

                p.Property(p => p.BrandId).HasColumnName("BrandId").IsRequired();
                p.HasOne(p => p.Brand).WithMany(p => p.ProductBrands).HasForeignKey(p => p.BrandId);
            });

            modelBuilder.Entity<ProductCategory>(p =>
            {
                p.ToTable("ProductCategories").HasKey(k => k.Id);
                p.Property(p => p.Id).HasColumnName("Id");

                p.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
                p.HasOne(p => p.Product).WithMany(p => p.ProductCategories).HasForeignKey(p => p.ProductId);

                p.Property(p => p.CategoryId).HasColumnName("CategoryId").IsRequired();
                p.HasOne(p => p.Category).WithMany(p => p.ProductCategories).HasForeignKey(p => p.CategoryId);
            });

            modelBuilder.Entity<ProductFeature>(p =>
            {
                p.ToTable("ProductFeatures").HasKey(k => k.Id);
                p.Property(p => p.Id).HasColumnName("Id");

                p.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
                p.HasOne(p => p.Product).WithMany(p => p.ProductFeatures).HasForeignKey(p => p.ProductId);

                p.Property(p => p.FeatureValueId).HasColumnName("FeatureValueId").IsRequired();
                p.HasOne(p => p.FeatureValue).WithMany(p => p.ProductFeatures).HasForeignKey(p => p.FeatureValueId);
            });

            modelBuilder.Entity<ProductVariant>(p =>
            {
                p.ToTable("ProductVariants").HasKey(k => k.Id);
                p.Property(p => p.Id).HasColumnName("Id");

                p.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
                p.HasOne(p => p.Product).WithMany(p => p.ProductVariants).HasForeignKey(p => p.ProductId);

                p.Property(p => p.VariantValueId).HasColumnName("VariantValueId").IsRequired();
                p.HasOne(p => p.VariantValue).WithMany(p => p.ProductVariants).HasForeignKey(p => p.VariantValueId);

                p.Property(p => p.VariantPrice).HasColumnName("VariantPrice").IsRequired();
            });

            modelBuilder.Entity<ProductImage>(p =>
            {
                p.ToTable("ProductImages").HasKey(k => k.Id);
                p.Property(p => p.Id).HasColumnName("Id");

                p.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
                p.HasOne(p => p.Product).WithMany(p => p.ProductImages).HasForeignKey(p => p.ProductId);

                p.Property(p => p.FileName).HasColumnName("FileName").IsRequired();
                p.Property(p => p.FileName).HasMaxLength(50);

                p.Property(p => p.FilePath).HasColumnName("FileName").IsRequired();
                p.Property(p => p.FilePath).HasMaxLength(255);

                p.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
                p.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate").IsRequired();
            });

            modelBuilder.Entity<ProductStock>(p =>
            {
                p.ToTable("ProductStocks").HasKey(k => k.Id);
                p.Property(p => p.Id).HasColumnName("Id");

                p.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
                p.HasOne(p => p.Product).WithMany(p => p.ProductStocks).HasForeignKey(p => p.ProductId);

                p.Property(p => p.UnitStock).HasColumnName("UnitStock").IsRequired();
                
                p.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate").IsRequired();
            });

            modelBuilder.Entity<Customer>(u =>
            {
                u.ToTable("Users").HasKey(k => k.Id);
                u.Property(p => p.Id).HasColumnName("Id");

                u.Property(p => p.FirstName).HasColumnName("FirstName").IsRequired();
                u.Property(p => p.FirstName).HasMaxLength(30);

                u.Property(p => p.LastName).HasColumnName("LastName").IsRequired();
                u.Property(p => p.LastName).HasMaxLength(30);

                u.Property(p => p.Email).HasColumnName("Email").IsRequired();
                u.Property(p => p.Email).HasMaxLength(40);

                u.Property(p => p.PasswordHash).HasColumnName("PasswordHash").IsRequired();
                u.Property(p => p.PasswordHash).HasMaxLength(500);

                u.Property(p => p.PasswordSalt).HasColumnName("PasswordSalt").IsRequired();
                u.Property(p => p.PasswordSalt).HasMaxLength(500);

                u.Property(p => p.Status).HasColumnName("Status").IsRequired();
            });

            modelBuilder.Entity<UserOperationClaim>(o =>
            {
                o.ToTable("UserOperationClaims").HasKey(k => k.Id);
                o.Property(p => p.Id).HasColumnName("Id");

                o.Property(p => p.UserId).HasColumnName("UserId").IsRequired();
                o.HasOne(p => p.Customer).WithMany(p => p.UserOperationClaims).HasForeignKey(p => p.OperationClaimId);
            });

            modelBuilder.Entity<Variant>(v =>
            {
                v.ToTable("Variants").HasKey(k => k.Id);
                v.Property(p => p.Id).HasColumnName("Id");

                v.Property(p => p.VariantName).HasColumnName("VariantName").IsRequired();
                v.Property(p => p.VariantName).HasMaxLength(30);
            });

            modelBuilder.Entity<VariantValue>(v =>
            {
                v.ToTable("FeatureValues").HasKey(k => k.Id);
                v.Property(p => p.Id).HasColumnName("Id");

                v.Property(p => p.VariantId).HasColumnName("VariantId").IsRequired();
                v.HasOne(p => p.Variant).WithMany(p => p.VariantValues).HasForeignKey(p => p.VariantId);

                v.Property(p => p.Value).HasColumnName("Value").IsRequired();
                v.Property(p => p.Value).HasMaxLength(40);
            });

            //Category[] categoryEntitySeeds = { new(1, "Kadın"), new(2, "Erkek") };
            //modelBuilder.Entity<Category>().HasData(categoryEntitySeeds);
        }
    }
}