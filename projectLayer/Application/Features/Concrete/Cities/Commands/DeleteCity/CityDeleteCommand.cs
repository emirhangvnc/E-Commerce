using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Cities.Rules;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Cities.Commands.DeleteCity
{
    public partial class CityDeleteCommand : IRequest<IResult>
    {
        public int Id { get; set; }

        public class CityDeleteCommandHandler : IRequestHandler<CityDeleteCommand, IResult>
        {
            private readonly ICityBusinessRules _cityBusinessRules;

            public CityDeleteCommandHandler(ICityBusinessRules cityBusinessRules)
            {
                _cityBusinessRules = cityBusinessRules;
            }

            public async Task<IResult> Handle(CityDeleteCommand request, CancellationToken cancellationToken)
            {
                var result = await _cityBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorResult(result.Message);

                result.Data.Status = false;
                result.Data.UpdatedDate = DateTime.Now;
                return new SuccessResult("City Deleted");
            }
        }
    }
}