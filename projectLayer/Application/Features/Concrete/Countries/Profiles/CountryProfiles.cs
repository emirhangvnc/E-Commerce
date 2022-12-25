using AutoMapper;
using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Concrete.Countries.Commands.AddCountry;
using eCommerceLayer.Application.Features.Concrete.Countries.Commands.DeleteCountry;
using eCommerceLayer.Application.Features.Concrete.Countries.Commands.UpdateCountry;
using eCommerceLayer.Application.Features.Concrete.Countries.DTOs;
using eCommerceLayer.Application.Features.Concrete.Countries.Model;
using eCommerceLayer.Application.Features.Concrete.Countries.Queries.GetAllCountry;
using eCommerceLayer.Application.Features.Concrete.Countries.Queries.GetByIdCountry;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Countries.Profiles
{
    public class CountryProfiles : Profile
    {
        public CountryProfiles()
        {
            CreateMap<Country, CountryAddDTO>().ReverseMap();
            CreateMap<Country, CountryAddCommand>().ReverseMap();

            CreateMap<Country, CountryDeleteDTO>().ReverseMap();
            CreateMap<Country, CountryDeleteCommand>().ReverseMap();

            CreateMap<Country, CountryUpdateDTO>().ReverseMap();
            CreateMap<Country, CountryUpdateCommand>().ReverseMap();

            CreateMap<IPaginate<Country>, CountryListModel>().ReverseMap();
            CreateMap<Country, CountryListDTO>().ReverseMap();
            CreateMap<Country, GetListCountryQuery>().ReverseMap();
            CreateMap<Country, CountryGetByIdDTO>().ReverseMap();
            CreateMap<Country, GetByIdCountryQuery>().ReverseMap();
        }
    }
}