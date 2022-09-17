using Core.Persistence.Repositories;
using Core.Security.Results;

namespace eCommerceLayer.Application.Services.Abstract.Base
{
    public interface IDeleteService<T> where T : IDTO
    {
        Task<IResult> Delete(T deletedDto);
    }
}