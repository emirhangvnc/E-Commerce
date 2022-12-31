using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Base.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.ProductCategories.DTOs
{
    public class ProductCategoryUpdateDTO : UpdateDTO, IDTO
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
    }
}