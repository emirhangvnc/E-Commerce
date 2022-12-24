using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Brands.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Commands.UpdateBrand
{
    public partial class BrandUpdateCommand : IRequest<IResult>
    {
        public int Id { get; set; }
        public string BrandName { get; set; }

        public class BrandUpdateCommandHandler : IRequestHandler<BrandUpdateCommand, IResult>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;
            private readonly IBrandBusinessRules _brandBusinessRules;

            public BrandUpdateCommandHandler(IBrandRepository brandRepository, IMapper mapper, IBrandBusinessRules brandBusinessRules)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
                _brandBusinessRules = brandBusinessRules;
            }

            public async Task<IResult> Handle(BrandUpdateCommand request, CancellationToken cancellationToken)
            {
                var nameCheck = await _brandBusinessRules.BrandNameExists(request.BrandName);
                if (!nameCheck.Success)
                    return new ErrorResult(nameCheck.Message);
                var idCheck = await _brandBusinessRules.IsIDExists(request.Id);
                if (!idCheck.Success)
                    return new ErrorResult(idCheck.Message);

                var mappedBrand = _mapper.Map<Brand>(idCheck);
                mappedBrand.Status = true;
                await _brandRepository.UpdateAsync(mappedBrand);
                return new SuccessResult("Brand Updated");
            }
        }
    }
}