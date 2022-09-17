using Core.Persistence.Repositories;
using eCommerceLayer.Persistence.Contexts;
using eCommerceLayer.Persistence.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Persistence.Repositories
{
    public class FeatureRepository : EfRepositoryBase<Feature, BaseDbContext>, IFeatureRepository
    {
        public FeatureRepository(BaseDbContext context) : base(context)
        {
        }
    }
}