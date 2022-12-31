using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.ProductCategories.DTOs
{
    public class ProductCategoryListDTO : IDTO
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
    }
}