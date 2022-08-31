using Core.Persistence.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Persistence.Services.Repositories
{
    public interface IProductStockRepository : IAsyncRepository<ProductStock>, IRepository<ProductStock>
    {

    }
}