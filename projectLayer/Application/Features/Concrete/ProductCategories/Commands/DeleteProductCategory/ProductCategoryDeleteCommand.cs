using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.ProductCategories.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.ProductCategories.Commands.DeleteProductCategory
{
    public partial class ProductCategoryDeleteCommand : IRequest<IResult>
    {
        public int Id { get; set; }

        public class ProductCategoryDeleteCommandHandler : IRequestHandler<ProductCategoryDeleteCommand, IResult>
        {
            private readonly IProductCategoryRepository _productCategoryRepository;
            private readonly IMapper _mapper;
            private readonly IProductCategoryBusinessRules _productCategoryBusinessRules;

            public ProductCategoryDeleteCommandHandler(IProductCategoryRepository productCategoryRepository, IMapper mapper, IProductCategoryBusinessRules productCategoryBusinessRules)
            {
                _productCategoryRepository = productCategoryRepository;
                _mapper = mapper;
                _productCategoryBusinessRules = productCategoryBusinessRules;
            }

            public async Task<IResult> Handle(ProductCategoryDeleteCommand request, CancellationToken cancellationToken)
            {
                var result = await _productCategoryBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorResult(result.Message);

                result.Data.Status = false;
                result.Data.UpdatedDate = DateTime.Now;
                return new SuccessResult("Product Category Deleted");
            }
        }
    }
}