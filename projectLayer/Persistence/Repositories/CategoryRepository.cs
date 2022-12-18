using Core.Persistence.Repositories;
using eCommerceLayer.Persistence.Concrete.Contexts;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Persistence.Repositories
{
    public class CategoryRepository : EfRepositoryBase<Category, BaseDbContext>, ICategoryRepository
    {
        public CategoryRepository(BaseDbContext context) : base(context)
        {
        }
    }
}