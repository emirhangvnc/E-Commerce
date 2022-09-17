using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Persistence.Services.Repositories
{
    public interface IProductBrandRepository : IAsyncRepository<ProductBrand>, IRepository<ProductBrand>
    {

    }
}