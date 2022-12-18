using Core.Persistence.Paging;
using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Concrete.Features.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Features.Model
{
    public class FeatureListModel : BasePageableModel,IModel
    {
        public IList<FeatureListDTO> Items { get; set; }
    }
}