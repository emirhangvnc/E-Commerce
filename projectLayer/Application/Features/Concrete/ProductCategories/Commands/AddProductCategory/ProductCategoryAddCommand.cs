using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Categories.Rules;
using eCommerceLayer.Application.Features.Concrete.Products.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.ProductCategories.Commands.AddProductCategory
{
    public partial class ProductCategoryAddCommand : IRequest<IResult>
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        public class ProductCategoryAddCommandHandler : IRequestHandler<ProductCategoryAddCommand, IResult>
        {
            private readonly IProductCategoryRepository _productCategoryRepository;
            private readonly IMapper _mapper;
            private readonly ICategoryBusinessRules _categoryBusinessRules;
            private readonly IProductBusinessRules _productBusinessRules;

            public ProductCategoryAddCommandHandler(IProductBusinessRules productBusinessRules, ICategoryBusinessRules categoryBusinessRules, IProductCategoryRepository productCategoryRepository, IMapper mapper)
            {
                _productCategoryRepository = productCategoryRepository;
                _mapper = mapper;
                _categoryBusinessRules = categoryBusinessRules;
                _productBusinessRules = productBusinessRules;
            }

            public async Task<IResult> Handle(ProductCategoryAddCommand request, CancellationToken cancellationToken)
            {
                var isProductCheck = await _productBusinessRules.IsIDExists(request.ProductId);
                if (!isProductCheck.Success)
                    return new ErrorResult(isProductCheck.Message);

                var isCategoryCheck = await _categoryBusinessRules.IsIDExists(request.CategoryId);
                if (!isCategoryCheck.Success)
                    return new ErrorResult(isCategoryCheck.Message);

                var mappedProductCategory = _mapper.Map<ProductCategory>(request);
                mappedProductCategory.Status = true;
                mappedProductCategory.CreatedDate = DateTime.Now;
                mappedProductCategory.UpdatedDate = DateTime.Now;
                await _productCategoryRepository.AddAsync(mappedProductCategory);
                return new SuccessResult("Product Category Added");
            }
        }
    }
}