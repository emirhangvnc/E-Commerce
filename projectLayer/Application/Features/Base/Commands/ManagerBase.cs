using AutoMapper;

namespace eCommerceLayer.Application.Features.Base.Commands
{
    public class ManagerBase
    {
        public IMapper Mapper { get; }

        public ManagerBase(IMapper mapper)
        {
            Mapper = mapper;
        }
    }
}