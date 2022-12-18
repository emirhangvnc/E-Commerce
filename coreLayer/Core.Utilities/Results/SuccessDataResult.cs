using Core.Persistence.Paging;
using Core.Persistence.Repositories;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        public SuccessDataResult(string message) : base(default, true, message)
        {

        }
        public SuccessDataResult() : base(default, true)
        {

        }
        public SuccessDataResult(IQueryable queryable) : base(true, queryable)
        {

        }
        public SuccessDataResult(IQueryable queryable, string message) : base(true, message, queryable)
        {

        }
        public SuccessDataResult(IPaginate<T> paginate) : base(true, paginate)
        {

        }
        public SuccessDataResult(IPaginate<T> paginate, string message) : base(true, message, paginate)
        {

        }
        public SuccessDataResult(IDTO dto) : base(true, dto)
        {

        }
        public SuccessDataResult(IDTO dto, string message) : base(true, message, dto)
        {

        }
        public SuccessDataResult(IModel model) : base(true, model)
        {

        }
        public SuccessDataResult(IModel model, string message) : base(true, message, model)
        {

        }
    }
}