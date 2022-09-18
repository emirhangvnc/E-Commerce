using Core.Persistence.Repositories;
using eCommerceLayer.Persistence.Concrete.Contexts;
using eCommerceLayer.Persistence.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Persistence.Repositories
{
    public class FavoriteRepository : EfRepositoryBase<Favorite, BaseDbContext>, IFavoriteRepository
    {
        public FavoriteRepository(BaseDbContext context) : base(context)
        {
        }
    }
}