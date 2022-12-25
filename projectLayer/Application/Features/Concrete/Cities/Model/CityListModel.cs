using Core.Persistence.Paging;
using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Concrete.Cities.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Cities.Model
{
    public class CityListModel : BasePageableModel, IModel
    {
        public IList<CityListDTO> Items { get; set; }
    }
}