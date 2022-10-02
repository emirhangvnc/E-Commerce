using AutoMapper;
using MediatR;
using eCommerceLayer.Application.Features.Brands.DTOs;
using eCommerceLayer.Application.Features.Brands.Rules;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Services.Repositories;

namespace eCommerceLayer.Application.Features.Brands.Commands.CreateBrand
{
    public partial class AddBrandCommand : IRequest<BrandAddDTO>
    {
        public string Name { get; set; }

        public class AddBrandCommandHandler : IRequestHandler<AddBrandCommand, BrandAddDTO>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;
            private readonly BrandBusinessRules _brandBusinessRules;

            public AddBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper, BrandBusinessRules brandBusinessRules)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
                _brandBusinessRules = brandBusinessRules;
            }

            public async Task<BrandAddDTO> Handle(AddBrandCommand request, CancellationToken cancellationToken)
            {
                await _brandBusinessRules.BrandNameExists(request.Name);

                var mappedBrand = _mapper.Map<Brand>(request);
                var createdBrand = await _brandRepository.AddAsync(mappedBrand);
                var createdBrandDto = _mapper.Map<BrandAddDTO>(createdBrand);

                return createdBrandDto;
            }
        }
    }
}