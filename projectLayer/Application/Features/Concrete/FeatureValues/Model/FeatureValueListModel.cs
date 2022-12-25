using Core.Persistence.Paging;
using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Concrete.FeatureValues.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.FeatureValues.Model
{
    public class FeatureValueListModel : BasePageableModel,IModel
    {
        public IList<FeatureValueListDTO> Items { get; set; }
    }
}