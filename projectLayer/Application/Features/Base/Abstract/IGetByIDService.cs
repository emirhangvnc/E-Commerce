using Core.Persistence.Repositories;
using Core.Security.Results;

namespace eCommerceLayer.Application.Features.Base.Abstract
{
    public interface IGetByIDService<TEntity>
        where TEntity : IEntity
        //where TDTO : IDTO
    {
        Task<IDataResult<TEntity>> GetById(TEntity getAll);
    }
}