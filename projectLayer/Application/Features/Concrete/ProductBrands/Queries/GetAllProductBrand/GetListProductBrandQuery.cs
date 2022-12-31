using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.ProductBrands.Model;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.ProductBrands.Queries.GetAllProductBrand
{
    public class GetListProductBrandQuery : IRequest<IDataResult<ProductBrand>>
    {
        public PageRequest PageRequest { get; set; }
        public class GetListProductBrandQueryHandler : IRequestHandler<GetListProductBrandQuery, IDataResult<ProductBrand>>
        {
            private readonly IProductBrandRepository _productBrandRepository;
            private readonly IMapper _mapper;

            public GetListProductBrandQueryHandler(IProductBrandRepository productBrandRepository, IMapper mapper)
            {
                _productBrandRepository = productBrandRepository;
                _mapper = mapper;
            }

            public async Task<IDataResult<ProductBrand>> Handle(GetListProductBrandQuery request, CancellationToken cancellationToken)
            {
                IPaginate<ProductBrand> productBrand = await _productBrandRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
                if (productBrand.Items.Count <= 0)
                    return new ErrorDataResult<ProductBrand>("Product Brand Not Found");
                var mappedProductBrandListModel = _mapper.Map<ProductBrandListModel>(productBrand);

                return new SuccessDataResult<ProductBrand>(mappedProductBrandListModel, "Product Brands Listed");
            }
        }
    }
}
