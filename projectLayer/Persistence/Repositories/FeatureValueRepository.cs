using Core.Persistence.Repositories;
using eCommerceLayer.Persistence.Concrete.Contexts;
using eCommerceLayer.Persistence.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Persistence.Repositories
{
    public class FeatureValueRepository : EfRepositoryBase<FeatureValue, BaseDbContext>, IFeatureValueRepository
    {
        public FeatureValueRepository(BaseDbContext context) : base(context)
        {
        }
    }
}