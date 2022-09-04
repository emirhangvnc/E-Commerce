using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace projectLayer.Persistence.Services.Repositories
{
    public interface IUserRepository : IAsyncRepository<User>, IRepository<User>
    {

    }
}