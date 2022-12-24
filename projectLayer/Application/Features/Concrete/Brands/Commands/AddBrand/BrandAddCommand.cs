using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Brands.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Commands.AddBrand
{
    public partial class BrandAddCommand : IRequest<IResult>
    {
        public string BrandName { get; set; }

        public class BrandAddCommandHandler : IRequestHandler<BrandAddCommand, IResult>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;
            private readonly IBrandBusinessRules _brandBusinessRules;

            public BrandAddCommandHandler(IBrandRepository brandRepository, IMapper mapper, IBrandBusinessRules brandBusinessRules)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
                _brandBusinessRules = brandBusinessRules;
            }

            public async Task<IResult> Handle(BrandAddCommand request, CancellationToken cancellationToken)
            {
                var result= await _brandBusinessRules.BrandNameExists(request.BrandName);
                if (!result.Success)
                    return new ErrorResult(result.Message);

                var mappedBrand = _mapper.Map<Brand>(request);
                mappedBrand.Status = true;
                mappedBrand.CreatedDate = DateTime.Now;
                await _brandRepository.AddAsync(mappedBrand);
                return new SuccessResult("Brand Added");
            }
        }
    }
}