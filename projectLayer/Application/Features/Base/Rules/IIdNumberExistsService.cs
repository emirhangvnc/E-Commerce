using Core.Persistence.Repositories;
using Core.Utilities.Results;

namespace eCommerceLayer.Application.Features.Base.Rules
{
    public interface IIdNumberExistsService<T> where T : IEntity
    {
        Task<IDataResult<T>> IsIDExists(int id);
    }
}