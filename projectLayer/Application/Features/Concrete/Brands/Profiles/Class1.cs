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
    public class CategoryProfiles : Profile
    {
        public CategoryProfiles()
        {
            CreateMap<Category, BrandAddDTO>().ReverseMap();
            CreateMap<Category, BrandAddCommand>().ReverseMap();

            CreateMap<Category, BrandDeleteDTO>().ReverseMap();
            CreateMap<Category, BrandDeleteCommand>().ReverseMap();

            CreateMap<Category, BrandUpdateDTO>().ReverseMap();
            CreateMap<Category, BrandUpdateCommand>().ReverseMap();

            CreateMap<IPaginate<Category>, BrandListModel>().ReverseMap();
            CreateMap<Category, BrandListDTO>().ReverseMap();
            CreateMap<Category, GetListBrandQuery>().ReverseMap();
            CreateMap<Category, BrandGetByIdDTO>().ReverseMap();
            CreateMap<Category, GetByIdBrandQuery>().ReverseMap();
        }
    }
}