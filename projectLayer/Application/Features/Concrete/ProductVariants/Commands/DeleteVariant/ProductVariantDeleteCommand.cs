using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.ProductVariants.Rules;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.ProductVariants.Commands.DeleteVariant
{
    public partial class ProductVariantDeleteCommand : IRequest<IResult>
    {
        public int Id { get; set; }

        public class ProductVariantDeleteCommandHandler : IRequestHandler<ProductVariantDeleteCommand, IResult>
        {
            private readonly IProductVariantBusinessRules _productVariantBusinessRules;

            public ProductVariantDeleteCommandHandler(IProductVariantBusinessRules productVariantBusinessRules)
            {
                _productVariantBusinessRules = productVariantBusinessRules;
            }

            public async Task<IResult> Handle(ProductVariantDeleteCommand request, CancellationToken cancellationToken)
            {
                var result = await _productVariantBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorResult(result.Message);

                result.Data.Status = false;
                result.Data.UpdatedDate = DateTime.Now;
                return new SuccessResult("Product Variant Deleted");
            }
        }
    }
}