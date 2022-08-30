using coreLayer.Permanency.Repositories;
using projectLayer.Persistence.Contexts;
using projectLayer.Persistence.Services.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Persistence.Repositories
{
    public class FeatureRepository : EfRepositoryBase<Feature, BaseDbContext>, IFeatureRepository
    {
        public FeatureRepository(BaseDbContext context) : base(context)
        {
        }
    }
}