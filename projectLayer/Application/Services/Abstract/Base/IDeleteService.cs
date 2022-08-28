using coreLayer.Persistence.Repositories;
using coreLayer.Utilities.Results;

namespace projectLayer.Application.Services.Abstract.Base
{
    public interface IDeleteService<T> where T : IDTO
    {
        Task<IResult> Delete(T deletedDto);
    }
}