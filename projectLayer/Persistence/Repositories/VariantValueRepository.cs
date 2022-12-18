using Core.Persistence.Repositories;
using eCommerceLayer.Persistence.Concrete.Contexts;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Application.Features.Services.Repositories;

namespace eCommerceLayer.Persistence.Repositories
{
    public class VariantValueRepository : EfRepositoryBase<VariantValue, BaseDbContext>, IVariantValueRepository
    {
        public VariantValueRepository(BaseDbContext context) : base(context)
        {
        }
    }
}