using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Concrete.Brands.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Models
{
    public class BrandListModel:BasePageableModel
    {
        public IList<BrandListDTO> Items { get; set; }
    }
}