using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Services.Repositories
{
    public interface IProductImageRepository : IAsyncRepository<ProductImage>, IRepository<ProductImage>
    {
    }
}