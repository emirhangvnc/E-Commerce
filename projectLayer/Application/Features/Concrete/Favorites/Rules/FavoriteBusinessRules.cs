using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Favorites.Rules
{
    public class FavoriteBusinessRules : ManagerBase, IFavoriteBusinessRules
    {
        IFavoriteRepository _favoriteRepository;
        public FavoriteBusinessRules(IMapper mapper, IFavoriteRepository favoriteRepository) : base(mapper)
        {
            _favoriteRepository = favoriteRepository;
        }

        public async Task<IDataResult<Favorite>> IsIDExists(int id)
        {
            var result = await _favoriteRepository.GetAsync(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<Favorite>("Favorite Not Found");

            return new SuccessDataResult<Favorite>(result);
        }
    }
}