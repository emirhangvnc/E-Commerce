using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Services.Abstract.Base
{
    public interface IBaseService<TEntity, TAddDTO, TDeleteDTO, TUpdateDTO> :
        IGetService<TEntity>, IAddService<TAddDTO>, IDeleteService<TDeleteDTO>, IUpdateService<TUpdateDTO>
        where TEntity : IEntity
        where TAddDTO : IDTO
        where TDeleteDTO : IDTO
        where TUpdateDTO : IDTO
    {
    }
}