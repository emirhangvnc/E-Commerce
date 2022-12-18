using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Services.Repositories
{
    public interface IProductStockRepository : IAsyncRepository<ProductStock>, IRepository<ProductStock>
    {
    }
}