using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.ProductCategories.Model;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.ProductCategories.Queries.GetAllProductCategory
{
    public class GetListProductCategoryQuery : IRequest<IDataResult<ProductCategory>>
    {
        public PageRequest PageRequest { get; set; }
        public class GetListProductCategoryQueryHandler : IRequestHandler<GetListProductCategoryQuery, IDataResult<ProductCategory>>
        {
            private readonly IProductCategoryRepository _productCategoryRepository;
            private readonly IMapper _mapper;

            public GetListProductCategoryQueryHandler(IProductCategoryRepository productCategoryRepository, IMapper mapper)
            {
                _productCategoryRepository = productCategoryRepository;
                _mapper = mapper;
            }

            public async Task<IDataResult<ProductCategory>> Handle(GetListProductCategoryQuery request, CancellationToken cancellationToken)
            {
                IPaginate<ProductCategory> productCategory = await _productCategoryRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
                if (productCategory.Items.Count <= 0)
                    return new ErrorDataResult<ProductCategory>("Product Category Not Found");
                var mappedProductCategoryListModel = _mapper.Map<ProductCategoryListModel>(productCategory);

                return new SuccessDataResult<ProductCategory>(mappedProductCategoryListModel, "Product Categories Listed");
            }
        }
    }
}