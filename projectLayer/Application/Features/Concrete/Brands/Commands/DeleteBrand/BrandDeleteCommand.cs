using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Brands.Rules;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Commands.DeleteBrand
{
    public partial class BrandDeleteCommand : IRequest<IResult>
    {
        public int Id { get; set; }

        public class BrandDeleteCommandHandler : IRequestHandler<BrandDeleteCommand, IResult>
        {
            private readonly IBrandBusinessRules _brandBusinessRules;

            public BrandDeleteCommandHandler(IBrandBusinessRules brandBusinessRules)
            {
                _brandBusinessRules = brandBusinessRules;
            }

            public async Task<IResult> Handle(BrandDeleteCommand request, CancellationToken cancellationToken)
            {
                var result = await _brandBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorResult(result.Message);

                result.Data.Status = false;
                return new SuccessResult("Brand Deleted");
            }
        }
    }
}