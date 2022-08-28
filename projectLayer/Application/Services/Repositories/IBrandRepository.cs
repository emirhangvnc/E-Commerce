using coreLayer.Persistence.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Application.Services.Repositories
{
    public interface IBrandRepository : IAsyncRepository<Brand>, IRepository<Brand>
    {

    }
}