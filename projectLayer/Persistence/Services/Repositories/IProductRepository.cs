using Core.Persistence.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Persistence.Services.Repositories
{
    public interface IProductRepository : IAsyncRepository<Product>, IRepository<Product>
    {
    }
}