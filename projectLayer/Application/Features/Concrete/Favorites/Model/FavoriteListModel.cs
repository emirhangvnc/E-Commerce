using Core.Persistence.Paging;
using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Concrete.Favorites.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Favorites.Model
{
    public class FavoriteListModel : BasePageableModel, IModel
    {
        public IList<FavoriteListDTO> Items { get; set; }
    }
}