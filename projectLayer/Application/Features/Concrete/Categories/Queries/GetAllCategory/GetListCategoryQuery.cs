using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Categories.Model;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Queries.GetAllCategory
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
                IPaginate<Category> Category = await _categoryRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
                if (Category.Items.Count <= 0)
                    return new ErrorDataResult<Category>("Category Not Found");
                var mappedCategoryListModel = _mapper.Map<CategoryListModel>(Category);

                return new SuccessDataResult<Category>(mappedCategoryListModel, "Categories Listed");
            }
        }
    }
}