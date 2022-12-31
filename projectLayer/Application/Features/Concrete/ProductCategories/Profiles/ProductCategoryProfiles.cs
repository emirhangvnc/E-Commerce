using AutoMapper;
using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Concrete.ProductCategories.Commands.AddProductCategory;
using eCommerceLayer.Application.Features.Concrete.ProductCategories.Commands.DeleteProductCategory;
using eCommerceLayer.Application.Features.Concrete.ProductCategories.Commands.UpdateProductCategory;
using eCommerceLayer.Application.Features.Concrete.ProductCategories.DTOs;
using eCommerceLayer.Application.Features.Concrete.ProductCategories.Model;
using eCommerceLayer.Application.Features.Concrete.ProductCategories.Queries.GetByIdProductCategory;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.ProductCategories.Profiles
{
    public class ProductCategoryProfiles : Profile
    {
        public ProductCategoryProfiles()
        {
            CreateMap<ProductCategory, ProductCategoryAddDTO>().ReverseMap();
            CreateMap<ProductCategory, ProductCategoryAddCommand>().ReverseMap();

            CreateMap<ProductCategory, ProductCategoryDeleteDTO>().ReverseMap();
            CreateMap<ProductCategory, ProductCategoryDeleteCommand>().ReverseMap();

            CreateMap<ProductCategory, ProductCategoryUpdateDTO>().ReverseMap();
            CreateMap<ProductCategory, ProductCategoryUpdateCommand>().ReverseMap();

            CreateMap<IPaginate<ProductCategory>, ProductCategoryListModel>().ReverseMap();
            CreateMap<ProductCategory, ProductCategoryListDTO>().ReverseMap();
                             
            CreateMap<ProductCategory, ProductCategoryGetByIdDTO>().ReverseMap();
            CreateMap<ProductCategory, GetByIdProductCategoryQuery>().ReverseMap();
        }
    }
}