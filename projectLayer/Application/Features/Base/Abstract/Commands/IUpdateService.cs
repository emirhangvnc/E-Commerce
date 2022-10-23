using Core.Persistence.Repositories;
using Core.Utilities.Results;

namespace eCommerceLayer.Application.Features.Base.Abstract.Commands
{
    public interface IUpdateService<T> where T : IDTO
    {
        Task<IResult> Update(T updatedDto);
    }
}