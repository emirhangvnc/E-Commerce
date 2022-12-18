using Core.Persistence.Paging;
using Core.Persistence.Repositories;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
        IQueryable Queryable { get; }
        IPaginate<T> Paginate { get; }
        IDTO DTO { get; }
        IModel Model { get; }
    }
}