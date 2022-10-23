using Core.Persistence.Repositories;
using Core.Utilities.Results;

namespace eCommerceLayer.Application.Features.Base.Abstract.Commands
{
    public interface IDeleteService<T> where T : IDTO
    {
        Task<IResult> Delete(T deletedDto);
    }
}