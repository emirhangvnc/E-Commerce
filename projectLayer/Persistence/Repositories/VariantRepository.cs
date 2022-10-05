using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;
using eCommerceLayer.Persistence.Services.Repositories;

namespace eCommerceLayer.Persistence.Repositories
{
    public class VariantRepository : EfRepositoryBase<Variant, BaseDbContext>, IVariantRepository
    {
        public VariantRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
