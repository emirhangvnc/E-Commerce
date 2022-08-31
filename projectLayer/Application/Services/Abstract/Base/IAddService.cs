using Core.Persistence.Repositories;
using Core.Utilities.Results;

namespace projectLayer.Application.Services.Abstract.Base
{
    public interface IAddService<T> where T : IDTO
    {
        Task<IResult> Add(T addedDto);
    }
}