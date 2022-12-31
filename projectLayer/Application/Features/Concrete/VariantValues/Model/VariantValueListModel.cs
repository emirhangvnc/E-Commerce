using Core.Persistence.Paging;
using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Concrete.VariantValues.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.VariantValues.Model
{
    public class VariantValueListModel : BasePageableModel, IModel
    {
        public IList<VariantValueListDTO> Items { get; set; }
    }
}