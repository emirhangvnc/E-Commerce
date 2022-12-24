using AutoMapper;
using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Concrete.Brands.Commands.AddBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.Commands.DeleteBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.Commands.UpdateBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.DTOs;
using eCommerceLayer.Application.Features.Concrete.Brands.Model;
using eCommerceLayer.Application.Features.Concrete.Brands.Queries.GetAllBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.Queries.GetByIdBrand;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Profiles
{
    public class BrandProfiles : Profile
    {
        public BrandProfiles()
        {
            CreateMap<Brand, BrandAddDTO>().ReverseMap();
            CreateMap<Brand, BrandAddCommand>().ReverseMap();

            CreateMap<Brand, BrandDeleteDTO>().ReverseMap();
            CreateMap<Brand, BrandDeleteCommand>().ReverseMap();

            CreateMap<Brand, BrandUpdateDTO>().ReverseMap();
            CreateMap<Brand, BrandUpdateCommand>().ReverseMap();

            CreateMap<IPaginate<Brand>, BrandListModel>().ReverseMap();
            CreateMap<Brand, BrandListDTO>().ReverseMap();
            CreateMap<Brand, GetListBrandQuery>().ReverseMap();
            CreateMap<Brand, BrandGetByIdDTO>().ReverseMap();
            CreateMap<Brand, GetByIdBrandQuery>().ReverseMap();
        }
    }
}