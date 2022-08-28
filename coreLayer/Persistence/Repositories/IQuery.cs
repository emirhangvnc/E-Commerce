
namespace coreLayer.Persistence.Repositories
{
    public interface IQuery<T>
    {
        IQueryable<T> Query();
    }
}