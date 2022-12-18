using Core.Persistence.Repositories;
using eCommerceLayer.Persistence.Concrete.Contexts;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Persistence.Repositories
{
    public class ProductBrandRepository : EfRepositoryBase<ProductBrand, BaseDbContext>, IProductBrandRepository
    {
        public ProductBrandRepository(BaseDbContext context) : base(context)
        {
        }
    }
}