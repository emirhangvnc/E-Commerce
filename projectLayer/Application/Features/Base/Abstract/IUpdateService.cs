using Core.Persistence.Repositories;
using Core.Security.Results;

namespace eCommerceLayer.Application.Features.Base.Abstract
{
    public interface IUpdateService<T> where T : IDTO
    {
        Task<IResult> Update(T updatedDto);
    }
}