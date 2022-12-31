using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.FeatureValues.Model;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.VariantValues.Queries.GetAllVariantValue
{
    public class GetListVariantValueQuery : IRequest<IDataResult<VariantValue>>
    {
        public PageRequest PageRequest { get; set; }
        public class GetListVariantValueQueryHandler : IRequestHandler<GetListVariantValueQuery, IDataResult<VariantValue>>
        {
            private readonly IVariantValueRepository _variantValueRepository;
            private readonly IMapper _mapper;

            public GetListVariantValueQueryHandler(IVariantValueRepository variantValueRepository, IMapper mapper)
            {
                _variantValueRepository = variantValueRepository;
                _mapper = mapper;
            }

            public async Task<IDataResult<VariantValue>> Handle(GetListVariantValueQuery request, CancellationToken cancellationToken)
            {
                IPaginate<VariantValue> variantValue = await _variantValueRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
                if (variantValue.Items.Count <= 0)
                    return new ErrorDataResult<VariantValue>("Variant Value Not Found");
                var mappedVariantValueListModel = _mapper.Map<FeatureValueListModel>(variantValue);

                return new SuccessDataResult<VariantValue>(mappedVariantValueListModel, "Variant Values Listed");
            }
        }
    }
}