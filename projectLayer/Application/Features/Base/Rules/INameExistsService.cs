using Core.Persistence.Repositories;
using Core.Security.Results;

namespace eCommerceLayer.Application.Features.Base.Rules
{
    public interface INameExistsService<T> where T : IEntity
    {
        Task<IDataResult<T>> NameExists(string name);
    }
}