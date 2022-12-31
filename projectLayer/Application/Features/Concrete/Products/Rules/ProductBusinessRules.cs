using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Products.Rules
{
    public class ProductBusinessRules : ManagerBase, IProductBusinessRules
    {
        IProductRepository _productRepository;
        public ProductBusinessRules(IMapper mapper, IProductRepository productRepository) : base(mapper)
        {
            _productRepository = productRepository;
        }

        public async Task<IDataResult<Product>> IsIDExists(int id)
        {
            var result = await _productRepository.GetAsync(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<Product>("Product Not Found");

            return new SuccessDataResult<Product>(result);
        }
    }
}