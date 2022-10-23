using Core.Persistence.Repositories;
using Core.Utilities.Results;

namespace eCommerceLayer.Application.Features.Base.Abstract.Commands
{
    public interface IAddService<T> where T : IDTO
    {
        Task<IResult> Add(T addedDto);
    }
}