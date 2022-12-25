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
        public DbSet<User> Users { get; set; }
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
            modelBuilder.Entity<Address>(a =>
            {
                a.ToTable("Addresses").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                
                a.Property(p => p.AddressTitle).HasColumnName("AddressTitle").IsRequired();

                a.Property(p => p.FirstName).HasColumnName("FirstName").IsRequired();
                a.Property(p => p.FirstName).HasMaxLength(30);

                a.Property(p => p.LastName).HasColumnName("LastName").IsRequired();
                a.Property(p => p.LastName).HasMaxLength(30);

                a.Property(p => p.Email).HasColumnName("Email").IsRequired();
                a.Property(p => p.Email).HasMaxLength(40);

                a.Property(p => p.PhoneNumber).HasColumnName("PhoneNumber").IsRequired();
                a.Property(p => p.PhoneNumber).HasMaxLength(20);

                a.Property(p => p.DistrictId).HasColumnName("DistrictId").IsRequired();
                a.HasOne(p => p.District).WithMany(p => p.Addresses).HasForeignKey(p => p.DistrictId);

                a.Property(p => p.AddressLine).HasColumnName("AddressLine").IsRequired();
                a.Property(p => p.AddressLine).HasMaxLength(120);

                a.Property(p => p.ZipCode).HasColumnName("ZipCode");
                a.Property(p => p.ZipCode).HasMaxLength(10);

                a.Property(p => p.Status).HasColumnName("Status");
                a.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                a.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            modelBuilder.Entity<Brand>(b =>
            {
                b.ToTable("Brands").HasKey(k => k.Id);
                b.Property(p => p.Id).HasColumnName("Id");

                b.Property(p => p.BrandName).HasColumnName("BrandName");
                b.Property(p => p.BrandName).IsRequired();
                b.Property(p => p.BrandName).HasMaxLength(30);

                b.Property(p => p.Status).HasColumnName("Status");
                b.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                b.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            }); //Crud

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

                b.Property(p => p.Status).HasColumnName("Status");
                b.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                b.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            modelBuilder.Entity<Category>(c =>
            {
                c.ToTable("Categories").HasKey(k => k.Id);
                c.Property(p => p.Id).HasColumnName("Id");

                c.Property(p => p.CategoryName).HasColumnName("CategoryName").IsRequired();
                c.Property(p => p.CategoryName).HasMaxLength(30);

                c.Property(p => p.Status).HasColumnName("Status");
                c.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                c.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            }); //Crud

            modelBuilder.Entity<City>(c =>
            {
                c.ToTable("Cities").HasKey(k => k.Id);
                c.Property(p => p.Id).HasColumnName("Id");

                c.Property(p => p.CityName).HasColumnName("CityName").IsRequired();
                c.Property(p => p.CityName).HasMaxLength(30);

                c.Property(p => p.CountryId).HasColumnName("CountryId").IsRequired();
                c.HasOne(p => p.Country).WithMany(p => p.Cities).HasForeignKey(p => p.CountryId);

                c.Property(p => p.CityCode).HasColumnName("CityCode");
                c.Property(p => p.CityCode).HasMaxLength(30);

                c.Property(p => p.Status).HasColumnName("Status");
                c.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                c.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            }); //Crud

            modelBuilder.Entity<Country>(c =>
            {
                c.ToTable("Countries").HasKey(k => k.Id);
                c.Property(p => p.Id).HasColumnName("Id");

                c.Property(p => p.CountryName).HasColumnName("CountryName").IsRequired();
                c.Property(p => p.CountryName).HasMaxLength(60);

                c.Property(p => p.Alpha2Code).HasColumnName("Alpha2Code");
                c.Property(p => p.Alpha2Code).HasMaxLength(2);

                c.Property(p => p.Alpha3Code).HasColumnName("Alpha3Code");
                c.Property(p => p.Alpha3Code).HasMaxLength(3);

                c.Property(p => p.NumericCode).HasColumnName("NumericCode");

                c.Property(p => p.Status).HasColumnName("Status");
                c.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                c.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            }); //Crud

            modelBuilder.Entity<District>(c =>
            {
                c.ToTable("Districts").HasKey(k => k.Id);
                c.Property(p => p.Id).HasColumnName("Id");

                c.Property(p => p.DistrictName).HasColumnName("DistrictName").IsRequired();
                c.Property(p => p.DistrictName).HasMaxLength(30);

                c.Property(p => p.CityId).HasColumnName("CityId").IsRequired();
                c.HasOne(p => p.City).WithMany(p => p.Districts).HasForeignKey(p => p.CityId);

                c.Property(p => p.Status).HasColumnName("Status");
                c.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                c.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            modelBuilder.Entity<Favorite>(f =>
            {
                f.ToTable("Favorites").HasKey(k => k.Id);
                f.Property(p => p.Id).HasColumnName("Id");

                f.Property(p => p.UserId).HasColumnName("UserId").IsRequired();
                f.HasOne(p => p.User).WithMany(p => p.Favorites).HasForeignKey(p => p.UserId);

                f.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
                f.HasOne(p => p.Product).WithMany(p => p.Favorites).HasForeignKey(p => p.ProductId);

                f.Property(p => p.Status).HasColumnName("Status");
                f.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                f.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            modelBuilder.Entity<Feature>(f =>
            {
                f.ToTable("Features").HasKey(k => k.Id);
                f.Property(p => p.Id).HasColumnName("Id");

                f.Property(p => p.FeatureName).HasColumnName("FeatureName").IsRequired();
                f.Property(p => p.FeatureName).HasMaxLength(30);

                f.Property(p => p.Status).HasColumnName("Status");
                f.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                f.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            }); //Crud

            modelBuilder.Entity<FeatureValue>(f =>
            {
                f.ToTable("FeatureValues").HasKey(k => k.Id);
                f.Property(p => p.Id).HasColumnName("Id");

                f.Property(p => p.FeatureId).HasColumnName("FeatureId").IsRequired();
                f.HasOne(p => p.Feature).WithMany(p => p.FeatureValues).HasForeignKey(p => p.FeatureId);

                f.Property(p => p.Value).HasColumnName("Value").IsRequired();
                f.Property(p => p.Value).HasMaxLength(40);

                f.Property(p => p.Status).HasColumnName("Status");
                f.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                f.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            modelBuilder.Entity<OperationClaim>(o =>
            {
                o.ToTable("OperationClaims").HasKey(k => k.Id);
                o.Property(p => p.Id).HasColumnName("Id");

                o.Property(p => p.Name).HasColumnName("Name").IsRequired();
                o.Property(p => p.Name).HasMaxLength(30);
            });

            modelBuilder.Entity<Order>(o =>
            {
                o.ToTable("Orders").HasKey(k => k.Id);
                o.Property(p => p.Id).HasColumnName("Id");

                o.Property(p => p.UserId).HasColumnName("UserId").IsRequired();
                o.HasOne(p => p.User).WithMany(p => p.Orders).HasForeignKey(p => p.UserId);

                o.Property(p => p.AddressId).HasColumnName("AddressId").IsRequired();
                o.HasOne(p => p.Address).WithMany(p => p.Orders).HasForeignKey(p => p.AddressId);
                
                o.Property(p => p.TotalPrice).HasColumnName("TotalPrice").IsRequired();
                o.Property(p => p.TotalItem).HasColumnName("TotalItem").IsRequired();

                o.Property(p => p.Status).HasColumnName("Status");
                o.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                o.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            modelBuilder.Entity<OrderItem>(o =>
            {
                o.ToTable("OrderItems").HasKey(k => k.Id);
                o.Property(p => p.Id).HasColumnName("Id");

                o.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
                o.HasOne(p => p.Product).WithMany(p => p.OrderItems).HasForeignKey(p => p.ProductId);

                o.Property(p => p.OrderId).HasColumnName("OrderId");
                o.HasOne(p => p.Order).WithMany(p => p.OrderItems).HasForeignKey(p => p.OrderId);

                o.Property(p => p.UnitPrice).HasColumnName("UnitPrice").IsRequired();
                o.Property(p => p.Quantity).HasColumnName("Quantity").IsRequired();

                o.Property(p => p.Status).HasColumnName("Status");
                o.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                o.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            modelBuilder.Entity<Product>(p =>
            {
                p.ToTable("Products").HasKey(k => k.Id);
                p.Property(p => p.Id).HasColumnName("Id");

                p.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();

                p.Property(p => p.ModelCode).HasColumnName("ModelCode");
                p.Property(p => p.ModelCode).HasMaxLength(50);

                p.Property(p => p.Sku).HasColumnName("Sku");
                p.Property(p => p.Sku).HasMaxLength(50);

                p.Property(p => p.Gtin).HasColumnName("Gtin");
                p.Property(p => p.Gtin).HasMaxLength(50);

                p.Property(p => p.ProductName).HasColumnName("ProductName");
                p.Property(p => p.ProductName).HasMaxLength(50);

                p.Property(p => p.ShortDescription).HasColumnName("ShortDescription");
                p.Property(p => p.ShortDescription).HasMaxLength(80);

                p.Property(p => p.FullDescription).HasColumnName("FullDescription");
                p.Property(p => p.Weight).HasColumnName("Weight");

                p.Property(p => p.Status).HasColumnName("Status");
                p.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
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

                p.Property(p => p.Status).HasColumnName("Status");
                p.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                p.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            modelBuilder.Entity<ProductCategory>(p =>
            {
                p.ToTable("ProductCategories").HasKey(k => k.Id);
                p.Property(p => p.Id).HasColumnName("Id");

                p.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
                p.HasOne(p => p.Product).WithMany(p => p.ProductCategories).HasForeignKey(p => p.ProductId);

                p.Property(p => p.CategoryId).HasColumnName("CategoryId").IsRequired();
                p.HasOne(p => p.Category).WithMany(p => p.ProductCategories).HasForeignKey(p => p.CategoryId);

                p.Property(p => p.Status).HasColumnName("Status");
                p.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                p.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            modelBuilder.Entity<ProductFeature>(p =>
            {
                p.ToTable("ProductFeatures").HasKey(k => k.Id);
                p.Property(p => p.Id).HasColumnName("Id");

                p.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
                p.HasOne(p => p.Product).WithMany(p => p.ProductFeatures).HasForeignKey(p => p.ProductId);

                p.Property(p => p.FeatureValueId).HasColumnName("FeatureValueId").IsRequired();
                p.HasOne(p => p.FeatureValue).WithMany(p => p.ProductFeatures).HasForeignKey(p => p.FeatureValueId);

                p.Property(p => p.Status).HasColumnName("Status");
                p.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                p.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            modelBuilder.Entity<ProductPrice>(p =>
            {
                p.ToTable("ProductPrices").HasKey(k => k.Id);
                p.Property(p => p.Id).HasColumnName("Id");

                p.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
                p.HasOne(p => p.Product).WithMany(p => p.ProductPrices).HasForeignKey(p => p.ProductId);

                p.Property(p => p.ProductCost).HasColumnName("ProductCost");
                p.Property(p => p.Price).HasColumnName("Price");
                p.Property(p => p.OldPrice).HasColumnName("OldPrice");
                p.Property(p => p.Price1).HasColumnName("Price1");
                p.Property(p => p.Price2).HasColumnName("Price2");
                p.Property(p => p.Price3).HasColumnName("Price3");
                p.Property(p => p.Price4).HasColumnName("Price4");
                p.Property(p => p.Price5).HasColumnName("Price5");
                p.Property(p => p.Tax).HasColumnName("Tax");

                p.Property(p => p.Status).HasColumnName("Status");
                p.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                p.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            modelBuilder.Entity<ProductVariant>(p =>
            {
                p.ToTable("ProductVariants").HasKey(k => k.Id);
                p.Property(p => p.Id).HasColumnName("Id");

                p.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
                p.HasOne(p => p.Product).WithMany(p => p.ProductVariants).HasForeignKey(p => p.ProductId);

                p.Property(p => p.VariantValueId).HasColumnName("VariantValueId").IsRequired();
                p.HasOne(p => p.VariantValue).WithMany(p => p.ProductVariants).HasForeignKey(p => p.VariantValueId);

                p.Property(p => p.VariantSku).HasColumnName("VariantSku").IsRequired();
                p.Property(p => p.VariantGtin).HasColumnName("VariantGtin").IsRequired();
                p.Property(p => p.VariantPrice).HasColumnName("VariantPrice").IsRequired();

                p.Property(p => p.Status).HasColumnName("Status");
                p.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                p.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
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

                p.Property(p => p.Status).HasColumnName("Status");
                p.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                p.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            modelBuilder.Entity<ProductStock>(p =>
            {
                p.ToTable("ProductStocks").HasKey(k => k.Id);
                p.Property(p => p.Id).HasColumnName("Id");

                p.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
                p.HasOne(p => p.Product).WithMany(p => p.ProductStocks).HasForeignKey(p => p.ProductId);

                p.Property(p => p.UnitStock).HasColumnName("UnitStock").IsRequired();
                p.Property(p => p.Description).HasColumnName("Description");

                p.Property(p => p.Status).HasColumnName("Status");
                p.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                p.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            modelBuilder.Entity<User>(u =>
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

                u.Property(p => p.Status).HasColumnName("Status");
                u.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                u.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            modelBuilder.Entity<UserOperationClaim>(o =>
            {
                o.ToTable("UserOperationClaims").HasKey(k => k.Id);
                o.Property(p => p.Id).HasColumnName("Id");

                o.Property(p => p.UserId).HasColumnName("UserId").IsRequired();
                o.HasOne(p => p.User).WithMany(p => p.UserOperationClaims).HasForeignKey(p => p.OperationClaimId);
            });

            modelBuilder.Entity<Variant>(v =>
            {
                v.ToTable("Variants").HasKey(k => k.Id);
                v.Property(p => p.Id).HasColumnName("Id");

                v.Property(p => p.VariantName).HasColumnName("VariantName").IsRequired();
                v.Property(p => p.VariantName).HasMaxLength(30);

                v.Property(p => p.Status).HasColumnName("Status");
                v.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                v.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            modelBuilder.Entity<VariantValue>(v =>
            {
                v.ToTable("FeatureValues").HasKey(k => k.Id);
                v.Property(p => p.Id).HasColumnName("Id");

                v.Property(p => p.VariantId).HasColumnName("VariantId").IsRequired();
                v.HasOne(p => p.Variant).WithMany(p => p.VariantValues).HasForeignKey(p => p.VariantId);

                v.Property(p => p.Value).HasColumnName("Value").IsRequired();
                v.Property(p => p.Value).HasMaxLength(40);

                v.Property(p => p.Status).HasColumnName("Status");
                v.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
                v.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
            });

            //Category[] categoryEntitySeeds = { new(1, "Kadın"), new(2, "Erkek") };
            //modelBuilder.Entity<Category>().HasData(categoryEntitySeeds);
        }
    }
}