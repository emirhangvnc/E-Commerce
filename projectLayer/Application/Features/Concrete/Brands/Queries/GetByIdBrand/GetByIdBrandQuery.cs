using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Brands.Rules;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Queries.GetByIdBrand
{
    public class GetByIdBrandQuery : IRequest<IDataResult<Brand>>
    {
        public int Id { get; set; }
        public class GetByIdVariantQueryHandler : IRequestHandler<GetByIdBrandQuery, IDataResult<Brand>>
        {
            private readonly IMapper _mapper;
            private readonly IBrandBusinessRules _brandBusinessRules;

            public GetByIdVariantQueryHandler(IMapper mapper, IBrandBusinessRules brandBusinessRules)
            {
                _mapper = mapper;
                _brandBusinessRules = brandBusinessRules;
            }

            public async Task<IDataResult<Brand>> Handle(GetByIdBrandQuery request, CancellationToken cancellationToken)
            {
                var result = await _brandBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorDataResult<Brand>(result.Message);

                return new SuccessDataResult<Brand>(result.Data, "Brand Listed");
            }
        }
    }
}