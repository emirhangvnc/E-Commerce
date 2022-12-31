using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.ProductCategories.Rules
{
    public class ProductCategoryBusinessRules : ManagerBase, IProductCategoryBusinessRules
    {
        IProductCategoryRepository _productCategoryRepository;
        public ProductCategoryBusinessRules(IMapper mapper, IProductCategoryRepository productCategoryRepository) : base(mapper)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public async Task<IDataResult<ProductCategory>> IsIDExists(int id)
        {
            var result = await _productCategoryRepository.GetAsync(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<ProductCategory>("Product Category Not Found");

            return new SuccessDataResult<ProductCategory>(result);
        }
    }
}