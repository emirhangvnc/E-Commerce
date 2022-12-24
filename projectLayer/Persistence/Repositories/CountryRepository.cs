using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;

namespace eCommerceLayer.Persistence.Repositories
{
    public class CountryRepository : EfRepositoryBase<Country, BaseDbContext>, ICountryRepository
    {
        public CountryRepository(BaseDbContext context) : base(context)
        {
        }
    }
}