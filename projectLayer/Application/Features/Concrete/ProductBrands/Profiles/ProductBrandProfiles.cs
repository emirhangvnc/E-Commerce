using AutoMapper;
using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Concrete.ProductBrands.Commands.AddProductBrand;
using eCommerceLayer.Application.Features.Concrete.ProductBrands.Commands.DeleteProductBrand;
using eCommerceLayer.Application.Features.Concrete.ProductBrands.Commands.UpdateProductBrand;
using eCommerceLayer.Application.Features.Concrete.ProductBrands.DTOs;
using eCommerceLayer.Application.Features.Concrete.ProductBrands.Model;
using eCommerceLayer.Application.Features.Concrete.ProductBrands.Queries.GetByIdProductBrand;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.ProductBrands.Profiles
{
    public class ProductBrandProfiles : Profile
    {
        public ProductBrandProfiles()
        {
            CreateMap<ProductBrand, ProductBrandAddDTO>().ReverseMap();
            CreateMap<ProductBrand, ProductBrandAddCommand>().ReverseMap();
                                          
            CreateMap<ProductBrand, ProductBrandDeleteDTO>().ReverseMap();
            CreateMap<ProductBrand, ProductBrandDeleteCommand>().ReverseMap();
                                           
            CreateMap<ProductBrand, ProductBrandUpdateDTO>().ReverseMap();
            CreateMap<ProductBrand, ProductBrandUpdateCommand>().ReverseMap();

            CreateMap<IPaginate<ProductBrand>, ProductBrandListModel>().ReverseMap();
            CreateMap<ProductBrand, ProductBrandListDTO>().ReverseMap();

            CreateMap<ProductBrand , ProductBrandGetByIdDTO>().ReverseMap();
            CreateMap<ProductBrand, GetByIdProductBrandQuery>().ReverseMap();
        }
    }
}