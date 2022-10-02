using AutoMapper;
using MediatR;
using eCommerceLayer.Application.Features.Brands.DTOs;
using eCommerceLayer.Application.Features.Brands.Rules;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Services.Repositories;

namespace eCommerceLayer.Application.Features.Brands.Commands.DeleteBrand
{
    public partial class DeleteBrandCommand : IRequest<BrandDeleteDTO>
    {
        public string Name { get; set; }

        public class DeleteBrandCommandHandler : IRequestHandler<DeleteBrandCommand, BrandDeleteDTO>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;
            private readonly BrandBusinessRules _brandBusinessRules;

            public DeleteBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper, BrandBusinessRules brandBusinessRules)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
                _brandBusinessRules = brandBusinessRules;
            }

            public async Task<BrandDeleteDTO> Handle(DeleteBrandCommand request, CancellationToken cancellationToken)
            {
                await _brandBusinessRules.BrandNameExists(request.Name);

                var mappedBrand = _mapper.Map<Brand>(request);
                var deleteBrand = await _brandRepository.AddAsync(mappedBrand);
                var deleteBrandDto = _mapper.Map<BrandDeleteDTO>(deleteBrand);

                return deleteBrandDto;
            }
        }
    }
}