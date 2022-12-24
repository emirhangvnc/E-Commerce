using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Categories.Model;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Queries.GetAllCategories
{
    public class GetListCategoryQuery : IRequest<IDataResult<Category>>
    {
        public PageRequest PageRequest { get; set; }
        public class GetListCategoryQueryHandler : IRequestHandler<GetListCategoryQuery, IDataResult<Category>>
        {
            private readonly ICategoryRepository _categoryRepository;
            private readonly IMapper _mapper;

            public GetListCategoryQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
            {
                _categoryRepository = categoryRepository;
                _mapper = mapper;
            }

            public async Task<IDataResult<Category>> Handle(GetListCategoryQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Category> Feature = await _categoryRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
                if (Feature.Items.Count <= 0)
                    return new ErrorDataResult<Category>("Category Not Found");
                var mappedFeatureListModel = _mapper.Map<CategoryListModel>(Feature);

                return new SuccessDataResult<Category>(mappedFeatureListModel, "Categories Listed");
            }
        }
    }
}