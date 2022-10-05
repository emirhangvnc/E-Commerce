using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Concrete.Categories.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Models
{
    public class CategoryListModel : BasePageableModel
    {
        public IList<CategoryListDTO> Items { get; set; }
    }
}