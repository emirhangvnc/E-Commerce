using Core.Persistence.Paging;
using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Concrete.Categories.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Model
{
    public class CategoryListModel : BasePageableModel,IModel
    {
        public IList<CategoryListDTO> Items { get; set; }
    }
}