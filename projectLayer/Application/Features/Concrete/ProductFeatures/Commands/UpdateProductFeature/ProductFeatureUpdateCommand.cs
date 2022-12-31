using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.FeatureValues.Rules;
using eCommerceLayer.Application.Features.Concrete.ProductFeatures.Rules;
using eCommerceLayer.Application.Features.Concrete.Products.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.ProductFeatures.Commands.UpdateProductFeature
{
    public partial class ProductFeatureUpdateCommand : IRequest<IResult>
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int FeatureValueId { get; set; }

        public class ProductFeatureUpdateCommandHandler : IRequestHandler<ProductFeatureUpdateCommand, IResult>
        {
            private readonly IProductFeatureRepository _productFeatureRepository;
            private readonly IMapper _mapper;
            private readonly IProductFeatureBusinessRules _productFeatureBusinessRules;
            private readonly IFeatureValueBusinessRules _featureValueBusinessRules;
            private readonly IProductBusinessRules _productBusinessRules;

            public ProductFeatureUpdateCommandHandler(IProductFeatureRepository productFeatureRepository, IProductBusinessRules productBusinessRules, IProductFeatureBusinessRules productFeatureBusinessRules, IMapper mapper, IFeatureValueBusinessRules featureValueBusinessRules)
            {
                _productFeatureBusinessRules = productFeatureBusinessRules;
                _productBusinessRules = productBusinessRules;
                _featureValueBusinessRules = featureValueBusinessRules;
                _mapper = mapper;
                _productFeatureRepository = productFeatureRepository;
            }

            public async Task<IResult> Handle(ProductFeatureUpdateCommand request, CancellationToken cancellationToken)
            {
                var isProductCheck = await _productBusinessRules.IsIDExists(request.ProductId);
                if (!isProductCheck.Success)
                    return new ErrorResult(isProductCheck.Message);

                var isFeatureValueCheck = await _featureValueBusinessRules.IsIDExists(request.FeatureValueId);
                if (!isFeatureValueCheck.Success)
                    return new ErrorResult(isFeatureValueCheck.Message);

                var idCheck = await _productFeatureBusinessRules.IsIDExists(request.Id);
                if(!idCheck.Success)
                    return new ErrorResult(idCheck.Message);

                var mappedProductFeature = _mapper.Map<ProductFeature>(idCheck);
                mappedProductFeature.Status = true;
                mappedProductFeature.UpdatedDate = DateTime.Now;
                await _productFeatureRepository.UpdateAsync(mappedProductFeature);
                return new SuccessResult("Product Feature Updated");
            }
        }
    }
}