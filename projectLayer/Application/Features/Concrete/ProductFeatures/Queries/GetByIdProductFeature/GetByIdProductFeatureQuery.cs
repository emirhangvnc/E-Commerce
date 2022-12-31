using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.ProductFeatures.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.ProductFeatures.Queries.GetByIdProductFeature
{
    public class GetByIdProductFeatureQuery : IRequest<IDataResult<ProductFeature>>
    {
        public int Id { get; set; }
        public class GetByIdProductFeatureQueryHandler : IRequestHandler<GetByIdProductFeatureQuery, IDataResult<ProductFeature>>
        {
            private readonly IProductFeatureRepository _productFeatureRepository;
            private readonly IMapper _mapper;
            private readonly IProductFeatureBusinessRules _productFeatureBusinessRules;

            public GetByIdProductFeatureQueryHandler(IProductFeatureRepository productFeatureRepository, IMapper mapper, IProductFeatureBusinessRules productFeatureBusinessRules)
            {
                _productFeatureRepository = productFeatureRepository;
                _mapper = mapper;
                _productFeatureBusinessRules = productFeatureBusinessRules;
            }

            public async Task<IDataResult<ProductFeature>> Handle(GetByIdProductFeatureQuery request, CancellationToken cancellationToken)
            {
                var result = await _productFeatureBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorDataResult<ProductFeature>(result.Message);

                return new SuccessDataResult<ProductFeature>(result.Data, "Product Feature Listed");
            }
        }
    }
}