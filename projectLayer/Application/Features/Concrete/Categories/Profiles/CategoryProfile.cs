using AutoMapper;
using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Concrete.Categories.DTOs;
using eCommerceLayer.Domain.Entities;

namespace v.Application.Features.Concrete.Categories.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryAddDTO, Category>().ReverseMap();
            CreateMap<CategoryUpdateDTO, Category>().ReverseMap();
            CreateMap<CategoryDeleteDTO, Category>().ReverseMap();
            CreateMap<CategoryGetByIdDto, Category>().ReverseMap();
            CreateMap<IPaginate<CategoryListDTO>, Category>().ReverseMap();
        }
    }
}