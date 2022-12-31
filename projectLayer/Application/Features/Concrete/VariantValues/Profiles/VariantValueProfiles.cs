using AutoMapper;
using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Concrete.VariantValues.Commands.AddVariantValue;
using eCommerceLayer.Application.Features.Concrete.VariantValues.Commands.DeleteVariantValue;
using eCommerceLayer.Application.Features.Concrete.VariantValues.Commands.UpdateVariantValue;
using eCommerceLayer.Application.Features.Concrete.VariantValues.DTOs;
using eCommerceLayer.Application.Features.Concrete.VariantValues.Model;
using eCommerceLayer.Application.Features.Concrete.VariantValues.Queries.GetAllVariantValue;
using eCommerceLayer.Application.Features.Concrete.VariantValues.Queries.GetByIdVariantValue;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.VariantValues.Profiles
{
    public class VariantValueProfiles : Profile
    {
        public VariantValueProfiles()
        {
            CreateMap<Variant, VariantValueAddDTO>().ReverseMap();
            CreateMap<Variant, VariantValueAddCommand>().ReverseMap();
                     
            CreateMap<Variant, VariantValueDeleteDTO>().ReverseMap();
            CreateMap<Variant, VariantValueDeleteCommand>().ReverseMap();
                   
            CreateMap<Variant, VariantValueUpdateDTO>().ReverseMap();
            CreateMap<Variant, VariantValueUpdateCommand>().ReverseMap();

            CreateMap<IPaginate<VariantValue>, VariantValueListModel>().ReverseMap();
            CreateMap<VariantValue, VariantValueListDTO>().ReverseMap();
            CreateMap<VariantValue, GetListVariantValueQuery>().ReverseMap();
            CreateMap<VariantValue, VariantValueGetByIdDTO>().ReverseMap();
            CreateMap<VariantValue, GetByIdVariantValueQuery>().ReverseMap();
        }
    }
}