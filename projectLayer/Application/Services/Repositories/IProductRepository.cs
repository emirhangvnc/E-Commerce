using coreLayer.Persistence.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Application.Services.Repositories
{
    public interface IProductRepository : IAsyncRepository<Product>, IRepository<Product>
    {
    }
}