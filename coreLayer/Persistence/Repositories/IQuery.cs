
namespace coreLayer.Permanency.Repositories
{
    public interface IQuery<T>
    {
        IQueryable<T> Query();
    }
}