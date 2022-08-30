using coreLayer.Permanency.Repositories;
using projectLayer.Persistence.Contexts;
using projectLayer.Persistence.Services.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Persistence.Repositories
{
    public class BrandImageRepository : EfRepositoryBase<BrandImage, BaseDbContext>, IBrandImageRepository
    {
        public BrandImageRepository(BaseDbContext context) : base(context)
        {
        }
    }
}