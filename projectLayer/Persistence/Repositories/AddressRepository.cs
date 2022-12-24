using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;

namespace eCommerceLayer.Persistence.Repositories
{
    public class AddressRepository : EfRepositoryBase<Address, BaseDbContext>, IAddressRepository
    {
        public AddressRepository(BaseDbContext context) : base(context)
        {
        }
    }
}