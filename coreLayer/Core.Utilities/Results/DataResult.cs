using Core.Persistence.Paging;
using Core.Persistence.Repositories;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }
        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }
        public DataResult(bool success, string message, IQueryable queryable) : base(success, message)
        {
            Queryable = queryable;
        }
        public DataResult(bool success, IQueryable queryable) : base(success)
        {
            Queryable = queryable;
        }
        public DataResult(bool success, string message, IPaginate<T> paginate) : base(success, message)
        {
            Paginate = paginate;
        }
        public DataResult(bool success, IPaginate<T> paginate) : base(success)
        {
            Paginate = paginate;
        }
        public DataResult(bool success, string message, IDTO dto) : base(success, message)
        {
            DTO = dto;
        }
        public DataResult(bool success, IDTO dto) : base(success)
        {
            DTO = dto;
        }
        public DataResult(bool success, string message, IModel model) : base(success, message)
        {
            Model = model;
        }
        public DataResult(bool success, IModel model) : base(success)
        {
            Model = model;
        }

        public T Data { get; }
        public IQueryable Queryable { get; }
        public IPaginate<T> Paginate { get; }
        public IDTO DTO { get; }
        public IModel Model { get; }
    }
}