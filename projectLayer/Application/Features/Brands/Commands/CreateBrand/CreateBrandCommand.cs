using AutoMapper;
using MediatR;
using eCommerceLayer.Application.Features.Brands.DTOs;
using eCommerceLayer.Application.Features.Brands.Rules;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Services.Repositories;

namespace eCommerceLayer.Application.Features.Brands.Commands.CreateBrand
{
    public partial class CreateBrandCommand : IRequest<BrandAddDTO>
    {
        public string Name { get; set; }

        public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, BrandAddDTO>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;
            private readonly BrandBusinessRules _brandBusinessRules;

            public CreateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper, BrandBusinessRules brandBusinessRules)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
                _brandBusinessRules = brandBusinessRules;
            }

            public async Task<BrandAddDTO> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
            {
                await _brandBusinessRules.BrandNameCanNotBeDuplicatedWhenInserted(request.Name);

                Brand mappedBrand = _mapper.Map<Brand>(request);
                Brand createdBrand = await _brandRepository.AddAsync(mappedBrand);
                BrandAddDTO createdBrandDto = _mapper.Map<BrandAddDTO>(createdBrand);

                return createdBrandDto;
            }
        }
    }
}