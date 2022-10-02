using AutoMapper;
using MediatR;
using eCommerceLayer.Application.Features.Brands.DTOs;
using eCommerceLayer.Application.Features.Brands.Rules;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Services.Repositories;

namespace eCommerceLayer.Application.Features.Brands.Commands.UpdateBrand
{
    public partial class UpdateBrandCommand : IRequest<BrandUpdateDTO>
    {
        public string Name { get; set; }

        public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand, BrandUpdateDTO>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;
            private readonly BrandBusinessRules _brandBusinessRules;

            public UpdateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper, BrandBusinessRules brandBusinessRules)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
                _brandBusinessRules = brandBusinessRules;
            }

            public async Task<BrandUpdateDTO> Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
            {
                await _brandBusinessRules.BrandNameExists(request.Name);

                var mappedBrand = _mapper.Map<Brand>(request);
                var updateBrand = await _brandRepository.AddAsync(mappedBrand);
                var updateBrandDto = _mapper.Map<BrandUpdateDTO>(updateBrand);

                return updateBrandDto;
            }
        }
    }
}