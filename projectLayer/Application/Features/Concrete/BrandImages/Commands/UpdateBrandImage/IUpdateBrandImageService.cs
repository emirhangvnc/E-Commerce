using eCommerceLayer.Application.Features.Base.Abstract.Commands;
using eCommerceLayer.Application.Features.Concrete.BrandImages.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.BrandImages.Commands.UpdateBrandImage
{
    public interface IUpdateBrandImageService : IUpdateService<BrandImageUpdateDTO>
    {
    }
}