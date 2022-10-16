using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;
using eCommerceLayer.Persistence.Services.Repositories;

namespace eCommerceLayer.Persistence.Repositories
{
    public class ProductPriceRepository : EfRepositoryBase<ProductPrice, BaseDbContext>, IProductPriceRepository
    {
        public ProductPriceRepository(BaseDbContext context) : base(context)
        {
        }
    }
}