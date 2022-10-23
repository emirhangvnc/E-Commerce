using Core.Persistence.Repositories;
using Core.Utilities.Results;

namespace eCommerceLayer.Application.Features.Base.Abstract.Queries
{
    public interface IGetByIDService<E, D>
        where E : IEntity, new()
        where D : IDTO, new()
    {
        Task<IDataResult<E>> GetById(D getById);
    }
}