using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Persistence.Services.Repositories
{
    public interface IProductStockRepository : IAsyncRepository<ProductStock>, IRepository<ProductStock>
    {
    }
}