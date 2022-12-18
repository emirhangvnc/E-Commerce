using Core.Persistence.Repositories;
using eCommerceLayer.Persistence.Concrete.Contexts;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Persistence.Repositories
{
    public class ProductStockRepository : EfRepositoryBase<ProductStock, BaseDbContext>, IProductStockRepository
    {
        public ProductStockRepository(BaseDbContext context) : base(context)
        {
        }
    }
}