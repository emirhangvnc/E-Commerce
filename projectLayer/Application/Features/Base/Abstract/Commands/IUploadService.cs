using Core.Persistence.Repositories;
using Core.Utilities.Results;

namespace eCommerceLayer.Application.Features.Base.Abstract.Commands
{
    public interface IUploadService<T> where T : IDTO
    {
        Task<IResult> Upload(T uploadDTO);
    }
}