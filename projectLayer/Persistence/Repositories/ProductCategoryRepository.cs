using Core.Persistence.Repositories;
using eCommerceLayer.Persistence.Concrete.Contexts;
using eCommerceLayer.Persistence.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Persistence.Repositories
{
    public class ProductCategoryRepository : EfRepositoryBase<ProductCategory, BaseDbContext>, IProductCategoryRepository
    {
        public ProductCategoryRepository(BaseDbContext context) : base(context)
        {
        }
    }
}