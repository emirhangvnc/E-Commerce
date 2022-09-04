using Core.Persistence.Repositories;
using Core.Security.Results;

namespace projectLayer.Application.Services.Abstract.Base
{
    public interface IAddService<T> where T : IDTO
    {
        Task<IResult> Add(T addedDto);
    }
}