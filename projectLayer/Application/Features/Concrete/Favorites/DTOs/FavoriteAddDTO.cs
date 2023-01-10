using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.Favorites.DTOs
{
    public class FavoriteAddDTO : IDTO
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}