using Core.Persistence.Repositories;
using Core.Security.Results;

namespace projectLayer.Application.Services.Abstract.Base
{
    public interface IUpdateService<T> where T : IDTO
    {
         Task<IResult> Update(T updatedDto);
    }
}