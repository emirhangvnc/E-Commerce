using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Categories.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Commands.AddCategory
{
    public partial class CategoryAddCommand : IRequest<IResult>
    {
        public string FeatureName { get; set; }

        public class FeatureAddCommandHandler : IRequestHandler<CategoryAddCommand, IResult>
        {
            private readonly ICategoryRepository _categoryRepository;
            private readonly IMapper _mapper;
            private readonly ICategoryBusinessRules _categoryBusinessRules;

            public FeatureAddCommandHandler(ICategoryRepository categoryRepository, IMapper mapper, ICategoryBusinessRules categoryBusinessRules)
            {
                _categoryRepository = categoryRepository;
                _mapper = mapper;
                _categoryBusinessRules = categoryBusinessRules;
            }

            public async Task<IResult> Handle(CategoryAddCommand request, CancellationToken cancellationToken)
            {
                var result= await _categoryBusinessRules.CategoryNameExists(request.FeatureName);
                if (!result.Success)
                    return new ErrorResult(result.Message);

                var mappedCategory = _mapper.Map<Category>(request);
                mappedCategory.Status = true;
                mappedCategory.CreatedDate = DateTime.Now;
                await _categoryRepository.AddAsync(mappedCategory);
                return new SuccessResult("Category Added");
            }
        }
    }
}