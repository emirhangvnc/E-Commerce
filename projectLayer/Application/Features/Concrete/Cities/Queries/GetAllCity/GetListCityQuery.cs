using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Cities.Model;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Cities.Queries.GetAllCity
{
    public class GetListCityQuery : IRequest<IDataResult<City>>
    {
        public PageRequest PageRequest { get; set; }
        public class GetListCityQueryHandler : IRequestHandler<GetListCityQuery, IDataResult<City>>
        {
            private readonly ICityRepository _cityRepository;
            private readonly IMapper _mapper;

            public GetListCityQueryHandler(ICityRepository cityRepository, IMapper mapper)
            {
                _cityRepository = cityRepository;
                _mapper = mapper;
            }

            public async Task<IDataResult<City>> Handle(GetListCityQuery request, CancellationToken cancellationToken)
            {
                IPaginate<City> city = await _cityRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
                if (city.Items.Count <= 0)
                    return new ErrorDataResult<City>("City Not Found");
                var mappedCityListModel = _mapper.Map<CityListModel>(city);

                return new SuccessDataResult<City>(mappedCityListModel, "Cities Listed");
            }
        }
    }
}