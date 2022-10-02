using Core.Persistence.Repositories;
using Core.Security.Results;

namespace eCommerceLayer.Application.Services.Abstract.Base
{
    public interface IGetService<T> where T : IEntity
    {
        Task<IDataResult<List<T>>> GetAll();
        Task<IDataResult<T>> GetById(int id);
    }
}