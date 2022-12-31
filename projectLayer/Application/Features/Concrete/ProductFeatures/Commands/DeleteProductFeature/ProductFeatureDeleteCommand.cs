using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.ProductFeatures.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.ProductFeatures.Commands.DeleteProductFeature
{
    public partial class ProductFeatureDeleteCommand : IRequest<IResult>
    {
        public int Id { get; set; }

        public class ProductFeatureDeleteCommandHandler : IRequestHandler<ProductFeatureDeleteCommand, IResult>
        {
            private readonly IProductFeatureRepository _productFeatureRepository;
            private readonly IMapper _mapper;
            private readonly IProductFeatureBusinessRules _productFeatureBusinessRules;

            public ProductFeatureDeleteCommandHandler(IProductFeatureRepository productFeatureRepository, IMapper mapper, IProductFeatureBusinessRules productFeatureBusinessRules)
            {
                _productFeatureRepository = productFeatureRepository;
                _mapper = mapper;
                _productFeatureBusinessRules = productFeatureBusinessRules;
            }

            public async Task<IResult> Handle(ProductFeatureDeleteCommand request, CancellationToken cancellationToken)
            {
                var result = await _productFeatureBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorResult(result.Message);

                result.Data.Status = false;
                result.Data.UpdatedDate = DateTime.Now;
                return new SuccessResult("Product Feature Deleted");
            }
        }
    }
}