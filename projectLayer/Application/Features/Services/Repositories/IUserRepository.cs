using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Services.Repositories
{
    public interface IUserRepository : IAsyncRepository<User>, IRepository<User>
    {
    }
}