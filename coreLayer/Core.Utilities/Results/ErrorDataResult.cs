using Core.Persistence.Paging;
using Core.Persistence.Repositories;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        public ErrorDataResult() : base(default, false)
        {

        }
        public ErrorDataResult(IQueryable queryable) : base(false, queryable)
        {

        }
        public ErrorDataResult(IQueryable queryable, string message) : base(false, message, queryable)
        {

        }
        public ErrorDataResult(IPaginate<T> paginate) : base(false, paginate)
        {

        }
        public ErrorDataResult(IPaginate<T> paginate, string message) : base(false, message, paginate)
        {

        }
        public ErrorDataResult(IDTO dto) : base(false, dto)
        {

        }
        public ErrorDataResult(IDTO dto, string message) : base(false, message, dto)
        {

        }
        public ErrorDataResult(IModel model) : base(false, model)
        {

        }
        public ErrorDataResult(IModel model, string message) : base(false, message, model)
        {

        }
    }
}