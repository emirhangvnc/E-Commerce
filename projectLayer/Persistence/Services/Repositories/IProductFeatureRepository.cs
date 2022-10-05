using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Persistence.Services.Repositories
{
    public interface IProductFeatureRepository : IAsyncRepository<ProductFeature>, IRepository<ProductFeature>
    {
    }
}