using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Persistence.Services.Repositories
{
    public interface IFavoriteRepository : IAsyncRepository<Favorite>, IRepository<Favorite>
    {
    }
}