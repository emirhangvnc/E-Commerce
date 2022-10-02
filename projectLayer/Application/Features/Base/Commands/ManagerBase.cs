using AutoMapper;
using eCommerceLayer.Persistence.Concrete.Contexts;

namespace eCommerceLayer.Application.Features.Base.Commands
{
    public class ManagerBase
    {
        public BaseDbContext DbContext { get; }
        public IMapper Mapper { get; }

        public ManagerBase(IMapper mapper, BaseDbContext context)
        {
            Mapper = mapper;
            DbContext = context;
        }
    }
}