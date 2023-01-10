using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Core.Persistence.Repositories;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Brands.Model;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Queries.GetAllBrand
{
    public class GetListBrandQuery : IRequest<IDataResult<Brand>>
    {
        public PageRequest PageRequest { get; set; }
        public class GetListBrandQueryHandler : IRequestHandler<GetListBrandQuery, IDataResult<Brand>>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;

            public GetListBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
            }

            public async Task<IDataResult<Brand>> Handle(GetListBrandQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Brand> Brand = await _brandRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
                if (Brand.Items.Count <= 0)
                    return new ErrorDataResult<Brand>("Brand Not Found");
                var mappedBrandListModel = _mapper.Map<BrandListModel>(Brand);

                return new SuccessDataResult<Brand>(mappedBrandListModel, "Brands Listed");
            }
        }
    }
}