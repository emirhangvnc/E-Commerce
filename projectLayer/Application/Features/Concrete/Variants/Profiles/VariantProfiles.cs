using AutoMapper;
using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Concrete.Variants.Commands.AddVariant;
using eCommerceLayer.Application.Features.Concrete.Variants.Commands.DeleteVariant;
using eCommerceLayer.Application.Features.Concrete.Variants.Commands.UpdateVariant;
using eCommerceLayer.Application.Features.Concrete.Variants.DTOs;
using eCommerceLayer.Application.Features.Concrete.Variants.Model;
using eCommerceLayer.Application.Features.Concrete.Variants.Queries.GetAllVariant;
using eCommerceLayer.Application.Features.Concrete.Variants.Queries.GetByIdVariant;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Variants.Profiles
{
    public class VariantProfiles : Profile
    {
        public VariantProfiles()
        {
            CreateMap<Variant, VariantAddDTO>().ReverseMap();
            CreateMap<Variant, VariantAddCommand>().ReverseMap();
                      
            CreateMap<Variant, VariantDeleteDTO>().ReverseMap();
            CreateMap<Variant, VariantDeleteCommand>().ReverseMap();
                      
            CreateMap<Variant, VariantUpdateDTO>().ReverseMap();
            CreateMap<Variant, VariantUpdateCommand>().ReverseMap();

            CreateMap<IPaginate<Variant>, VariantListModel>().ReverseMap();
            CreateMap<Variant, VariantListDTO>().ReverseMap();
            CreateMap<Variant, GetListVariantQuery>().ReverseMap();

            CreateMap<Variant, VariantGetByIdDTO>().ReverseMap();
            CreateMap<Variant, GetByIdVariantQuery>().ReverseMap();
        }
    }
}