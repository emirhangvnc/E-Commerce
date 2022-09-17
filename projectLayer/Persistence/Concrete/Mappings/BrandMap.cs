using eCommerceLayer.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace eCommerceLayer.Persistence.Concrete.Mappings
{
    public class BrandMap : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.Property(a => a.BrandName).IsRequired();
            builder.Property(a => a.BrandName).HasMaxLength(150);


            builder.ToTable("Brands");
        }
    }
}