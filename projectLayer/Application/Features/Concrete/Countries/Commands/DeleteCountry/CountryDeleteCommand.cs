using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Countries.Rules;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Countries.Commands.DeleteCountry
{
    public partial class CountryDeleteCommand : IRequest<IResult>
    {
        public int Id { get; set; }

        public class CountryDeleteCommandHandler : IRequestHandler<CountryDeleteCommand, IResult>
        {
            private readonly ICountryBusinessRules _countryBusinessRules;

            public CountryDeleteCommandHandler(ICountryBusinessRules countryBusinessRules)
            {
                _countryBusinessRules = countryBusinessRules;
            }

            public async Task<IResult> Handle(CountryDeleteCommand request, CancellationToken cancellationToken)
            {
                var result = await _countryBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorResult(result.Message);

                result.Data.Status = false;
                result.Data.UpdatedDate = DateTime.Now;
                return new SuccessResult("Country Deleted");
            }
        }
    }
}