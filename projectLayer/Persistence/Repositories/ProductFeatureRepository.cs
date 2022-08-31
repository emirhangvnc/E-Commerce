using Core.Persistence.Repositories;
using projectLayer.Persistence.Contexts;
using projectLayer.Persistence.Services.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Persistence.Repositories
{
    public class ProductFeatureRepository : EfRepositoryBase<ProductFeature, BaseDbContext>, IProductFeatureRepository
    {
        public ProductFeatureRepository(BaseDbContext context) : base(context)
        {
        }
    }
}