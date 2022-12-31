using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.VariantValues.Rules;
using eCommerceLayer.Application.Features.Concrete.ProductVariants.Rules;
using eCommerceLayer.Application.Features.Concrete.Products.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.ProductVariants.Commands.UpdateVariant
{
    public partial class ProductVariantUpdateCommand : IRequest<IResult>
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int VariantValueId { get; set; }
        public string? VariantSku { get; set; }
        public string? VariantGtin { get; set; }
        public decimal? VariantPrice { get; set; }

        public class ProductVariantUpdateCommandHandler : IRequestHandler<ProductVariantUpdateCommand, IResult>
        {
            private readonly IProductVariantRepository _productVariantRepository;
            private readonly IMapper _mapper;
            private readonly IProductVariantBusinessRules _productVariantBusinessRules;
            private readonly IVariantValueBusinessRules _variantValueBusinessRules;
            private readonly IProductBusinessRules _productBusinessRules;

            public ProductVariantUpdateCommandHandler(IProductVariantRepository productVariantRepository, IProductBusinessRules productBusinessRules, IProductVariantBusinessRules productVariantBusinessRules, IMapper mapper, IVariantValueBusinessRules variantValueBusinessRules)
            {
                _productVariantBusinessRules = productVariantBusinessRules;
                _productBusinessRules = productBusinessRules;
                _variantValueBusinessRules = variantValueBusinessRules;
                _mapper = mapper;
                _productVariantRepository = productVariantRepository;
            }

            public async Task<IResult> Handle(ProductVariantUpdateCommand request, CancellationToken cancellationToken)
            {
                var isProductCheck = await _productBusinessRules.IsIDExists(request.ProductId);
                if (!isProductCheck.Success)
                    return new ErrorResult(isProductCheck.Message);

                var isVariantValueCheck = await _variantValueBusinessRules.IsIDExists(request.VariantValueId);
                if (!isVariantValueCheck.Success)
                    return new ErrorResult(isVariantValueCheck.Message);

                var idCheck = await _productVariantBusinessRules.IsIDExists(request.Id);
                if (!idCheck.Success)
                    return new ErrorResult(idCheck.Message);

                var mappedProductVariant = _mapper.Map<ProductVariant>(idCheck);
                mappedProductVariant.Status = true;
                mappedProductVariant.UpdatedDate = DateTime.Now;
                await _productVariantRepository.UpdateAsync(mappedProductVariant);
                return new SuccessResult("Product Variant Updated");
            }
        }
    }
}
