using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Categories.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Commands.UpdateCategory
{
    public partial class CategoryUpdateCommand : IRequest<IResult>
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public class CategoryUpdateCommandHandler : IRequestHandler<CategoryUpdateCommand, IResult>
        {
            private readonly ICategoryRepository _categoryRepository;
            private readonly IMapper _mapper;
            private readonly ICategoryBusinessRules _categoryBusinessRules;

            public CategoryUpdateCommandHandler(ICategoryRepository categoryRepository, IMapper mapper, ICategoryBusinessRules categoryBusinessRules)
            {
                _categoryRepository = categoryRepository;
                _mapper = mapper;
                _categoryBusinessRules = categoryBusinessRules;
            }

            public async Task<IResult> Handle(CategoryUpdateCommand request, CancellationToken cancellationToken)
            {
                var nameCheck = await _categoryBusinessRules.CategoryNameExists(request.CategoryName);
                if (!nameCheck.Success)
                    return new ErrorResult(nameCheck.Message);
                var idCheck = await _categoryBusinessRules.IsIDExists(request.Id);
                if (!idCheck.Success)
                    return new ErrorResult(idCheck.Message);

                var mappedCategory = _mapper.Map<Category>(idCheck);
                mappedCategory.Status = true;
                await _categoryRepository.UpdateAsync(mappedCategory);
                return new SuccessResult("Category Updated");
            }
        }
    }
}