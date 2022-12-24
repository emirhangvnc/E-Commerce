using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;

namespace eCommerceLayer.Persistence.Repositories
{
    public class DistrictRepository : EfRepositoryBase<District, BaseDbContext>, IDistrictRepository
    {
        public DistrictRepository(BaseDbContext context) : base(context)
        {
        }
    }
}