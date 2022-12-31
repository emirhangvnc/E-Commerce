using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Base.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.ProductBrands.DTOs
{
    public class ProductBrandUpdateDTO : UpdateDTO, IDTO
    {
        public int ProductId { get; set; }
        public int BrandId { get; set; }
    }
}