using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Brands.Rules;
using eCommerceLayer.Application.Features.Concrete.Products.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.ProductBrands.Commands.AddProductBrand
{
    public partial class ProductBrandAddCommand : IRequest<IResult>
    {
        public int ProductId { get; set; }
        public int BrandId { get; set; }

        public class ProductBrandAddCommandHandler : IRequestHandler<ProductBrandAddCommand, IResult>
        {
            private readonly IProductBrandRepository _productBrandRepository;
            private readonly IMapper _mapper;
            private readonly IBrandBusinessRules _brandBusinessRules;
            private readonly IProductBusinessRules _productBusinessRules;

            public ProductBrandAddCommandHandler(IProductBusinessRules productBusinessRules, IBrandBusinessRules brandBusinessRules, IProductBrandRepository productBrandRepository, IMapper mapper)
            {
                _productBrandRepository = productBrandRepository;
                _mapper = mapper;
                _brandBusinessRules = brandBusinessRules;
                _productBusinessRules = productBusinessRules;
            }

            public async Task<IResult> Handle(ProductBrandAddCommand request, CancellationToken cancellationToken)
            {
                var isProductCheck = await _productBusinessRules.IsIDExists(request.ProductId);
                if (!isProductCheck.Success)
                    return new ErrorResult(isProductCheck.Message);

                var isBrandCheck = await _brandBusinessRules.IsIDExists(request.BrandId);
                if (!isBrandCheck.Success)
                    return new ErrorResult(isBrandCheck.Message);

                var mappedProductBrand = _mapper.Map<ProductBrand>(request);
                mappedProductBrand.Status = true;
                mappedProductBrand.CreatedDate = DateTime.Now;
                mappedProductBrand.UpdatedDate = DateTime.Now;
                await _productBrandRepository.AddAsync(mappedProductBrand);
                return new SuccessResult("Product Brand Added");
            }
        }
    }
}