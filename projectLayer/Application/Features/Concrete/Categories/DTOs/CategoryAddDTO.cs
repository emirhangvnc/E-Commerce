using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.Categories.DTOs
{
    public class CategoryAddDTO : IDTO
    {
        public string CategoryName { get; set; }
    }
}