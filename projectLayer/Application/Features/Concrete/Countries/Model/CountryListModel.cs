using Core.Persistence.Paging;
using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Concrete.Countries.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Countries.Model
{
    public class CountryListModel : BasePageableModel, IModel
    {
        public IList<CountryListDTO> Items { get; set; }
    }
}