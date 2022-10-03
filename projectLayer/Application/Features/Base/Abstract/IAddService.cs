using Core.Persistence.Repositories;
using Core.Security.Results;

namespace eCommerceLayer.Application.Features.Base.Abstract
{
    public interface IAddService<T> where T : IDTO
    {
        Task<IResult> Add(T addedDto);
    }
}