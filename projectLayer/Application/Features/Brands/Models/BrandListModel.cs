using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Brands.DTOs;

namespace eCommerceLayer.Application.Features.Brands.Models
{
    public class BrandListModel:BasePageableModel
    {
        public IList<BrandListDTO> Items { get; set; }
    }
}