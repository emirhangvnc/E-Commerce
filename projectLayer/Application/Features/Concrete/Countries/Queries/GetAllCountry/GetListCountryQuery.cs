using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Categories.Model;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Countries.Queries.GetAllCountry
{
    public class GetListCountryQuery : IRequest<IDataResult<Country>>
    {
        public PageRequest PageRequest { get; set; }
        public class GetListCountryQueryHandler : IRequestHandler<GetListCountryQuery, IDataResult<Country>>
        {
            private readonly ICountryRepository _countryRepository;
            private readonly IMapper _mapper;

            public GetListCountryQueryHandler(ICountryRepository countryRepository, IMapper mapper)
            {
                _countryRepository = countryRepository;
                _mapper = mapper;
            }

            public async Task<IDataResult<Country>> Handle(GetListCountryQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Country> Category = await _countryRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
                if (Category.Items.Count <= 0)
                    return new ErrorDataResult<Country>("Country Not Found");
                var mappedCategoryListModel = _mapper.Map<CategoryListModel>(Category);

                return new SuccessDataResult<Country>(mappedCategoryListModel, "Countries Listed");
            }
        }
    }
}