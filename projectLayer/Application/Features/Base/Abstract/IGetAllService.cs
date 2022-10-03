using Core.Application.Requests;
using Core.Persistence.Repositories;
using Core.Security.Results;

namespace eCommerceLayer.Application.Features.Base.Abstract
{
    public interface IGetAllService<T> where T : IEntity
    {
        Task<IDataResult<T>> GetAll(PageRequest request);
    }
}