using Core.Utilities.Results;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Favorites.Rules
{
    public interface IFavoriteBusinessRules
    {
        Task<IDataResult<Favorite>> IsIDExists(int id);
    }
}