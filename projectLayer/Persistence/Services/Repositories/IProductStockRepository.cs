using coreLayer.Permanency.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Application.Services.Repositories
{
    public interface IProductStockRepository : IAsyncRepository<ProductStock>, IRepository<ProductStock>
    {

    }
}