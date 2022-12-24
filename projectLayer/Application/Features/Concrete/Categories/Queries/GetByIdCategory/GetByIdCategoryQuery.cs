using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Categories.Rules;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Queries.GetByIdCategory
{
    public class GetByIdCategoryQuery : IRequest<IDataResult<Category>>
    {
        public int Id { get; set; }
        public class GetByIdCategoryQueryHandler : IRequestHandler<GetByIdCategoryQuery, IDataResult<Category>>
        {
            private readonly IMapper _mapper;
            private readonly ICategoryBusinessRules _categoryBusinessRules;

            public GetByIdCategoryQueryHandler(IMapper mapper, ICategoryBusinessRules categoryBusinessRules)
            {
                _mapper = mapper;
                _categoryBusinessRules = categoryBusinessRules;
            }

            public async Task<IDataResult<Category>> Handle(GetByIdCategoryQuery request, CancellationToken cancellationToken)
            {
                var result = await _categoryBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorDataResult<Category>(result.Message);

                return new SuccessDataResult<Category>(result.Data, "Category Listed");
            }
        }
    }
}