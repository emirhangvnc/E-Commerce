using Core.Persistence.Repositories;
using Core.Utilities.Results;

namespace projectLayer.Application.Services.Abstract.Base
{
    public interface IGetService<T> where T : Entity
    {
        Task<IDataResult<List<T>>> GetAll();
        Task<IDataResult<T>> GetById(int id);
    }
}