using Core.Persistence.Repositories;
using eCommerceLayer.Persistence.Contexts;
using eCommerceLayer.Persistence.Services.Repositories;
using Core.Security.Entities;

namespace eCommerceLayer.Persistence.Repositories
{
    public class UserRepository : EfRepositoryBase<User, BaseDbContext>, IUserRepository
    {
        public UserRepository(BaseDbContext context) : base(context)
        {
        }
    }
}