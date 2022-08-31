using MediatR;
using projectLayer.Application.Features.Brands.Models;

namespace projectLayer.Application.Features.Brands.Queries.GetListBrand
{
    public class GetListBrandQuery:IRequest<BrandListModel>
    {
        public class GetListBrandQueryHandler : IRequestHandler<GetListBrandQuery, BrandListModel>
        {
            public Task<BrandListModel> Handle(GetListBrandQuery request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}