using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.ProductBrands.Rules;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.ProductBrands.Commands.DeleteProductBrand
{
    public partial class ProductBrandDeleteCommand : IRequest<IResult>
    {
        public int Id { get; set; }

        public class ProductBrandDeleteCommandHandler : IRequestHandler<ProductBrandDeleteCommand, IResult>
        {
            private readonly IProductBrandBusinessRules _productBrandBusinessRules;

            public ProductBrandDeleteCommandHandler(IProductBrandBusinessRules productBrandBusinessRules)
            {
                _productBrandBusinessRules = productBrandBusinessRules;
            }

            public async Task<IResult> Handle(ProductBrandDeleteCommand request, CancellationToken cancellationToken)
            {
                var result = await _productBrandBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorResult(result.Message);

                result.Data.Status = false;
                result.Data.UpdatedDate = DateTime.Now;
                return new SuccessResult("Product Brand Deleted");
            }
        }
    }
}