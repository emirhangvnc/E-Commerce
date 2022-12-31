using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.ProductVariants.Rules
{
    public class ProductVariantBusinessRules : ManagerBase, IProductVariantBusinessRules
    {
        IProductVariantRepository _productVariantRepository;
        public ProductVariantBusinessRules(IMapper mapper, IProductVariantRepository productVariantRepository) : base(mapper)
        {
            _productVariantRepository = productVariantRepository;
        }

        public async Task<IDataResult<ProductVariant>> IsIDExists(int id)
        {
            var result = await _productVariantRepository.GetAsync(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<ProductVariant>("Product Variant Not Found");

            return new SuccessDataResult<ProductVariant>(result);
        }
    }
}