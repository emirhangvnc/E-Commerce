using coreLayer.Permanency.Repositories;
using projectLayer.Persistence.Contexts;
using projectLayer.Persistence.Services.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Persistence.Repositories
{
    public class ProductBrandRepository : EfRepositoryBase<ProductBrand, BaseDbContext>, IProductBrandRepository
    {
        public ProductBrandRepository(BaseDbContext context) : base(context)
        {
        }
    }
}