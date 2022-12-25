using AutoMapper;
using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Concrete.FeatureValues.Commands.AddFeature;
using eCommerceLayer.Application.Features.Concrete.FeatureValues.Commands.DeleteFeature;
using eCommerceLayer.Application.Features.Concrete.FeatureValues.Commands.UpdateFeature;
using eCommerceLayer.Application.Features.Concrete.FeatureValues.DTOs;
using eCommerceLayer.Application.Features.Concrete.FeatureValues.Model;
using eCommerceLayer.Application.Features.Concrete.FeatureValues.Queries.GetAllFeature;
using eCommerceLayer.Application.Features.Concrete.FeatureValues.Queries.GetByIdFeature;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.FeatureValues.Profiles
{
    public class FeatureProfiles : Profile
    {
        public FeatureProfiles()
        {
            CreateMap<FeatureValue, FeatureValueAddDTO>().ReverseMap();
            CreateMap<FeatureValue, FeatureValueAddCommand>().ReverseMap();

            CreateMap<FeatureValue, FeatureValueDeleteDTO>().ReverseMap();
            CreateMap<FeatureValue, FeatureValueDeleteCommand>().ReverseMap();

            CreateMap<FeatureValue, FeatureValueUpdateDTO>().ReverseMap();
            CreateMap<FeatureValue, FeatureValueUpdateCommand>().ReverseMap();

            CreateMap<IPaginate<FeatureValue>, FeatureValueListModel>().ReverseMap();
            CreateMap<FeatureValue, FeatureValueListDTO>().ReverseMap();
            CreateMap<FeatureValue, GetListFeatureValueQuery>().ReverseMap();
            CreateMap<FeatureValue, FeatureValueGetByIdDTO>().ReverseMap();
            CreateMap<FeatureValue, GetByIdFeatureValueQuery>().ReverseMap();
        }
    }
}