using Core.Persistence.Paging;
using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Concrete.ProductVariants.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.ProductVariants.Model
{
    public class ProductVariantListModel : BasePageableModel, IModel
    {
        public IList<ProductVariantListDTO> Items { get; set; }
    }
}