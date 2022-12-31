using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Variants.Model;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Variants.Queries.GetAllVariant
{
    public class GetListVariantQuery : IRequest<IDataResult<Variant>>
    {
        public PageRequest PageRequest { get; set; }
        public class GetListVariantQueryHandler : IRequestHandler<GetListVariantQuery, IDataResult<Variant>>
        {
            private readonly IVariantRepository _variantRepository;
            private readonly IMapper _mapper;

            public GetListVariantQueryHandler(IVariantRepository variantRepository, IMapper mapper)
            {
                _variantRepository = variantRepository;
                _mapper = mapper;
            }

            public async Task<IDataResult<Variant>> Handle(GetListVariantQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Variant> variant = await _variantRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
                if (variant.Items.Count <= 0)
                    return new ErrorDataResult<Variant>("Variant Not Found");
                var mappedVariantListModel = _mapper.Map<VariantListModel>(variant);

                return new SuccessDataResult<Variant>(mappedVariantListModel, "Variants Listed");
            }
        }
    }
}