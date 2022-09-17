using eCommerceLayer.Application.Features.Base.DTOs;
using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Products.DTOs
{
    public class ProductDeleteDTO : DeleteDTO, IDTO
    {
        public ProductDeleteDTO(int id)
        {
            Id = id;
        }
    }
}