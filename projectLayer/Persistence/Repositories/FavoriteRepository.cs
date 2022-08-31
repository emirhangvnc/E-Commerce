using Core.Persistence.Repositories;
using projectLayer.Persistence.Contexts;
using projectLayer.Persistence.Services.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Persistence.Repositories
{
    public class FavoriteRepository : EfRepositoryBase<Favorite, BaseDbContext>, IFavoriteRepository
    {
        public FavoriteRepository(BaseDbContext context) : base(context)
        {
        }
    }
}