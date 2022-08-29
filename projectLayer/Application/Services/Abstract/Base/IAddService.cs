using coreLayer.Permanency.Repositories;
using coreLayer.Utilities.Results;

namespace projectLayer.Application.Services.Abstract.Base
{
    public interface IAddService<T> where T : IDTO
    {
        Task<IResult> Add(T addedDto);
    }
}