using Core.Persistence.Repositories;
using eCommerceLayer.Persistence.Concrete.Contexts;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Services.Repositories;

namespace eCommerceLayer.Persistence.Repositories
{
    public class ProductVariantRepository : EfRepositoryBase<ProductVariant, BaseDbContext>, IProductVariantRepository
    {
        public ProductVariantRepository(BaseDbContext context) : base(context)
        {
        }
    }
}