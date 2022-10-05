using AutoMapper;
using Core.Application.Requests;
using eCommerceLayer.Application.Features.Concrete.Brands.Models;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Services.Repositories;
using Core.Security.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Persistence.Concrete.Contexts;
using eCommerceLayer.Persistence.Repositories;
using eCommerceLayer.Application.Features.Concrete.Brands.Constants.Languages.TR;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Queries.GetAllBrand
{
    public class GetAllBrandQuery : ManagerBase, IGetAllBrandQuery
    {
        IBrandRepository _brandRepository;
        public GetAllBrandQuery(IMapper mapper, BaseDbContext context, BrandRepository brandRepository) : base(mapper, context)
        {
            _brandRepository = brandRepository;
        }

        public async Task<IDataResult<Brand>> GetAll(PageRequest request)
        {
            var result = await _brandRepository.GetListAsync(index: request.Page, size: request.PageSize);

            if (result.Items.Count <= 0)
                return new ErrorDataResult<Brand>(BrandMessagesTR.BrandNotFound);

            var mappedBrandListModel = Mapper.Map<BrandListModel>(result);
            return new SuccessDataResult<Brand>();
        }
    }
}