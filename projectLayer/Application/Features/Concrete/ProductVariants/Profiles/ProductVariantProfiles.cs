using AutoMapper;
using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Concrete.ProductVariants.Commands.AddVariant;
using eCommerceLayer.Application.Features.Concrete.ProductVariants.Commands.DeleteVariant;
using eCommerceLayer.Application.Features.Concrete.ProductVariants.Commands.UpdateVariant;
using eCommerceLayer.Application.Features.Concrete.ProductVariants.DTOs;
using eCommerceLayer.Application.Features.Concrete.ProductVariants.Model;
using eCommerceLayer.Application.Features.Concrete.ProductVariants.Queries.GetByIdProductVariant;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.ProductVariants.Profiles
{
    public class ProductVariantProfiles : Profile
    {
        public ProductVariantProfiles()
        {
            CreateMap<ProductVariant, ProductVariantAddDTO>().ReverseMap();
            CreateMap<ProductVariant, ProductVariantAddCommand>().ReverseMap();
                             
            CreateMap<ProductVariant, ProductVariantDeleteDTO>().ReverseMap();
            CreateMap<ProductVariant, ProductVariantDeleteCommand>().ReverseMap();
                            
            CreateMap<ProductVariant, ProductVariantUpdateDTO>().ReverseMap();
            CreateMap<ProductVariant, ProductVariantUpdateCommand>().ReverseMap();

            CreateMap<IPaginate<ProductVariant>, ProductVariantListModel>().ReverseMap();
            CreateMap<ProductVariant, ProductVariantListDTO>().ReverseMap();

            CreateMap<ProductVariant, ProductVariantGetByIdDTO>().ReverseMap();
            CreateMap<ProductVariant, GetByIdProductVariantQuery>().ReverseMap();
        }
    }
}