using Core.Persistence.Paging;
using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Concrete.ProductFeatures.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.ProductFeatures.Model
{
    public class ProductFeatureListModel : BasePageableModel, IModel
    {
        public IList<ProductFeatureListDTO> Items { get; set; }
    }
}