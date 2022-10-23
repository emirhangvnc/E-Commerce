using Core.Application.Requests;
using Core.Persistence.Repositories;
using Core.Utilities.Results;

namespace eCommerceLayer.Application.Features.Base.Abstract.Queries
{
    public interface IGetAllService<T> where T : IEntity
    {
        Task<IDataResult<T>> GetAll(PageRequest request);
    }
}