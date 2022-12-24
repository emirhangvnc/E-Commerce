using Core.Persistence.Paging;
using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Concrete.Brands.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Model
{
    public class BrandListModel : BasePageableModel, IModel
    {
        public IList<BrandListDTO> Items { get; set; }
    }
}