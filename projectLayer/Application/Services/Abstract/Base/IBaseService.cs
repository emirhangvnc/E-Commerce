using coreLayer.Persistence.Repositories;

namespace projectLayer.Application.Services.Abstract.Base
{
    public interface IBaseService<TEntity, TAddDTO, TDeleteDTO, TUpdateDTO> :
        IGetService<TEntity>, IAddService<TAddDTO>, IDeleteService<TDeleteDTO>, IUpdateService<TUpdateDTO>
        where TEntity : Entity
        where TAddDTO : IDTO
        where TDeleteDTO : IDTO
        where TUpdateDTO : IDTO
    {
    }
}