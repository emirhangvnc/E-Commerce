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
        public DataResult(bool success, string message, IModel model) : base(success, message)
        {
            Model = model;
        }
        public DataResult(bool success, IModel model) : base(success)
        {
            Model = model;
        }

        public T Data { get; }
        public IModel Model { get; }
    }
}