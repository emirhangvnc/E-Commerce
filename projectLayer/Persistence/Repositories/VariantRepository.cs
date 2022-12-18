using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;

namespace eCommerceLayer.Persistence.Repositories
{
    public class VariantRepository : EfRepositoryBase<Variant, BaseDbContext>, IVariantRepository
    {
        public VariantRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
