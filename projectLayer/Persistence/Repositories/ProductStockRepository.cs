using coreLayer.Persistence.Repositories;
using projectLayer.Persistence.Contexts;
using projectLayer.Application.Services.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Persistence.Repositories
{
    public class ProductStockRepository : EfRepositoryBase<ProductStock, BaseDbContext>, IProductStockRepository
    {
        public ProductStockRepository(BaseDbContext context) : base(context)
        {
        }
    }
}