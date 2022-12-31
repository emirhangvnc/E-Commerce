using Core.Persistence.Paging;
using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Concrete.ProductBrands.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.ProductBrands.Model
{
    public class ProductBrandListModel : BasePageableModel, IModel
    {
        public IList<ProductBrandListDTO> Items { get; set; }
    }
}