using coreLayer.Permanency.Repositories;
using projectLayer.Persistence.Contexts;
using projectLayer.Persistence.Services.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Persistence.Repositories
{
    public class ProductCategoryRepository : EfRepositoryBase<ProductCategory, BaseDbContext>, IProductCategoryRepository
    {
        public ProductCategoryRepository(BaseDbContext context) : base(context)
        {
        }
    }
}