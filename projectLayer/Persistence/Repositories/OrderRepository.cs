using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;

namespace eCommerceLayer.Persistence.Repositories
{
    public class OrderRepository : EfRepositoryBase<Order, BaseDbContext>, IOrderRepository
    {
        public OrderRepository(BaseDbContext context) : base(context)
        {
        }
    }
}