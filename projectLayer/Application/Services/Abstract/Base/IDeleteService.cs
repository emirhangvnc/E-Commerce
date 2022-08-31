using Core.Persistence.Repositories;
using Core.Utilities.Results;

namespace projectLayer.Application.Services.Abstract.Base
{
    public interface IDeleteService<T> where T : IDTO
    {
        Task<IResult> Delete(T deletedDto);
    }
}