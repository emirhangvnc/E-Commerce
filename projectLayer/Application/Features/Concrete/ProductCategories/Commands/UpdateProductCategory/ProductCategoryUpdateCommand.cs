using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Categories.Rules;
using eCommerceLayer.Application.Features.Concrete.FeatureValues.Rules;
using eCommerceLayer.Application.Features.Concrete.ProductCategories.Rules;
using eCommerceLayer.Application.Features.Concrete.ProductFeatures.Rules;
using eCommerceLayer.Application.Features.Concrete.Products.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.ProductCategories.Commands.UpdateProductCategory
{
    public partial class ProductCategoryUpdateCommand : IRequest<IResult>
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        public class ProductCategoryUpdateCommandHandler : IRequestHandler<ProductCategoryUpdateCommand, IResult>
        {
            private readonly IProductCategoryRepository _productCategoryRepository;
            private readonly IMapper _mapper;
            private readonly IProductCategoryBusinessRules _productCategoryBusinessRules;
            private readonly ICategoryBusinessRules _categoryBusinessRules;
            private readonly IProductBusinessRules _productBusinessRules;

            public ProductCategoryUpdateCommandHandler(ICategoryBusinessRules categoryBusinessRules, IProductBusinessRules productBusinessRules, IProductCategoryBusinessRules productCategoryBusinessRules, IProductCategoryRepository productCategoryRepository, IMapper mapper)
            {
                _productCategoryRepository = productCategoryRepository;
                _mapper = mapper;
                _productCategoryBusinessRules = productCategoryBusinessRules;
                _productBusinessRules = productBusinessRules;
                _categoryBusinessRules= categoryBusinessRules;
            }

            public async Task<IResult> Handle(ProductCategoryUpdateCommand request, CancellationToken cancellationToken)
            {
                var isProductCheck = await _productBusinessRules.IsIDExists(request.ProductId);
                if (!isProductCheck.Success)
                    return new ErrorResult(isProductCheck.Message);

                var isFeatureValueCheck = await _categoryBusinessRules.IsIDExists(request.CategoryId);
                if (!isFeatureValueCheck.Success)
                    return new ErrorResult(isFeatureValueCheck.Message);

                var idCheck = await _productCategoryBusinessRules.IsIDExists(request.Id);
                if (!idCheck.Success)
                    return new ErrorResult(idCheck.Message);

                var mappedProductCategory = _mapper.Map<ProductCategory>(idCheck);
                mappedProductCategory.Status = true;
                mappedProductCategory.UpdatedDate = DateTime.Now;
                await _productCategoryRepository.UpdateAsync(mappedProductCategory);
                return new SuccessResult("Product Category Updated");
            }
        }
    }
}