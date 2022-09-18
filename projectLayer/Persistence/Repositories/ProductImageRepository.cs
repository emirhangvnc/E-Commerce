using Core.Persistence.Repositories;
using eCommerceLayer.Persistence.Concrete.Contexts;
using eCommerceLayer.Persistence.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Persistence.Repositories
{
    public class ProductImageRepository : EfRepositoryBase<ProductImage, BaseDbContext>, IProductImageRepository
    {
        public ProductImageRepository(BaseDbContext context) : base(context)
        {
        }
    }
}