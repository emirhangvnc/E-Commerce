using Core.Persistence.Paging;
using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Concrete.ProductCategories.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.ProductCategories.Model
{
    public class ProductCategoryListModel : BasePageableModel, IModel
    {
        public IList<ProductCategoryListDTO> Items { get; set; }
    }
}