using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.ProductBrands.Rules
{
    public class ProductBrandBusinessRules : ManagerBase, IProductBrandBusinessRules
    {
        IProductBrandRepository _productBrandRepository;
        public ProductBrandBusinessRules(IMapper mapper, IProductBrandRepository productBrandRepository) : base(mapper)
        {
            _productBrandRepository = productBrandRepository;
        }

        public async Task<IDataResult<ProductBrand>> IsIDExists(int id)
        {
            var result = await _productBrandRepository.GetAsync(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<ProductBrand>("Product Brand Not Found");

            return new SuccessDataResult<ProductBrand>(result);
        }
    }
}