using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;
using eCommerceLayer.Application.Features.Services.Repositories;

namespace eCommerceLayer.Persistence.Repositories
{
    public class CustomerRepository : EfRepositoryBase<Customer, BaseDbContext>, ICustomerRepository
    {
        public CustomerRepository(BaseDbContext context) : base(context)
        {
        }
    }
}