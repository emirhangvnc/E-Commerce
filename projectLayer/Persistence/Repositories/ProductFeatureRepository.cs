using Core.Persistence.Repositories;
using eCommerceLayer.Persistence.Concrete.Contexts;
using eCommerceLayer.Application.Features.Services.Repositories;
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