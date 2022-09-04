namespace Core.Security.Results
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; } 
    }
}