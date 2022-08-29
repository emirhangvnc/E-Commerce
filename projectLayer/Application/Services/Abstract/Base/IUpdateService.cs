using coreLayer.Permanency.Repositories;
using coreLayer.Utilities.Results;

namespace projectLayer.Application.Services.Abstract.Base
{
    public interface IUpdateService<T> where T : IDTO
    {
        Task<IResult> Update(T updatedDto);
    }
}