using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Persistence.Services.Repositories
{
    public interface IVariantValueRepository : IAsyncRepository<VariantValue>, IRepository<VariantValue>
    {
    }
}