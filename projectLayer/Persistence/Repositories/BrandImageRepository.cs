using Core.Persistence.Repositories;
using eCommerceLayer.Persistence.Concrete.Contexts;
using eCommerceLayer.Persistence.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Persistence.Repositories
{
    public class BrandImageRepository : EfRepositoryBase<BrandImage, BaseDbContext>, IBrandImageRepository
    {
        public BrandImageRepository(BaseDbContext context) : base(context)
        {
        }
    }
}