using Core.Persistence.Paging;
using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Concrete.Variants.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Variants.Model
{
    public class VariantListModel : BasePageableModel, IModel
    {
        public IList<VariantListDTO> Items { get; set; }
    }
}