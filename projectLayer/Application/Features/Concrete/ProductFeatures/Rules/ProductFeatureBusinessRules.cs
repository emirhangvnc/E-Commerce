using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.ProductFeatures.Rules
{
    public class ProductFeatureBusinessRules : ManagerBase, IProductFeatureBusinessRules
    {
        IProductFeatureRepository _productFeatureRepository;
        public ProductFeatureBusinessRules(IMapper mapper, IProductFeatureRepository productFeatureRepository) : base(mapper)
        {
            _productFeatureRepository = productFeatureRepository;
        }

        public async Task<IDataResult<ProductFeature>> IsIDExists(int id)
        {
            var result = await _productFeatureRepository.GetAsync(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<ProductFeature>("Product Feature Not Found");

            return new SuccessDataResult<ProductFeature>(result);
        }
    }
}