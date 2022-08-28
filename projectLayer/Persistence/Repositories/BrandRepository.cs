using coreLayer.Persistence.Repositories;
using projectLayer.Persistence.Contexts;
using projectLayer.Application.Services.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Persistence.Repositories
{
    public class BrandRepository : EfRepositoryBase<Brand, BaseDbContext>, IBrandRepository
    {
        public BrandRepository(BaseDbContext context) : base(context)
        {
        }
    }
}