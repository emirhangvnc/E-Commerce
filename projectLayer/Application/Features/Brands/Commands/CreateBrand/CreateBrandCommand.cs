using AutoMapper;
using MediatR;
using projectLayer.Application.Features.Brands.DTOs;
using projectLayer.Application.Features.Brands.Rules;
using projectLayer.Domain.Entities;
using projectLayer.Persistence.Services.Repositories;

namespace projectLayer.Application.Features.Brands.Commands.CreateBrand
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