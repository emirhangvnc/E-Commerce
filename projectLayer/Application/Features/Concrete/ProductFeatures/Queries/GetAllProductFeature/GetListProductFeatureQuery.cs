using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.ProductFeatures.Model;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.ProductFeatures.Queries.GetAllProductFeature
{
    public class GetListProductFeatureQuery : IRequest<IDataResult<ProductFeature>>
    {
        public PageRequest PageRequest { get; set; }
        public class GetListProductFeatureQueryHandler : IRequestHandler<GetListProductFeatureQuery, IDataResult<ProductFeature>>
        {
            private readonly IProductFeatureRepository _productFeatureRepository;
            private readonly IMapper _mapper;

            public GetListProductFeatureQueryHandler(IProductFeatureRepository productFeatureRepository, IMapper mapper)
            {
                _productFeatureRepository = productFeatureRepository;
                _mapper = mapper;
            }

            public async Task<IDataResult<ProductFeature>> Handle(GetListProductFeatureQuery request, CancellationToken cancellationToken)
            {
                IPaginate<ProductFeature> productFeature = await _productFeatureRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
                if (productFeature.Items.Count <= 0)
                    return new ErrorDataResult<ProductFeature>("Product Feature Not Found");
                var mappedProductFeatureListModel = _mapper.Map<ProductFeatureListModel>(productFeature);

                return new SuccessDataResult<ProductFeature>(mappedProductFeatureListModel, "Product Features Listed");
            }
        }
    }
}