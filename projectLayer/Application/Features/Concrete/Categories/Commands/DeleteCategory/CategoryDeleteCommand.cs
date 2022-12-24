using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Categories.Rules;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Commands.DeleteFeature
{
    public partial class CategoryDeleteCommand : IRequest<IResult>
    {
        public int Id { get; set; }

        public class CategoryDeleteCommandHandler : IRequestHandler<CategoryDeleteCommand, IResult>
        {
            private readonly ICategoryBusinessRules _categoryBusinessRules;

            public CategoryDeleteCommandHandler(ICategoryBusinessRules categoryBusinessRules)
            {
                _categoryBusinessRules = categoryBusinessRules;
            }

            public async Task<IResult> Handle(CategoryDeleteCommand request, CancellationToken cancellationToken)
            {
                var result = await _categoryBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorResult(result.Message);

                result.Data.Status = false;
                return new SuccessResult("Category Deleted");
            }
        }
    }
}