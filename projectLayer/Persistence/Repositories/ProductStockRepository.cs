using coreLayer.Permanency.Repositories;
using projectLayer.Persistence.Contexts;
using projectLayer.Persistence.Services.Repositories;
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