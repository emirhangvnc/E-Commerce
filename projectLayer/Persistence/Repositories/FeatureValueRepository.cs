using Core.Persistence.Repositories;
using projectLayer.Persistence.Contexts;
using projectLayer.Persistence.Services.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Persistence.Repositories
{
    public class FeatureValueRepository : EfRepositoryBase<FeatureValue, BaseDbContext>, IFeatureValueRepository
    {
        public FeatureValueRepository(BaseDbContext context) : base(context)
        {
        }
    }
}