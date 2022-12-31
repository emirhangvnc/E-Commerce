using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.ProductVariants.Model;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.ProductVariants.Queries.GetAllProductVariant
{
    public class GetListProductVariantQuery : IRequest<IDataResult<ProductVariant>>
    {
        public PageRequest PageRequest { get; set; }
        public class GetListProductVariantQueryHandler : IRequestHandler<GetListProductVariantQuery, IDataResult<ProductVariant>>
        {
            private readonly IProductVariantRepository _productVariantRepository;
            private readonly IMapper _mapper;

            public GetListProductVariantQueryHandler(IProductVariantRepository productVariantRepository, IMapper mapper)
            {
                _productVariantRepository = productVariantRepository;
                _mapper = mapper;
            }

            public async Task<IDataResult<ProductVariant>> Handle(GetListProductVariantQuery request, CancellationToken cancellationToken)
            {
                IPaginate<ProductVariant> productVariant = await _productVariantRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
                if (productVariant.Items.Count <= 0)
                    return new ErrorDataResult<ProductVariant>("Product Variant Not Found");
                var mappedProductVariantListModel = _mapper.Map<ProductVariantListModel>(productVariant);

                return new SuccessDataResult<ProductVariant>(mappedProductVariantListModel, "Product Variants Listed");
            }
        }
    }
}