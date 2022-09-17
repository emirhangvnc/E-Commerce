using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace eCommerceLayer.Persistence.Services.Repositories
{
    public interface IUserRepository : IAsyncRepository<User>, IRepository<User>
    {

    }
}