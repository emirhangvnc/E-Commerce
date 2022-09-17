using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Persistence.Concrete.Mappings
{
    public class BrandImageMap : IEntityTypeConfiguration<BrandImage>
    {
        public void Configure(EntityTypeBuilder<BrandImage> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.Property(a => a.FileName).IsRequired();
            builder.Property(a => a.FilePath).IsRequired();
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.UpdatedDate).IsRequired();


            builder.ToTable("BrandPictures");
        }
    }
}