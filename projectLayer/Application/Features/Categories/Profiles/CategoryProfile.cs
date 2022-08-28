using AutoMapper;
using projectLayer.Application.Features.Categories.DTOs;
using projectLayer.Domain.Entities;

namespace Application.Features.Categories.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryAddDTO, Category>().ReverseMap();
            CreateMap<CategoryUpdateDTO, Category>().ReverseMap();
            CreateMap<CategoryDeleteDTO, Category>().ReverseMap();
        }
    }
}