using Core.Persistence.Repositories;
using eCommerceLayer.Persistence.Contexts;
using eCommerceLayer.Persistence.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Persistence.Repositories
{
    public class ProductFeatureRepository : EfRepositoryBase<ProductFeature, BaseDbContext>, IProductFeatureRepository
    {
        public ProductFeatureRepository(BaseDbContext context) : base(context)
        {
        }
    }
}