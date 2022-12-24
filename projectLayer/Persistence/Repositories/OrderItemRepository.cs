using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;

namespace eCommerceLayer.Persistence.Repositories
{
    public class OrderItemRepository : EfRepositoryBase<OrderItem, BaseDbContext>, IOrderItemRepository
    {
        public OrderItemRepository(BaseDbContext context) : base(context)
        {
        }
    }
}