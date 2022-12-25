using AutoMapper;
using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Concrete.Cities.Commands.AddCity;
using eCommerceLayer.Application.Features.Concrete.Cities.Commands.DeleteCity;
using eCommerceLayer.Application.Features.Concrete.Cities.Commands.UpdateCity;
using eCommerceLayer.Application.Features.Concrete.Cities.DTOs;
using eCommerceLayer.Application.Features.Concrete.Cities.Model;
using eCommerceLayer.Application.Features.Concrete.Cities.Queries.GetAllCity;
using eCommerceLayer.Application.Features.Concrete.Cities.Queries.GetByIdCity;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Cities.Profiles
{
    public class CityProfiles : Profile
    {
        public CityProfiles()
        {
            CreateMap<City, CityAddDTO>().ReverseMap();
            CreateMap<City, CityAddCommand>().ReverseMap();

            CreateMap<City, CityDeleteDTO>().ReverseMap();
            CreateMap<City, CityDeleteCommand>().ReverseMap();

            CreateMap<City, CityUpdateDTO>().ReverseMap();
            CreateMap<City, CityUpdateCommand>().ReverseMap();

            CreateMap<IPaginate<City>, CityListModel>().ReverseMap();
            CreateMap<City, CityListDTO>().ReverseMap();
            CreateMap<City, GetListCityQuery>().ReverseMap();
            CreateMap<City, CityGetByIdDTO>().ReverseMap();
            CreateMap<City, GetByIdCityQuery>().ReverseMap();
        }
    }
}