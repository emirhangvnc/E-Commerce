using Core.Persistence.Repositories;
using Core.Security.Results;

namespace eCommerceLayer.Application.Features.Base.Abstract
{
    public interface IGetByIDService<E,D>
        where E : IEntity,new()
        where D : IDTO, new()
    {
        Task<IDataResult<E>> GetById(D getById);
    }
}