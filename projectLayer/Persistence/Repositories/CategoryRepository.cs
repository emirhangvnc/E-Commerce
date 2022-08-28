using coreLayer.Persistence.Repositories;
using projectLayer.Persistence.Contexts;
using projectLayer.Application.Services.Repositories;
using projectLayer.Domain.Entities;

namespace projectLayer.Persistence.Repositories
{
    public class CategoryRepository : EfRepositoryBase<Category, BaseDbContext>, ICategoryRepository
    {
        public CategoryRepository(BaseDbContext context) : base(context)
        {
        }
    }
}