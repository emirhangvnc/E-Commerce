using Core.Persistence.Repositories;
using projectLayer.Persistence.Contexts;
using projectLayer.Persistence.Services.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Persistence.Repositories
{
    public class ProductImageRepository : EfRepositoryBase<ProductImage, BaseDbContext>, IProductImageRepository
    {
        public ProductImageRepository(BaseDbContext context) : base(context)
        {
        }
    }
}