using AutoMapper;
using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Concrete.Categories.Commands.AddCategory;
using eCommerceLayer.Application.Features.Concrete.Categories.Commands.DeleteFeature;
using eCommerceLayer.Application.Features.Concrete.Categories.Commands.UpdateCategory;
using eCommerceLayer.Application.Features.Concrete.Categories.DTOs;
using eCommerceLayer.Application.Features.Concrete.Categories.Model;
using eCommerceLayer.Application.Features.Concrete.Categories.Queries.GetAllCategories;
using eCommerceLayer.Application.Features.Concrete.Categories.Queries.GetByIdCategories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Profiles
{
    public class CategoryProfiles : Profile
    {
        public CategoryProfiles()
        {
            CreateMap<Category, CategoryAddDTO>().ReverseMap();
            CreateMap<Category, CategoryAddCommand>().ReverseMap();

            CreateMap<Category, CategoryDeleteDTO>().ReverseMap();
            CreateMap<Category, CategoryDeleteCommand>().ReverseMap();

            CreateMap<Category, CategoryUpdateDTO>().ReverseMap();
            CreateMap<Category, CategoryUpdateCommand>().ReverseMap();

            CreateMap<IPaginate<Category>, CategoryListModel>().ReverseMap();
            CreateMap<Category, CategoryListDTO>().ReverseMap();
            CreateMap<Category, GetListCategoryQuery>().ReverseMap();
            CreateMap<Category, CategoryGetByIdDTO>().ReverseMap();
            CreateMap<Category, GetByIdCategoriesQuery>().ReverseMap();
        }
    }
}