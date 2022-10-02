using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Categories.DTOs;

namespace eCommerceLayer.Application.Features.Categories.Models
{
    public class CategoryListModel : BasePageableModel
    {
        public IList<CategoryListDTO> Items { get; set; }
    }
}