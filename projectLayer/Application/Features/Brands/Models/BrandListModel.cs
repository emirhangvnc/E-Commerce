using Core.Persistence.Paging;
using projectLayer.Application.Features.Brands.DTOs;

namespace projectLayer.Application.Features.Brands.Models
{
    public class BrandListModel:BasePageableModel
    {
        public IList<BrandListDTO> Items { get; set; }
    }
}