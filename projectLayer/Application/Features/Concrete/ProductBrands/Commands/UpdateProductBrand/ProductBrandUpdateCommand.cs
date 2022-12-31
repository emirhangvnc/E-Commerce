using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Brands.Rules;
using eCommerceLayer.Application.Features.Concrete.ProductBrands.Rules;
using eCommerceLayer.Application.Features.Concrete.Products.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.ProductBrands.Commands.UpdateProductBrand
{
    public partial class ProductBrandUpdateCommand : IRequest<IResult>
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int BrandId { get; set; }

        public class ProductBrandUpdateCommandHandler : IRequestHandler<ProductBrandUpdateCommand, IResult>
        {
            private readonly IProductBrandRepository _productBrandRepository;
            private readonly IMapper _mapper;
            private readonly IProductBrandBusinessRules _productBrandBusinessRules;
            private readonly IBrandBusinessRules _brandBusinessRules;
            private readonly IProductBusinessRules _productBusinessRules;

            public ProductBrandUpdateCommandHandler(IBrandBusinessRules brandBusinessRules, IProductBusinessRules productBusinessRules, IProductBrandBusinessRules productBrandBusinessRules, IProductBrandRepository productBrandRepository, IMapper mapper)
            {
                _productBrandRepository = productBrandRepository;
                _mapper = mapper;
                _productBrandBusinessRules = productBrandBusinessRules;
                _productBusinessRules = productBusinessRules;
                _brandBusinessRules = brandBusinessRules;
            }

            public async Task<IResult> Handle(ProductBrandUpdateCommand request, CancellationToken cancellationToken)
            {
                var isProductCheck = await _productBusinessRules.IsIDExists(request.ProductId);
                if (!isProductCheck.Success)
                    return new ErrorResult(isProductCheck.Message);

                var isFeatureValueCheck = await _brandBusinessRules.IsIDExists(request.BrandId);
                if (!isFeatureValueCheck.Success)
                    return new ErrorResult(isFeatureValueCheck.Message);

                var idCheck = await _productBrandBusinessRules.IsIDExists(request.Id);
                if (!idCheck.Success)
                    return new ErrorResult(idCheck.Message);

                var mappedProductBrand = _mapper.Map<ProductBrand>(idCheck);
                mappedProductBrand.Status = true;
                mappedProductBrand.UpdatedDate = DateTime.Now;
                await _productBrandRepository.UpdateAsync(mappedProductBrand);
                return new SuccessResult("Product Brand Updated");
            }
        }
    }
}