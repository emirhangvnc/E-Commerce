using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;

namespace eCommerceLayer.Persistence.Repositories
{
    public class CityRepository : EfRepositoryBase<City, BaseDbContext>, ICityRepository
    {
        public CityRepository(BaseDbContext context) : base(context)
        {
        }
    }
}